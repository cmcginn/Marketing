using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
using Marketing.Utils;
namespace Marketing.WorkflowActivities
{
    public class DataHelper
    {
        public static List<UserListingData> GetUserListingDatasForUser(MarketingEntities context, Guid userId)
        {
            return context.UserListingDatas.Where(n => n.UserId == userId).ToList();
        }
        public static List<UserListingKeywordScore> GetUserListingKeywordScoresForUser(MarketingEntities context, Guid userId)
        {
            return context.UserListingKeywordScores.Where(n => n.UserId == userId).ToList();
        }
        public static List<UserKeyword> GetUserKeywordsForUser(MarketingEntities context, Guid userId)
        {
            return context.UserKeywords.Where(n => n.UserId == userId).ToList();
        }
        public static List<UserListingData> GetUserListingDataForUser(MarketingEntities context, Guid userId)
        {
            return context.UserListingDatas.Where(n => n.UserId == userId).ToList();
        }
        public static List<UserListingRefresh> GetUrlsForUser(MarketingEntities context, Guid userId)
        {
            var result = context.UserListingRefreshes.Where(n => n.UserId == userId).ToList();
            return result;
        }
        public static ListingUrl GetListingUrl(MarketingEntities context, string url)
        {
            var result = context.ListingUrls.SingleOrDefault(n => n.Url == url);
            return result;
        }
        public static UserListingUrl GetUserListingUrl(MarketingEntities context, ListingUrl listingUrl, Guid userId)
        {
            var result = context.UserListingUrls.SingleOrDefault(n => n.ListingUrlId == listingUrl.Id && n.UserId == userId);
            return result;
        }
        public static List<UserListingUrl> GetListingUrlsWithoutContentForUser(MarketingEntities context, Guid userId)
        {
            var query = from ul in context.UserListingUrls.Where(n => n.UserId == userId)
                        join listingUrl in context.ListingUrls
                        on ul.ListingUrlId equals listingUrl.Id
                        join c in context.ListingContents on listingUrl.Id equals c.ListingUrlId into listingContents
                        from listingContent in listingContents.DefaultIfEmpty()
                        where listingContent == null
                        select ul;
            return query.ToList();
        }   

        public static List<UserListingUrl> GetListingUrlsForUser(MarketingEntities context, Guid userId)
        {
            var query = from userData in context.UserListingDatas.Where(n => n.UserId == userId && n.CityActive && n.ListingCategoryActive).Select(n => n.UserListingUrlId)
            join userListing in context.UserListingUrls on userData equals userListing.Id
            select userListing;
            return query.ToList();

        }
        public static ListingContent GetListingContentItemByListingUrlId(MarketingEntities context, ListingUrl item, ListingContentItem listingContentItem)
        {
            //New ListingContent With { }
            var result = context.ListingContents.SingleOrDefault(x => x.ListingUrlId == item.Id);
            if (result == null)
            {
                result = new ListingContent
                {
                    Id = Guid.NewGuid(),
                    PostContent = listingContentItem.ContentHtml.ToString(),
                    PostElement = listingContentItem.ContentElement.ToString(),
                    ListingUrlId = item.Id,
                    Created = System.DateTime.Now,
                    PostDate = listingContentItem.PostDate,
                    ReplyTo = listingContentItem.ReplyTo
                };
                context.ListingContents.AddObject(result);
            }
            return result;
        }
        public static void PurgeExpiredListings(MarketingEntities context, DateTime expiration)
        {
            var query = from lc in context.ListingContents.Where(n => n.PostDate < expiration)
                        join liu in context.ListingUrls on lc.ListingUrlId equals liu.Id
                        join ulu in context.UserListingUrls on liu.Id equals ulu.ListingUrlId
                        let ulr = context.UserListingResponses.Where(n => n.UserListingUrlId == ulu.ListingUrlId).Count()
                        select new { Listing = liu, ResponseCount = ulr };
            var purge = query.Where(n => n.ResponseCount == 0).Select(n => n.Listing).Distinct();
            purge.ToList().ForEach(n =>
            {
                context.ListingUrls.DeleteObject(n);
            });
            context.SaveChanges();
        }
        public static int GetMinimumKeywordScoreByUserId(MarketingEntities context, Guid userId)
        {
            var result = context.UserPreferences.Single(n => n.UserId == userId).MinimumKeywordScore;
            return result;
        }
        public static void RefreshUserListingKeywordScoreForUser(MarketingEntities context, UserListingUrl userListingUrl, List<UserKeyword> keywords,int minimumKeywordScore)
        {
            
            var content = userListingUrl.ListingUrl.ListingContents.SingleOrDefault();
            var existing = userListingUrl.UserListingKeywordScores.SingleOrDefault();
            if (content == null)
            {
                
                if (existing != null)
                    context.UserListingKeywordScores.DeleteObject(existing);
            }
            else
            {
                //get existing or new keywordscore
                var defaultKeywordScore = GetUserListingKeywordScoreForContent(context, userListingUrl, keywords, content.PostContent);
                if (minimumKeywordScore > 0 && defaultKeywordScore.KeywordScore < minimumKeywordScore)
                {
                    //we need to purge this record only if no response sent
                    if (userListingUrl.UserListingResponses.Count == 0)
                    {
                        context.UserListingKeywordScores.DeleteObject(defaultKeywordScore);
                        context.UserListingUrls.DeleteObject(userListingUrl);
                    }
                }
                else
                {
                    //if this is new add to context
                    if (existing == null)
                        context.UserListingKeywordScores.AddObject(defaultKeywordScore);
                }

            }
        }
        static void CalculateUserListingKeywordScoreForContent(UserListingKeywordScore userListingKeywordScore,List<UserKeyword> userKeywords,string content)
        {
            userListingKeywordScore.KeywordScore = 0;
            userListingKeywordScore.KeywordDisplay = String.Empty;
            var loweredContent = content.ToLower();
            List<string> keywordsMatched = new List<string>();
            userKeywords.ForEach(n =>
            {
                if (loweredContent.Contains(n.Keyword.ToLower()))
                {
                    userListingKeywordScore.KeywordScore += n.WeightedScore;
                    keywordsMatched.Add(n.Keyword);
                }

            });
            userListingKeywordScore.KeywordDisplay = String.Join(",", keywordsMatched);

        }
        public static UserListingKeywordScore GetUserListingKeywordScoreForContent(MarketingEntities context, UserListingUrl userListingUrl, List<UserKeyword> keywords, string content)
        {
            var result = userListingUrl.UserListingKeywordScores.SingleOrDefault();

            if (result == null)
            {
                result = new UserListingKeywordScore { Id = Guid.NewGuid(), UserListingUrl = userListingUrl, UserId=userListingUrl.UserId };

            }
            CalculateUserListingKeywordScoreForContent(result, keywords, content);
            return result;

        }
        public static void SaveUserListingKeywordScore(MarketingEntities context, UserListingKeywordScore userListingKeywordScore)
        {
            if (context.UserListingKeywordScores.Count(x => x.Id == userListingKeywordScore.Id) < 1)
                context.UserListingKeywordScores.AddObject(userListingKeywordScore);
        }

    }
}
