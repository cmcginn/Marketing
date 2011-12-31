using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
using System.Collections.Specialized;
using System.Xml.Linq;
namespace Marketing.Services.Extensions {
  public static class DomainExtensions {

    public static IQueryable<UserListingCategorySelection> GetUserListingCategorySelectionFromContext( this MarketingEntities context ) {
      var query = from category in context.ListingCategories
                  join categoryGroup in context.ListingGroups
                  on category.ListingGroupId equals categoryGroup.Id
                  join userCategory in context.UserListingCategories
                  on category.Id equals userCategory.ListingCategoryId into ulc
                  
                  from item in ulc.DefaultIfEmpty()
                  select new UserListingCategorySelection { Id = item != null ? item.Id : Guid.NewGuid(), Active = item != null ? item.Active : true, CategoryName = category.ListingCategoryName, GroupName = categoryGroup.ListingGroupName, Selected = item != null ? true : false,UserId= item.UserId != Guid.Empty ? item.UserId : Guid.Empty,  CategoryId=category.Id };
      return query.AsQueryable();
    }
    public static IQueryable<UserCitySelection> GetUserCitySelectionFromContext( this MarketingEntities context ) {
      var query = from city in context.Cities
                  join uc in context.UserCities
                  on city.Id equals uc.CityId into usc
                  from item in usc.DefaultIfEmpty()
                  select new UserCitySelection { Id = item.Id != Guid.Empty ? item.Id : Guid.NewGuid(), Active = item.Active != null ? item.Active : true, CityId = city.Id, CityName = city.CityName, RegionName = city.RegionName, UserId = item.UserId != Guid.Empty ? item.UserId : Guid.Empty, Selected = item != null };

      return query.AsQueryable();
    }
    public static IQueryable<UserKeywordSelection> GetUserKeywordSelectionFromContext( this MarketingEntities context ) {
      var query = from userKeyword in context.UserKeywords
                  select new UserKeywordSelection { Id = userKeyword.Id, Keyword = userKeyword.Keyword, UserId = userKeyword.UserId, WeightedScore = userKeyword.WeightedScore };
      return query;
    }
    public static IQueryable<UserPreferenceSelection> GetUserPreferenceSelection( this MarketingEntities context ) {
      var query = from userPreference in context.UserPreferences
                  select new UserPreferenceSelection { Id = userPreference.Id, UserId = userPreference.UserId, LiveMode = userPreference.LiveMode, BCCEmailAddress = userPreference.BCCEmailAddress };
      return query;
    }
    public static IQueryable<UserListingItem> GetUserListingItems( this MarketingEntities context ) {
      var query = from userListingData in context.UserListingDatas
                  select new UserListingItem {
                    Id = userListingData.UserListingUrlId,
                    CategoryName = userListingData.ListingCategoryName,
                    CityName = userListingData.CityName,
                    GroupName = userListingData.ListingGroupName,
                    RegionName = userListingData.RegionName,
                    PostElement = userListingData.PostElement,
                    Created = userListingData.ListingUrlCreated,
                    Title = userListingData.Title,
                    UserId = userListingData.UserId

                  };
      return query;
    }
  }
}
