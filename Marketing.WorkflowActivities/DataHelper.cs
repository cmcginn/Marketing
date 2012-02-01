using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
using Marketing.Utils;
namespace Marketing.WorkflowActivities {
  public class DataHelper {
    public static List<UserListingData> GetUserListingDatasForUser( MarketingEntities context,Guid userId) {
      return context.UserListingDatas.Where( n => n.UserId == userId ).ToList();
    }
    public static List<UserListingKeywordScore> GetUserListingKeywordScoresForUser( MarketingEntities context, Guid userId ) {
      return context.UserListingKeywordScores.Where( n => n.UserId == userId ).ToList();
    }
    public static List<UserKeyword> GetUserKeywordsForUser( MarketingEntities context, Guid userId ) {
      return context.UserKeywords.Where( n => n.UserId == userId ).ToList();
    }
    public static List<UserListingData> GetUserListingDataForUser( MarketingEntities context, Guid userId ) {
      return context.UserListingDatas.Where( n => n.UserId == userId ).ToList();
    }
    public static List<UserListingRefresh> GetUrlsForUser( MarketingEntities context, Guid userId ) {
      var result = context.UserListingRefreshes.Where( n => n.UserId == userId ).ToList();
      return result;
    }
    public static ListingUrl GetListingUrl( MarketingEntities context, string url ) {
      var result = context.ListingUrls.SingleOrDefault( n => n.Url == url );
      return result;
    }
    public static UserListingUrl GetUserListingUrl( MarketingEntities context, ListingUrl listingUrl, Guid userId ) {
      var result = context.UserListingUrls.SingleOrDefault( n => n.ListingUrlId == listingUrl.Id && n.UserId == userId );
      return result;
    }
    public static List<ListingUrl> GetListingUrlsForUser( MarketingEntities context, Guid userId ) {
      var query = from userListing in context.UserListingUrls.Where( x => x.UserId == userId )
                  join listing in context.ListingUrls
                  on userListing.ListingUrlId equals listing.Id
                  join listingContent in context.ListingContents
                  on listing.Id equals listingContent.ListingUrlId into contents
                  from content in contents.DefaultIfEmpty()
                  where content == null
                  select listing;
      return query.ToList();

    }
    public static ListingContent GetListingContentItemByListingUrlId( MarketingEntities context, ListingUrl item, ListingContentItem listingContentItem ) {
      //New ListingContent With { }
      var result = context.ListingContents.SingleOrDefault( x => x.ListingUrlId == item.Id );
      if( result == null ) {
        result = new ListingContent {
          Id = Guid.NewGuid(),
          PostContent = listingContentItem.ContentHtml.ToString(),
          PostElement = listingContentItem.ContentElement.ToString(),
          ListingUrlId = item.Id,
          Created = System.DateTime.Now,
          PostDate = listingContentItem.PostDate,
          ReplyTo = listingContentItem.ReplyTo
        };
        context.ListingContents.AddObject( result );
      }
      return result;
    }
    public static void PurgeExpiredListings( MarketingEntities context, DateTime expiration ) {
      var query = from lc in context.ListingContents.Where( n => n.PostDate < expiration )
                  join liu in context.ListingUrls on lc.ListingUrlId equals liu.Id
                  join ulu in context.UserListingUrls on liu.Id equals ulu.ListingUrlId
                  let ulr = context.UserListingResponses.Where( n => n.UserListingUrlId == ulu.ListingUrlId ).Count()
                  select new { Listing = liu, ResponseCount = ulr };
      var purge = query.Where( n => n.ResponseCount == 0 ).Select( n => n.Listing ).Distinct();
      purge.ToList().ForEach( n => {
        context.ListingUrls.DeleteObject( n );  
      } );
      context.SaveChanges();
    }
  }
}
