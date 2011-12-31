using Marketing.Data;
using Marketing.Services.Extensions;
namespace Marketing.Services {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.ComponentModel.DataAnnotations;
  using System.Linq;
  using System.ServiceModel.DomainServices.Hosting;
  using System.ServiceModel.DomainServices.Server;
  using System.Workflow.Activities;
  using System.Activities;
  using System.Workflow.Runtime;
  using System.Threading.Tasks;

  // TODO: Create methods containing your application logic.

  public class MarketingDomainService : DomainService {
    MarketingEntities _Context;
    [Query(IsDefault=true)]
    public IQueryable<UserCitySelection> DefaultUserCitySelections() {
      return Context.GetUserCitySelectionFromContext();
    }
    [Query( IsDefault = true )]
    public IQueryable<UserListingCategorySelection> DefualtUserListingSelection() {

      var result = Context.GetUserListingCategorySelectionFromContext();    
      return result;
    }
    [Query( IsDefault = true )]
    public IQueryable<UserKeywordSelection> DefaultUserKeywords() {
      var result = Context.GetUserKeywordSelectionFromContext();
      return result;
    }
    [Query( IsDefault = true )]
    public IQueryable<UserPreferenceSelection> DefaultUserPreferenceSelections() {
      var result = Context.GetUserPreferenceSelection();
      return result;
    }
    [Query( IsDefault = true )]
    public IQueryable<UserListingItem> DefaultUserListingItems() {
      var result = Context.GetUserListingItems();
      return result;
    }
    public UserListingItem GetUserListingItemById( Guid? id ) {
      var result = Context.GetUserListingItems().Single( x => x.Id == id );
      return result;
    }
    public UserPreferenceSelection GetUserPreferenceSelectionByUserId( Guid? userId ) {
      var key = userId.GetValueOrDefault();
      var item = Context.UserPreferences.SingleOrDefault( x => x.UserId == key );
      if( item == null ) {
        item = new UserPreference();
        var emailAddress = Context.aspnet_Membership.Single( x => x.UserId == key );
        item.Id = Guid.NewGuid();
        item.UserId = userId.GetValueOrDefault();
        item.LiveMode = false;
        item.BCCEmailAddress = !String.IsNullOrEmpty(emailAddress.Email)  ? emailAddress.Email : "youremailaddress@donotresolve.com";
        Context.UserPreferences.AddObject( item );
        Context.SaveChanges();

      }
      var result = DefaultUserPreferenceSelections().Single( x => x.Id == item.Id );
      return result;
    }
    public void UpdateUserPreferenceSelection( UserPreferenceSelection userPreferenceSelection ) {
      var result = Context.UserPreferences.Single( x => x.Id == userPreferenceSelection.Id );
      result.LiveMode = userPreferenceSelection.LiveMode;
      result.BCCEmailAddress = userPreferenceSelection.BCCEmailAddress;
      Context.SaveChanges();
    }
    public void AddUserKeyword( UserKeywordSelection userKeywordSelection ) {
      var item = new UserKeyword { Id = userKeywordSelection.Id, WeightedScore = userKeywordSelection.WeightedScore, UserId = userKeywordSelection.UserId, Keyword = userKeywordSelection.Keyword };
      Context.UserKeywords.AddObject(item);
      Context.SaveChanges();
    }
    public void UpdateUserKeyword( UserKeywordSelection userKeywordSelection ) {
      var current = Context.UserKeywords.Single( x => x.Id == userKeywordSelection.Id );
      current.Keyword = userKeywordSelection.Keyword;
      current.WeightedScore = userKeywordSelection.WeightedScore;
      Context.SaveChanges();
    }
    public void DeleteUserKeyword(UserKeywordSelection userKeywordSelection)
    {
      var item = Context.UserKeywords.Single( x => x.Id == userKeywordSelection.Id );
      Context.DeleteObject( item );
      Context.SaveChanges();
    }
    public void UpdateUserListingCategorySelection( UserListingCategorySelection userListingCategorySelection ) {
      var target = Context.UserListingCategories.SingleOrDefault( x => x.UserId == userListingCategorySelection.UserId && x.ListingCategoryId == userListingCategorySelection.CategoryId );
      if( target == null && userListingCategorySelection.Selected ) {
        var item = new UserListingCategory { Id = userListingCategorySelection.Id, ListingCategoryId = userListingCategorySelection.CategoryId, UserId = userListingCategorySelection.UserId, Active = true };
        Context.UserListingCategories.AddObject(item);
      } else if( !userListingCategorySelection.Selected ) {
        Context.UserListingCategories.DeleteObject( target );
      }
      Context.SaveChanges();
    }
    public void UpdateUserCitySelection( UserCitySelection userCitySelection ) {
      var target = Context.UserCities.SingleOrDefault( x => x.UserId == userCitySelection.UserId && x.CityId == userCitySelection.CityId );
      if( target == null && userCitySelection.Selected ) {
        var item = new UserCity { CityId = userCitySelection.CityId, UserId = userCitySelection.UserId, Id = Guid.NewGuid() };
        Context.UserCities.AddObject(item);
      }else if(!userCitySelection.Selected){
        Context.UserCities.DeleteObject(target);
      }
      Context.SaveChanges();
    }
    protected override int Count<T>( IQueryable<T> query ) {
      return query.Count();
    }
    private MarketingEntities Context {
      get {
        if( _Context == null )
          _Context = new MarketingEntities();
        return _Context;
      }
    }
    
  }
}


