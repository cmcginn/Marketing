using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
namespace Marketing.WorkflowActivities {
  public class DataHelper {
    public static List<UserListingRefresh> GetUrlsForUser( MarketingEntities context, Guid userId ) {
      var result = context.UserListingRefreshes.Where( n => n.UserId == userId ).ToList();
      return result;
    }
    public static ListingUrl GetListingUrl( MarketingEntities context, string url ) {
      var result = context.ListingUrls.SingleOrDefault( n => n.Url == url );
      return result;
    }
    public static UserListingUrl GetUserListingUrl( MarketingEntities context, ListingUrl listingUrl ) {
      var result = context.UserListingUrls.SingleOrDefault( n => n.ListingUrlId == listingUrl.Id );
      return result;
    }
    public static List<ListingUrl> GetListingUrlsForUser(MarketingEntities context,Guid userId)
    {
      var query = from userListing in context.UserListingUrls
                  join listing in context.ListingUrls
                  on userListing.ListingUrlId equals listing.Id
                  join listingContent in context.ListingContents
                  on listing.Id equals listingContent.ListingUrlId into contents
                  from content in contents.DefaultIfEmpty()
                  where content == null
                  select listing;
      return query.ToList();                  
                  
    }
  }
}
