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


