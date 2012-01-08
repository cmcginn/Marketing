using Marketing.Data;
using Marketing.Services.Extensions;
using Marketing.WorkflowActivities;
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
    public IQueryable<UserListingCategorySelection> DefaultUserListingCategorySelection() {
      return new List<UserListingCategorySelection>().AsQueryable();
    }
    public IQueryable<UserListingCategorySelection> GetUserListingCategorySelectionByUserId( Guid? userId ) {

      var result = Context.GetUserListingCategorySelectionByUserId( userId.GetValueOrDefault() );
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
    [Query( IsDefault = true )]   
    public IQueryable<UserListingResponseItem> DefaultUserListingResponseItems() {
      var result = Context.GetUserListingResponses();
      return result;
    }
    [Query( IsDefault = true )]
    public IQueryable<Operation> DefaultServerOperations() {
      return DomainExtensions.GetDefaultServerOperations();
    }
    private void RunPostingRefresh( Operation operation ) {
      //call host eventually
      var invoker = new WorkflowInvoker( new RefreshUserDataActivity() );
      Task t = new Task( () => {
        Dictionary<string, object> inputs = new Dictionary<string, object> {{"UserId",operation.UserId} };
        invoker.Invoke(inputs);
      } );
      t.Start();
    }
    public void UpdateServerOperation( Operation operation ) {
      switch(operation.Id)
      {
        case 1:
          RunPostingRefresh( operation );
          break;
        default: break;
      }
    }
    public void AddUserListingItem( UserListingItem item ) {
      Context.SaveUserListingResponse( item );
            
    }
    public void UpdateUserListingItem( UserListingItem item ) {
      var response = Context.SaveUserListingResponse( item );
      Context.SendUserListingResponse( response );
    }
    public UserListingItem GetUserListingItemById( Guid? id ) {
      var key = id.GetValueOrDefault();
      var result = Context.GetUserListingItems().Single( x => x.Id == key) ;
      return result;
    }
    public UserPreferenceSelection GetUserPreferenceSelectionByUserId( Guid? userId ) {
      Context.GetUserPreferenceSelectionByUserId( userId.GetValueOrDefault() );
      var result = Context.GetUserPreferenceSelection().First();
      return result;
    }
    public void UpdateUserPreferenceSelection( UserPreferenceSelection userPreferenceSelection ) {
      Context.SaveUserPreferencesSelection( userPreferenceSelection );
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
        var item = new UserListingCategory { Id = userListingCategorySelection.Id, ListingCategoryId = userListingCategorySelection.CategoryId, UserId = userListingCategorySelection.UserId, Active = userListingCategorySelection.Selected };
        Context.UserListingCategories.AddObject(item);
      } else if( !userListingCategorySelection.Selected ) {
        Context.UserListingCategories.DeleteObject( target );
      }
      Context.SaveChanges();
    }
    public void UpdateUserCitySelection( UserCitySelection userCitySelection ) {
      var target = Context.UserCities.SingleOrDefault( x => x.UserId == userCitySelection.UserId && x.CityId == userCitySelection.CityId );
      if( target == null && userCitySelection.Selected ) {
        var item = new UserCity { CityId = userCitySelection.CityId, UserId = userCitySelection.UserId, Id = Guid.NewGuid(),Active=userCitySelection.Selected };
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


