using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
using System.Collections.Specialized;
using System.Xml.Linq;
using Marketing.Utils.Extensions;
using System.Net.Mail;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Logging;
namespace Marketing.Services.Extensions
{
    public static class DomainExtensions
    {
        public static IQueryable<User> GetUsers(this MarketingEntities context)
        {
            var result = context.vw_aspnet_MembershipUsers.Select(n => new User { Id = n.UserId, Username = n.UserName });
            return result.AsQueryable();
        }
        public static IQueryable<UserListingCategorySelection> GetUserListingCategorySelectionByUserId(this MarketingEntities context, Guid userId)
        {
            var query = from category in context.ListingCategories
                        join categoryGroup in context.ListingGroups
                        on category.ListingGroupId equals categoryGroup.Id
                        join userCategory in context.UserListingCategories.Where(n => n.UserId == userId)
                        on category.Id equals userCategory.ListingCategoryId into ulc

                        from item in ulc.DefaultIfEmpty()
                        select new UserListingCategorySelection { Id = item != null ? item.Id : Guid.NewGuid(), Active = item != null ? item.Active : true, CategoryName = category.ListingCategoryName, GroupName = categoryGroup.ListingGroupName, Selected = item != null ? true : false, UserId = item.UserId != Guid.Empty ? item.UserId : userId, CategoryId = category.Id };
            return query.AsQueryable();
        }
        public static IQueryable<UserCitySelection> GetUserCitySelections(this MarketingEntities context)
        {
            var query = from city in context.Cities
                        join uc in context.UserCities
                        on city.Id equals uc.CityId into usc
                        from item in usc.DefaultIfEmpty()
                        select new UserCitySelection { Id = item != null ? item.Id : Guid.Empty, Active = item.Active != null ? item.Active : true, CityId = city.Id, CityName = city.CityName, StateProvince = city.StateProvince, RegionName = city.RegionName, UserId = item.UserId != Guid.Empty ? item.UserId : Guid.Empty, Selected = item != null };

            return query.AsQueryable();
        }
        public static IQueryable<UserCitySelection> GetUserCitySelectionByUserId(this MarketingEntities context, Guid userId)
        {
            var query = from city in context.Cities
                        join uc in context.UserCities.Where(x => x.UserId == userId)
                        on city.Id equals uc.CityId into usc
                        from item in usc.DefaultIfEmpty()
                        select new UserCitySelection { Id = item != null ? item.Id : Guid.Empty, Active = item.Active != null ? item.Active : false, CityId = city.Id, CityName = city.CityName, StateProvince = city.StateProvince, RegionName = city.RegionName, UserId = item.UserId != Guid.Empty ? item.UserId : userId, Selected = item.Active };

            return query.AsQueryable();
        }
        public static IQueryable<UserKeywordSelection> GetUserKeywordSelections(this MarketingEntities context)
        {
            var query = from userKeyword in context.UserKeywords
                        select new UserKeywordSelection { Id = userKeyword.Id, Keyword = userKeyword.Keyword, UserId = userKeyword.UserId, WeightedScore = userKeyword.WeightedScore };
            return query;
        }
        public static IQueryable<UserKeywordSelection> GetUserKeywordSelectionByUserId(this MarketingEntities context, Guid userId)
        {
            var query = from userKeyword in context.UserKeywords.Where(x => x.UserId == userId)
                        select new UserKeywordSelection { Id = userKeyword.Id, Keyword = userKeyword.Keyword, UserId = userKeyword.UserId, WeightedScore = userKeyword.WeightedScore };
            return query;
        }
        public static IQueryable<UserPreferenceSelection> GetUserPreferenceSelection(this MarketingEntities context)
        {
            var query = from userPreference in context.UserPreferences
                        select new UserPreferenceSelection { Id = userPreference.Id, UserId = userPreference.UserId, MinimumKeywordScore = userPreference.MinimumKeywordScore, LiveMode = userPreference.LiveMode, BCCEmailAddress = userPreference.BCCEmailAddress, SMTPUsername = userPreference.SMTPUser, SMTPServer = userPreference.SMTPServer, SMTPPort = userPreference.SMTPPort, RequiresSSL = userPreference.RequiresSSL, SMTPPassword = userPreference.SMTPPassword };
            return query;
        }
        public static IQueryable<UserListingItem> GetUserListingItems(this MarketingEntities context)
        {
            var expired = System.DateTime.Now.AddDays(-30);
            var query = from userListingData in context.UserListingDatas.Where(x => x.PostContent != null & !String.IsNullOrEmpty(x.ReplyTo) && x.UserCityActive && x.UserListingCategoryActive && x.ListingGroupActive && x.PostDate >= expired && x.IsHidden == false)
                        select new UserListingItem
                        {
                            Id = userListingData.UserListingUrlId,
                            CategoryName = userListingData.ListingCategoryName,
                            CityName = userListingData.CityName,
                            StateProvince = userListingData.StateProvince,
                            GroupName = userListingData.ListingGroupName,
                            RegionName = userListingData.RegionName,
                            PostElement = userListingData.PostElement,
                            Created = userListingData.ListingUrlCreated,
                            Title = userListingData.Title,
                            UserId = userListingData.UserId,
                            Responded = userListingData.Responded,
                            ResponseId = userListingData.UserListingResponseId,
                            Response = userListingData.Response,
                            ResponseSent = userListingData.ResponseSent,
                            ResponseText = userListingData.ResponseText,
                            PostHtml = userListingData.PostContent,
                            CityActive = userListingData.CityActive,
                            UserCityActive = userListingData.UserCityActive,
                            ListingCategoryActive = userListingData.ListingCategoryActive,
                            KeywordScore = userListingData.KeywordScore,
                            KeywordDisplay = userListingData.KeywordDisplay,
                            IsHidden = userListingData.IsHidden,
                            UserFileId = userListingData.UserFileId

                        };

            return query;
        }
        public static IQueryable<UserListingItem> GetUserFilteredUserListingItems(this MarketingEntities context, Guid? userId, bool? filtersEnabled, bool? showResponded, bool? showNotResponded, DateTime? postStartDate, DateTime? postEndDate, DateTime? responseStartDate, DateTime? responseEndDate, string keywords, string regionsFilter, string statesFilter, string citiesFilter)
        {
            var expiration = System.DateTime.Now.AddDays(-30);
            var items = context.UserListingDatas.Where(x => x.PostContent != null & !String.IsNullOrEmpty(x.ReplyTo) && x.PostDate > expiration && x.IsHidden == false);

            var userIdValue = userId.GetValueOrDefault();
            var postStartDateValue = postStartDate.GetValueOrDefault();
            var postEndDateValue = postStartDate.GetValueOrDefault();
            var responseStartDateValue = responseStartDate.GetValueOrDefault();
            var responseEndDateValue = responseEndDate.GetValueOrDefault();

            if (userId.HasValue)
                items = items.Where(n => n.UserId == userIdValue);

            if (filtersEnabled.GetValueOrDefault())
            {
                if (postStartDate.HasValue)
                    items = items.Where(n => n.PostDate >= postStartDateValue);
                if (postEndDate.HasValue)
                    items = items.Where(n => n.PostDate <= postEndDateValue);
                if (responseStartDate.HasValue)
                    items = items.Where(n => n.Responded != null && n.Responded.Value >= responseStartDateValue);
                if (responseEndDate.HasValue)
                    items = items.Where(n => n.Responded != null && n.Responded.Value <= responseEndDateValue);
                if (!String.IsNullOrEmpty(keywords))
                {
                    keywords = keywords.ToLower();
                    items = items.Where(n => n.PostText.Contains(keywords));
                }
                if (!String.IsNullOrEmpty(regionsFilter))
                {
                    regionsFilter = regionsFilter.ToLower();
                    items = items.Where(n => n.RegionName.ToLower().Contains(regionsFilter));
                }
                if (!String.IsNullOrEmpty(statesFilter))
                {
                    statesFilter = statesFilter.ToLower();
                    items = items.Where(n => n.StateProvince.ToLower().Contains(statesFilter));
                }
                if (!String.IsNullOrEmpty(citiesFilter))
                {
                    citiesFilter = citiesFilter.ToLower();
                    items = items.Where(n => n.CityName.ToLower().Contains(citiesFilter));
                }
                if (!showResponded.GetValueOrDefault())
                    items = items.Where(n => n.Responded == null);
                if (!showNotResponded.GetValueOrDefault())
                    items = items.Where(n => n.Responded != null);
            }

            var query = from userListingData in items
                        select new UserListingItem
                        {
                            Id = userListingData.UserListingUrlId,
                            CategoryName = userListingData.ListingCategoryName,
                            CityName = userListingData.CityName,
                            StateProvince = userListingData.StateProvince,
                            GroupName = userListingData.ListingGroupName,
                            RegionName = userListingData.RegionName,
                            PostElement = userListingData.PostElement,
                            Created = userListingData.ListingUrlCreated,
                            Title = userListingData.Title,
                            UserId = userListingData.UserId,
                            Responded = userListingData.Responded,
                            ResponseId = userListingData.UserListingResponseId,
                            Response = userListingData.Response,
                            ResponseSent = userListingData.ResponseSent,
                            ResponseText = userListingData.ResponseText,
                            PostHtml = userListingData.PostContent,
                            CityActive = userListingData.CityActive,
                            UserCityActive = userListingData.UserCityActive,
                            ListingCategoryActive = userListingData.ListingCategoryActive,
                            KeywordScore = userListingData.KeywordScore,
                            KeywordDisplay = userListingData.KeywordDisplay,
                            IsHidden = userListingData.IsHidden,
                            UserFileId = userListingData.UserFileId
                        };

            return query;
        }
        public static IQueryable<UserListingItem> GetUserListingItemsByUserId(this MarketingEntities context, Guid userId)
        {
            var query = from userListingData in context.UserListingDatas.Where(x => x.PostContent != null & !String.IsNullOrEmpty(x.ReplyTo) && x.UserId == userId && x.IsHidden == false)
                        select new UserListingItem
                        {
                            Id = userListingData.UserListingUrlId,
                            CategoryName = userListingData.ListingCategoryName,
                            CityName = userListingData.CityName,
                            StateProvince = userListingData.StateProvince,
                            GroupName = userListingData.ListingGroupName,
                            RegionName = userListingData.RegionName,
                            PostElement = userListingData.PostElement,
                            Created = userListingData.ListingUrlCreated,
                            Title = userListingData.Title,
                            UserId = userListingData.UserId,
                            Responded = userListingData.Responded,
                            ResponseId = userListingData.UserListingResponseId,
                            Response = userListingData.Response,
                            ResponseSent = userListingData.ResponseSent,
                            ResponseText = userListingData.ResponseText,
                            PostHtml = userListingData.PostContent,
                            CityActive = userListingData.CityActive,
                            UserCityActive = userListingData.UserCityActive,
                            ListingCategoryActive = userListingData.ListingCategoryActive,
                            KeywordScore = userListingData.KeywordScore,
                            KeywordDisplay = userListingData.KeywordDisplay,
                            IsHidden = userListingData.IsHidden,
                            UserFileId = userListingData.UserFileId
                        };
            return query;
        }
        public static IQueryable<UserListingResponseItem> GetUserListingResponses(this MarketingEntities context)
        {
            var query = from userListingResponse in context.UserListingResponses
                        select new UserListingResponseItem
                        {
                            Id = userListingResponse.Id,
                            Created = userListingResponse.Created,
                            UserId = userListingResponse.UserListingUrl.UserId,
                            UserListingUrlId = userListingResponse.UserListingUrlId,
                            Response = userListingResponse.Response,
                            UserFileId = userListingResponse.UserFileId
                        };
            return query;
        }
        public static IQueryable<UserTemplateItem> GetUserTemplates(this MarketingEntities context)
        {
            var result = context.UserTemplates.Select(n => new UserTemplateItem
            {
                Created = n.Created,
                Id = n.Id,
                IsDefault = n.IsDefault,
                LastUpdated = n.Updated,
                TemplateHtml = n.TemplateHtml,
                TemplateText = n.TemplateText,
                TemplateName = n.TemplateName,
                UserId = n.UserId,
                UserFileId = n.UserFileId
            });
            return result;
        }
        public static IQueryable<ErrorDisplay> GetDefaultErrorDisplays(this MarketingEntities context)
        {
            var query = context.Logs.Where(n => n.EventID == 9000).Select(n => new ErrorDisplay
            {
                Id = n.EntityKey.ToString(),
                Message = n.FormattedMessage,
                Timestamp = n.Timestamp,
                Title = n.Title

            });
            return query;
        }
        public static void DeleteUserTemplateItem(this MarketingEntities context, UserTemplateItem item)
        {
            var target = context.UserTemplates.Single(x => x.Id == item.Id);
            context.UserTemplates.DeleteObject(target);
            context.SaveChanges();
        }
        static void SetDefaultUserTemplateItems(this MarketingEntities context, UserTemplate userTemplate)
        {
            var userTemplates = context.UserTemplates.Where(n => n.UserId == userTemplate.UserId).ToList();
            //set default if template is the only one
            if (userTemplates.Count == 0 || userTemplates.Where(n => n.IsDefault).Count() == 0)
                userTemplate.IsDefault = true;
            else
            {
                if (userTemplate.IsDefault)
                    userTemplates.Where(n => n.Id != userTemplate.Id).ToList().ForEach(n => n.IsDefault = false);
            }
        }
        public static void AddUserTemplateItem(this MarketingEntities context, UserTemplateItem userTemplateItem)
        {

            var template = new UserTemplate
            {
                Id = userTemplateItem.Id,
                UserId = userTemplateItem.UserId,
                Created = userTemplateItem.Created,
                TemplateHtml = userTemplateItem.TemplateHtml.NormalizeHtml(),
                TemplateText = userTemplateItem.TemplateText,
                TemplateName = userTemplateItem.TemplateName,
                IsDefault = userTemplateItem.IsDefault,
                UserFileId = userTemplateItem.UserFileId

            };
            context.SetDefaultUserTemplateItems(template);
            context.UserTemplates.AddObject(template);
            context.SaveChanges();
        }
        public static void UpdateUserTemplateItem(this MarketingEntities context, UserTemplateItem userTemplateItem)
        {
            var template = context.UserTemplates.Single(n => n.Id == userTemplateItem.Id);

            template.TemplateHtml = userTemplateItem.TemplateHtml.NormalizeHtml();
            template.TemplateText = userTemplateItem.TemplateText;
            template.TemplateName = userTemplateItem.TemplateName;
            template.UserFileId = userTemplateItem.UserFileId;
            template.IsDefault = userTemplateItem.IsDefault;
            template.Updated = System.DateTime.Now;
            context.SetDefaultUserTemplateItems(template);
            context.SaveChanges();
        }
        public static void UpdateUserListingItemVisibility(this MarketingEntities context, UserListingItem userListingItem)
        {
            var item = context.UserListingUrls.Single(n => n.Id == userListingItem.Id);
            item.IsHidden = userListingItem.IsHidden;
            context.SaveChanges();
        }
        public static UserListingResponse SaveUserListingResponse(this MarketingEntities context, UserListingItem item)
        {
            UserListingResponse result = null;
            var responseElement = System.Text.RegularExpressions.Regex.Replace(item.Response, "<!DOCTYPE html .*>", "");
            var converter = new Marketing.Utils.HtmlToXml.HtmlToXmlConverter();
            var responseHtml = converter.ConvertToXml(responseElement);
            var title = responseHtml.Descendants().FirstOrDefault(n => n.Name.LocalName.ToLower() == "title");
            if (title != null)
                title.Remove();
            responseElement = responseHtml.ToString();

            result = context.UserListingResponses.SingleOrDefault(x => x.UserListingUrlId == item.Id);
            if (result == null)
            {
                result = new UserListingResponse
                {
                    Created = System.DateTime.Now,
                    Id = Guid.NewGuid(),
                    UserListingUrlId = item.Id
                };
                context.UserListingResponses.AddObject(result);
            }
            result.UserFileId = item.UserFileId;
            result.Response = responseElement;
            result.ResponseText = item.ResponseText;
            context.SaveChanges();
            return result;
        }
        public static void SaveUserPreferencesSelection(this MarketingEntities context, UserPreferenceSelection item)
        {

            var result = context.UserPreferences.Single(x => x.Id == item.Id);
            result.LiveMode = item.LiveMode;
            result.BCCEmailAddress = item.BCCEmailAddress;
            result.SMTPPassword = item.SMTPPassword;
            result.RequiresSSL = item.RequiresSSL;
            result.SMTPPort = item.SMTPPort;
            result.MinimumKeywordScore = item.MinimumKeywordScore;
            result.SMTPServer = item.SMTPServer;
            result.SMTPUser = item.SMTPUsername;
            context.SaveChanges();
        }
        public static IQueryable<Operation> GetDefaultServerOperations()
        {
            List<Operation> result = new List<Operation>{
        new Operation{Id=1, OperationName="Refresh Posts",Parameters="UserId=;",Visible=true},
        new Operation{Id=2, OperationName="Refresh Keyword Scores",Parameters="UserId=;",Visible=false},
        new Operation{Id=3, OperationName="Purge Expired Content",Visible=true}
      };
            return result.AsQueryable();
        }
        public static System.Net.Mail.MailMessage GetMailMessage(this UserListingResponse item)
        {
            var userPreference = item.UserListingUrl.aspnet_Membership.UserPreferences.Single(x => x.UserId == item.UserListingUrl.UserId);
            System.Net.Mail.MailMessage result = null;
            var uri = new Uri(item.UserListingUrl.ListingUrl.ListingContents.First().ReplyTo);
            var nvc = System.Web.HttpUtility.ParseQueryString(uri.Query);
            var address = String.Format("{0}@{1}", uri.UserInfo, uri.DnsSafeHost);
            var subject = nvc[0];
            var body = item.ResponseText;
            //if( nvc.Count > 1 )
            //  body = String.Format( "{0}{1}{2}", body, System.Environment.NewLine, nvc[ 1 ] ); 

            var fromAddress = item.UserListingUrl.aspnet_Membership.UserPreferences.First().BCCEmailAddress;
            //if not live use BCC email, dont send to recipient

            if (!userPreference.LiveMode)
                address = fromAddress;
            result = new MailMessage(fromAddress, address, subject, body);
            result.IsBodyHtml = false;
            result.Bcc.Add(fromAddress);
            //result.AlternateViews.Add(System.Net.Mail.AlternateView.CreateAlternateViewFromString(item.Response, null, "text/html"));
            result.AlternateViews.Add(System.Net.Mail.AlternateView.CreateAlternateViewFromString(item.ResponseText, null, "text/plain"));
            return result;
        }
        public static bool SendUserListingResponse(this MarketingEntities context, UserListingResponse response)
        {
            bool result = false;
            var mailMessage = response.GetMailMessage();
            var userPreferences = response.UserListingUrl.aspnet_Membership.UserPreferences.First();
            var client = new System.Net.Mail.SmtpClient(userPreferences.SMTPServer, userPreferences.SMTPPort);
            client.Credentials = new System.Net.NetworkCredential(userPreferences.SMTPUser, userPreferences.SMTPPassword);
            client.EnableSsl = userPreferences.RequiresSSL;
            client.Send(mailMessage);
            result = true;
            response.ResponseSent = System.DateTime.Now;
            context.SaveChanges();
            return result;
        }
        static UserPreferenceSelection ToUserPreferenceSelection(this UserPreference userPreference)
        {
            var result = new UserPreferenceSelection
            {
                BCCEmailAddress = userPreference.BCCEmailAddress,
                Id = userPreference.Id,
                LiveMode = userPreference.LiveMode,
                MinimumKeywordScore = userPreference.MinimumKeywordScore,
                RequiresSSL = userPreference.RequiresSSL,
                SMTPPassword = userPreference.SMTPPassword,
                SMTPPort = userPreference.SMTPPort,
                SMTPServer = userPreference.SMTPServer,
                SMTPUsername = userPreference.SMTPUser,
                UserId = userPreference.UserId
            };
            return result;



        }
        public static UserPreferenceSelection GetUserPreferenceSelectionByUserId(this MarketingEntities context, Guid userId)
        {

            var result = context.UserPreferences.SingleOrDefault(x => x.UserId == userId);
            if (result == null)
            {
                result = new UserPreference();
                var emailAddress = context.aspnet_Membership.Single(x => x.UserId == userId);
                result.Id = Guid.NewGuid();
                result.UserId = userId;
                result.MinimumKeywordScore = 0;
                result.LiveMode = false;
                result.BCCEmailAddress = !String.IsNullOrEmpty(emailAddress.Email) ? emailAddress.Email : "youremailaddress@donotresolve.com";
                context.UserPreferences.AddObject(result);
                context.SaveChanges();
            }
            return result.ToUserPreferenceSelection();
        }
        public static UserListingItem GetUserListingItemById(this MarketingEntities context, Guid id)
        {
            var result = context.UserListingDatas.Single(n => n.UserListingUrlId == id).ToUserListingItem();
            return result;
        }
        public static UserListingItem ToUserListingItem(this UserListingData userListingData)
        {
            var result = new UserListingItem
            {
                Id = userListingData.UserListingUrlId,
                CategoryName = userListingData.ListingCategoryName,
                CityName = userListingData.CityName,
                StateProvince = userListingData.StateProvince,
                GroupName = userListingData.ListingGroupName,
                RegionName = userListingData.RegionName,
                PostElement = userListingData.PostElement,
                Created = userListingData.ListingUrlCreated,
                Title = userListingData.Title,
                UserId = userListingData.UserId,
                Responded = userListingData.Responded,
                ResponseId = userListingData.UserListingResponseId,
                Response = userListingData.Response,
                ResponseSent = userListingData.ResponseSent,
                ResponseText = userListingData.ResponseText,
                PostHtml = userListingData.PostContent,
                CityActive = userListingData.CityActive,
                UserCityActive = userListingData.UserCityActive,
                ListingCategoryActive = userListingData.ListingCategoryActive,
                PostDate = userListingData.PostDate,
                PostText = userListingData.PostContent,
                IsHidden = userListingData.IsHidden,
                UserFileId = userListingData.UserFileId
            };
            return result;
        }
        public static void SetDefaultUserTemplateItem(this MarketingEntities context, UserListingItem userListingItem)
        {
            var template = context.UserTemplates.Single(n => n.UserId == userListingItem.UserId && n.IsDefault);
            userListingItem.Response = XElement.Parse(template.TemplateHtml).ToString();
            userListingItem.ResponseText = template.TemplateText;
        }
        static UserFilter InsertDefaultUserFilterListItem(this MarketingEntities context, Guid userId)
        {
            var result = new UserFilter
            {
                Id = Guid.NewGuid(),
                UserId = userId
            };
            context.UserFilters.AddObject(result);
            context.SaveChanges();
            return result;
        }
        public static UserPostListFilterItem GetUserPostListFilterItemByUserId(this MarketingEntities context, Guid userId)
        {
            UserPostListFilterItem result = null;
            var item = context.UserFilters.SingleOrDefault(n => n.UserId == userId);
            if (item == null)
                item = context.InsertDefaultUserFilterListItem(userId);
            result = new UserPostListFilterItem
            {
                Id = item.Id,
                FilteredCities = item.FilteredCities,
                FilteredCountries = item.FilteredCountries,
                FilteredStates = item.FilteredStates,
                FilteredKeywords = item.FilteredKeywords,
                FiltersEnabled = item.FiltersEnabled,
                PostEndDate = item.PostEnd,
                PostStartDate = item.PostStart,
                ResponseEndDate = item.ResponseEnd,
                ResponseStartDate = item.ResponseStart,
                ShowNotResponded = item.ShowNotResponded,
                ShowResponded = item.ShowResponded,
                UserId = item.UserId
            };
            return result;
        }
        public static void UpdateUserPostListFilterItem(this MarketingEntities context, UserPostListFilterItem item)
        {
            var existing = context.UserFilters.SingleOrDefault(n => n.UserId == item.UserId);
            if (existing == null)
            {
                existing = new UserFilter { Id = item.Id, UserId = item.UserId };
                context.UserFilters.AddObject(existing);
            }
            existing.FilteredCities = item.FilteredCities;
            existing.FilteredCountries = item.FilteredCountries;
            existing.FilteredStates = item.FilteredStates;
            existing.FilteredKeywords = item.FilteredKeywords;
            existing.FiltersEnabled = item.FiltersEnabled;
            existing.PostEnd = item.PostEndDate;
            existing.PostStart = item.PostStartDate;
            existing.ResponseEnd = item.ResponseEndDate;
            existing.ResponseStart = item.ResponseStartDate;
            existing.ShowNotResponded = item.ShowNotResponded;
            existing.ShowResponded = item.ShowResponded;

            context.SaveChanges();

        }
        public static IQueryable<BugReportItem> GetDefaultBugReports(this MarketingEntities context)
        {
            var result = context.BugReports.Select(n => new BugReportItem
             {
                 Id = n.Id,
                 Description = n.Description,
                 Reported = n.Reported,
                 ReproductionSteps = n.ReproductionSteps,
                 Resolution = n.Resolution,
                 Resolved = n.Resolved
             });
            return result;
        }
        public static void InsertBugReportItem(this MarketingEntities context, BugReportItem item)
        {
            var bugReport = new BugReport
            {
                Id = item.Id,
                Description = item.Description,
                ReproductionSteps = item.ReproductionSteps,
                Reported = System.DateTime.Now
            };
            context.BugReports.AddObject(bugReport);
            context.SaveChanges();
        }
        public static void UpdateBugReportItem(this MarketingEntities context, BugReportItem item)
        {
            var bugReport = context.BugReports.Single(n => n.Id == item.Id);

            bugReport.Description = item.Description;
            bugReport.ReproductionSteps = item.ReproductionSteps;
            bugReport.Reported = System.DateTime.Now;
            bugReport.Resolution = item.Resolution;
            bugReport.Resolved = item.Resolved;
            context.SaveChanges();

        }
        public static String NormalizeHtml(this string content)
        {
            var result = content;
            result = System.Text.RegularExpressions.Regex.Replace(result, "<!DOCTYPE html .*>", "");
            var converter = new Marketing.Utils.HtmlToXml.HtmlToXmlConverter();
            var element = converter.ConvertToXml(result);
            //handle title
            var head = element.Descendants("head").First();
            var title = element.Descendants("title").FirstOrDefault();

            if (title == null)
            {
                head.Add(new XElement("title", "Untitled Document"));
            }
            else if (String.IsNullOrEmpty(title.Value))
                title.Value = "Untitled Document";

            return element.ToString();
        }
        public static void DeleteBugReportItem(this MarketingEntities context, BugReportItem bugReportItem)
        {
            var item = context.BugReports.Single(n => n.Id == bugReportItem.Id);
            context.BugReports.DeleteObject(item);
            context.SaveChanges();
        }
        public static void InsertError(string className, string methodName, string message)
        {
            try
            {
                var logEntry = new LogEntry
                {
                    ActivityId = Guid.NewGuid(),
                    AppDomainName = "Marketing.CraigslistScraper",
                    Categories = new List<string> { "All", "Application" },
                    EventId = 9000,
                    Priority = 1,
                    Severity = System.Diagnostics.TraceEventType.Error,
                    TimeStamp = System.DateTime.Now
                };
                logEntry.Title = className;
                logEntry.AddErrorMessage(String.Format("Class Name:{0};Method Name:{1};Application Error Message:{2}", className, methodName, message));
                Logger.Write(logEntry);
            }
            catch
            {
                //swallow, loggers should not throw exceptions in this instance
            }
        }
        public static void InsertError(this Error error)
        {
            try
            {
                var logEntry = new LogEntry
                {
                    ActivityId = error.Id,
                    AppDomainName = "Marketing.CraigslistScraper",
                    Categories = new List<string> { "All", "Application" },
                    EventId = 9000,
                    Priority = 1,
                    Severity = System.Diagnostics.TraceEventType.Error,
                    TimeStamp = System.DateTime.Now
                };
                logEntry.Title = error.OriginatingClassName;
                logEntry.AddErrorMessage(String.Format("Class Name:{0};Method Name:{1};Application Error Message:{2};Error Data:{3};Exception Type Name:{4};Exception Message:{5}", error.OriginatingClassName, error.MethodName, error.ErrorMessage, error.ErrorData, error.ExceptionTypeName, error.ExceptionMessage));
                Logger.Write(logEntry);
            }
            catch
            {
                //swallow, loggers should not throw exceptions in this instance
            }
        }
        public static void InsertUserFile(this MarketingEntities context, UserFile userFile)
        {
            if (context.UserFiles.Where(n => n.Filename.ToLower() == userFile.Filename.ToLower() && n.UserId == userFile.UserId).Count() > 0)
                throw new System.ArgumentException(String.Format("A file named {0} already exists. Filenames must be unique", userFile.Filename));
            var item = new Marketing.Data.UserFile
            {
                Filename = userFile.Filename,
                ByteCount = userFile.ByteCount,
                Created = userFile.Created,
                Id = userFile.Id,
                Extension = userFile.Extension,
                UserId = userFile.UserId,
                RawFile = userFile.RawFile

            };
            context.UserFiles.AddObject(item);
            context.SaveChanges();
        }
        public static IQueryable<UserFile> GetDefaultUserFiles(this MarketingEntities context)
        {
            var result = context.UserFiles.Where(n => n.Deleted.HasValue == false).Select(n => new UserFile
                {
                    Id = n.Id,
                    ByteCount = n.ByteCount,
                    Created = n.Created,
                    Filename = n.Filename,
                    Extension = n.Extension,
                    UserId = n.UserId
                });
            return result;
        }
        public static IQueryable<SystemSettingItem> DefaultGetSystemSettingItems(this MarketingEntities context)
        {
            var result = context.SystemSettings.Select(n => new SystemSettingItem
                {
                    Id = n.Id,
                    SettingName = n.SettingName,
                    SettingValue = n.SettingValue
                });
            return result;
        }
        public static void DeleteUserFile(this MarketingEntities context,UserFile userFile)
        {

            var item = context.UserFiles.Single(n => n.Id == userFile.Id);
            item.Deleted = System.DateTime.Now;
            context.SaveChanges();
        }
    }
}
