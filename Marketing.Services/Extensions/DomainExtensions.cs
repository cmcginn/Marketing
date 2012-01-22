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
namespace Marketing.Services.Extensions {
  public static class DomainExtensions {
    public static IQueryable<User> GetUsers( this MarketingEntities context ) {
      var result = context.vw_aspnet_MembershipUsers.Select( n => new User { Id = n.UserId, Username = n.UserName } );
      return result.AsQueryable();
    }
    public static IQueryable<UserListingCategorySelection> GetUserListingCategorySelectionByUserId( this MarketingEntities context,Guid userId ) {
      var query = from category in context.ListingCategories
                  join categoryGroup in context.ListingGroups
                  on category.ListingGroupId equals categoryGroup.Id
                  join userCategory in context.UserListingCategories.Where(n=>n.UserId==userId)
                  on category.Id equals userCategory.ListingCategoryId into ulc

                  from item in ulc.DefaultIfEmpty()
                  select new UserListingCategorySelection { Id = item != null ? item.Id : Guid.NewGuid(), Active = item != null ? item.Active : true, CategoryName = category.ListingCategoryName, GroupName = categoryGroup.ListingGroupName, Selected = item != null ? true : false, UserId = item.UserId != Guid.Empty ? item.UserId : userId, CategoryId = category.Id };
      return query.AsQueryable();
    }
    public static IQueryable<UserCitySelection> GetUserCitySelections( this MarketingEntities context) {
      var query = from city in context.Cities
                  join uc in context.UserCities
                  on city.Id equals uc.CityId into usc
                  from item in usc.DefaultIfEmpty()
                  select new UserCitySelection { Id = item != null ? item.Id : Guid.Empty, Active = item.Active != null ? item.Active : true, CityId = city.Id, CityName = city.CityName, StateProvince = city.StateProvince, RegionName = city.RegionName, UserId = item.UserId != Guid.Empty ? item.UserId : Guid.Empty, Selected = item != null };

      return query.AsQueryable();
    }
    public static IQueryable<UserCitySelection> GetUserCitySelectionByUserId( this MarketingEntities context, Guid userId ) {
      var query = from city in context.Cities
                  join uc in context.UserCities.Where( x => x.UserId == userId )
                  on city.Id equals uc.CityId into usc
                  from item in usc.DefaultIfEmpty()
                  select new UserCitySelection { Id = item != null ? item.Id : Guid.Empty, Active = item.Active != null ? item.Active : true, CityId = city.Id, CityName = city.CityName, StateProvince = city.StateProvince, RegionName = city.RegionName, UserId = item.UserId != Guid.Empty ? item.UserId : userId, Selected = item != null };

      return query.AsQueryable();
    }
    public static IQueryable<UserKeywordSelection> GetUserKeywordSelections( this MarketingEntities context) {
      var query = from userKeyword in context.UserKeywords
                  select new UserKeywordSelection { Id = userKeyword.Id, Keyword = userKeyword.Keyword, UserId = userKeyword.UserId, WeightedScore = userKeyword.WeightedScore };
      return query;
    }
    public static IQueryable<UserKeywordSelection> GetUserKeywordSelectionByUserId( this MarketingEntities context,Guid userId ) {
      var query = from userKeyword in context.UserKeywords.Where(x=>x.UserId==userId)
                  select new UserKeywordSelection { Id = userKeyword.Id, Keyword = userKeyword.Keyword, UserId = userKeyword.UserId, WeightedScore = userKeyword.WeightedScore };
      return query;
    }
    public static IQueryable<UserPreferenceSelection> GetUserPreferenceSelection( this MarketingEntities context ) {
      var query = from userPreference in context.UserPreferences
                  select new UserPreferenceSelection { Id = userPreference.Id, UserId = userPreference.UserId, LiveMode = userPreference.LiveMode, BCCEmailAddress = userPreference.BCCEmailAddress, SMTPUsername = userPreference.SMTPUser, SMTPServer = userPreference.SMTPServer, SMTPPort = userPreference.SMTPPort, RequiresSSL = userPreference.RequiresSSL, SMTPPassword = userPreference.SMTPPassword };
      return query;
    }
    public static IQueryable<UserListingItem> GetUserListingItems( this MarketingEntities context) {
      var query = from userListingData in context.UserListingDatas.Where( x => x.PostContent != null &! String.IsNullOrEmpty(x.ReplyTo))
                  select new UserListingItem {
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
                    ListingCategoryActive = userListingData.ListingCategoryActive
                  };
      return query;
    }
    public static IQueryable<UserListingItem> GetUserListingItemsByUserId( this MarketingEntities context,Guid userId ) {
      var query = from userListingData in context.UserListingDatas.Where( x => x.PostContent != null & !String.IsNullOrEmpty( x.ReplyTo ) && x.UserId == userId )
                  select new UserListingItem {
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
                    ListingCategoryActive = userListingData.ListingCategoryActive
                  };
      return query;
    }
    public static IQueryable<UserListingResponseItem> GetUserListingResponses( this MarketingEntities context ) {
      var query = from userListingResponse in context.UserListingResponses
                  select new UserListingResponseItem {
                    Id = userListingResponse.Id,
                    Created = userListingResponse.Created,
                    UserId = userListingResponse.UserListingUrl.UserId,
                    UserListingUrlId = userListingResponse.UserListingUrlId,
                    Response = userListingResponse.Response
                  };
      return query;
    }
    public static UserListingResponse SaveUserListingResponse( this MarketingEntities context, UserListingItem item ) {
      UserListingResponse result = null;
      var responseElement = System.Text.RegularExpressions.Regex.Replace( item.Response, "<!DOCTYPE html .*>", "" );
      var converter = new Marketing.Utils.HtmlToXml.HtmlToXmlConverter();
      responseElement = converter.ConvertToXml( responseElement ).ToString();
      result = context.UserListingResponses.SingleOrDefault( x => x.UserListingUrlId == item.Id );
      if( result == null ) {
        result = new UserListingResponse {
          Created = System.DateTime.Now,
          Id = Guid.NewGuid(),
          UserListingUrlId = item.Id
        };
        context.UserListingResponses.AddObject( result );
      }
      result.Response = responseElement;
      result.ResponseText = item.ResponseText;
      context.SaveChanges();
      return result;
    }
    public static void SaveUserPreferencesSelection( this MarketingEntities context, UserPreferenceSelection item ) {

      var result = context.UserPreferences.Single( x => x.Id == item.Id );
      result.LiveMode = item.LiveMode;
      result.BCCEmailAddress = item.BCCEmailAddress;
      result.SMTPPassword = item.SMTPPassword;
      result.RequiresSSL = item.RequiresSSL;
      result.SMTPPort = item.SMTPPort;
      result.SMTPServer = item.SMTPServer;
      result.SMTPUser = item.SMTPUsername;
      context.SaveChanges();
    }
    public static IQueryable<Operation> GetDefaultServerOperations() {
      List<Operation> result = new List<Operation>{
        new Operation{Id=1, OperationName="Refresh Posts",Parameters="UserId=;"}        
      };
      return result.AsQueryable();
    }
    public static System.Net.Mail.MailMessage GetMailMessage( this UserListingResponse item ) {
      var userPreference = item.UserListingUrl.aspnet_Membership.UserPreferences.Single( x => x.UserId == item.UserListingUrl.UserId );
      System.Net.Mail.MailMessage result = null;
      var uri = new Uri( item.UserListingUrl.ListingUrl.ListingContents.First().ReplyTo );
      var nvc = System.Web.HttpUtility.ParseQueryString( uri.Query );
      var address = String.Format( "{0}@{1}", uri.UserInfo, uri.DnsSafeHost );
      var subject = nvc[ 0 ];
      var body = item.Response.ToString();
      //if( nvc.Count > 1 )
      //  body = String.Format( "{0}{1}{2}", body, System.Environment.NewLine, nvc[ 1 ] ); 
      
      var fromAddress = item.UserListingUrl.aspnet_Membership.UserPreferences.First().BCCEmailAddress;
      //if not live use BCC email, dont send to recipient
      
      if( !userPreference.LiveMode)
       address = fromAddress;
      result = new MailMessage( fromAddress, address, subject, body );
      result.IsBodyHtml = true;
      result.Bcc.Add( fromAddress );
      result.AlternateViews.Add( System.Net.Mail.AlternateView.CreateAlternateViewFromString( item.Response, null, "text/html" ) );
      result.AlternateViews.Add( System.Net.Mail.AlternateView.CreateAlternateViewFromString( item.ResponseText, null, "text/plain" ) );
      return result;
    }
    public static bool SendUserListingResponse( this MarketingEntities context, UserListingResponse response ) {
      bool result = false;
      var mailMessage = response.GetMailMessage();
      var userPreferences = response.UserListingUrl.aspnet_Membership.UserPreferences.First();
      var client = new System.Net.Mail.SmtpClient( userPreferences.SMTPServer, userPreferences.SMTPPort );
      client.Credentials = new System.Net.NetworkCredential( userPreferences.SMTPUser, userPreferences.SMTPPassword );
      client.EnableSsl = userPreferences.RequiresSSL;
      client.Send( mailMessage );
      result = true;
      response.ResponseSent = System.DateTime.Now;
      context.SaveChanges();
      return result;
    }
    public static UserPreference GetUserPreferenceSelectionByUserId( this MarketingEntities context, Guid userId ) {

      var result = context.UserPreferences.SingleOrDefault( x => x.UserId == userId );
      if( result == null ) {
        result = new UserPreference();
        var emailAddress = context.aspnet_Membership.Single( x => x.UserId == userId );
        result.Id = Guid.NewGuid();
        result.UserId = userId;
        result.LiveMode = false;
        result.BCCEmailAddress = !String.IsNullOrEmpty( emailAddress.Email ) ? emailAddress.Email : "youremailaddress@donotresolve.com";
        context.UserPreferences.AddObject( result );
        context.SaveChanges();
      }
      return result;
    }
    static UserListingItem ToUserListingItem(this UserListingData userListingData ) {
      var result = new UserListingItem {
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
        ListingCategoryActive = userListingData.ListingCategoryActive
      };
      return result;
    }
  }
}
