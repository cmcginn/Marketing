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
    #region Default Queries
    [Query(IsDefault = true)]
    public IQueryable<User> DefaultUsers()
    {
        var result = Context.GetUsers();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<UserCitySelection> DefaultUserCitySelections()
    {
        var result = Context.GetUserCitySelections();
        return result;
    }

    [Query(IsDefault = true)]
    public IQueryable<UserListingCategorySelection> DefaultUserListingCategorySelection()
    {
        return new List<UserListingCategorySelection>().AsQueryable();
    }
    public IQueryable<UserListingCategorySelection> GetUserListingCategorySelectionByUserId(Guid? userId)
    {

        var result = Context.GetUserListingCategorySelectionByUserId(userId.GetValueOrDefault());
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<UserKeywordSelection> DefaultUserKeywords()
    {
        var result = Context.GetUserKeywordSelections();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<UserPreferenceSelection> DefaultUserPreferenceSelections()
    {
        var result = Context.GetUserPreferenceSelection();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<UserListingItem> DefaultUserListingItems()
    {
        var result = Context.GetUserListingItems();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<UserListingResponseItem> DefaultUserListingResponseItems()
    {
        var result = Context.GetUserListingResponses();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<Operation> DefaultServerOperations()
    {
        return DomainExtensions.GetDefaultServerOperations();
    }
    [Query(IsDefault = true)]
    public IQueryable<UserTemplateItem> DefaultUserTemplates()
    {
        var result = Context.GetUserTemplates();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<UserPostListFilterItem> GetDefaultUserPostListFilterItems()
    {
        return new List<UserPostListFilterItem>().AsQueryable();
    }
    [Query(IsDefault = true)]
    public IQueryable<BugReportItem> DefaultBugReportItems()
    {
        var result = Context.GetDefaultBugReports();
        return result;
    }
    [Query(IsDefault = true)]
    public IQueryable<Error> DefaultErrors()
    {
        return new List<Error>().AsQueryable();
    }
    [Query(IsDefault = true)]
    public IQueryable<ErrorDisplay> GetDefaultErrorDisplays()
    {
        var result = Context.GetDefaultErrorDisplays();
        return result;
    }
    #endregion


    #region QueryBy Ids
    public UserPreferenceSelection GetUserPreferenceSelectionByUserId(Guid? userId)
    {
        var id = userId.GetValueOrDefault();
        var result = Context.GetUserPreferenceSelectionByUserId(id);
        return result;
    }
    public IQueryable<UserKeywordSelection> GetUserKeywordSelectionByUserId(Guid? userId)
    {
        var result = Context.GetUserKeywordSelectionByUserId(userId.GetValueOrDefault());
        return result;
    }
    public IQueryable<UserCitySelection> GetUserCitySelectionByUserId(Guid? userId)
    {
        var result = Context.GetUserCitySelectionByUserId(userId.GetValueOrDefault());
        return result;
    }
    public UserPostListFilterItem GetUserPostListItemByUserId(Guid? userId)
    {
        UserPostListFilterItem result = null;
        Guid key = userId.GetValueOrDefault();
        if (key == Guid.Empty)
        {
            result = new UserPostListFilterItem { Id = Guid.NewGuid(), UserId = Guid.Empty, ShowNotResponded=true, ShowResponded=true, FiltersEnabled=true };
        }
        else
        {
            result = Context.GetUserPostListFilterItemByUserId(key);
        }       
        return result;
    }
    public IQueryable<UserTemplateItem> GetUserTemplateItemById(Guid? id)
    {
        var result = Context.GetUserTemplates().Where(n => n.Id == id);
        return result;
    }
    public IQueryable<UserListingItem> GetFilteredUserListingItems(Guid? userId, bool? filtersEnabled, bool? showResponded, bool? showNotResponded, DateTime? postStartDate, DateTime? postEndDate, DateTime? responseStartDate, DateTime? responseEndDate, string keywords,string regionsFilter,string statesFilter,string citiesFilter)
    {
        
        var result = Context.GetUserFilteredUserListingItems(userId, filtersEnabled, showResponded, showNotResponded, postStartDate, postEndDate, responseStartDate, responseEndDate, keywords, regionsFilter, statesFilter, citiesFilter);
        return result;
    }
    #endregion


    #region CRUD
    public void AddUserTemplateItem(UserTemplateItem userTemplateItem)
    {
        Context.AddUserTemplateItem(userTemplateItem);
    }
    public void UpdateServerOperation(Operation operation)
    {
        switch (operation.Id)
        {
            case 1:
                RunPostingRefresh(operation);
                break;
            case 2:
                RunKeywordRefresh(operation);
                break;
            case 3:
                RunPurgeOperation(operation);
                break;
            default: break;
        }
    }
    public void AddUserListingItem(UserListingItem item)
    {
        Context.SaveUserListingResponse(item);

    }    
    public void UpdateUserListingItem(UserListingItem item)
    {
        if (item.IsHidden)
            Context.UpdateUserListingItemVisibility(item);
        else
        {
            if (item.UseDefaultResponse)
                Context.SetDefaultUserTemplateItem(item);

            
            Task t = new Task(() =>
            {
                var ctx = new MarketingEntities();
                var response = ctx.SaveUserListingResponse(item);
                ctx.SendUserListingResponse(response);
            });
            t.Start();

            
        }
    }
    public void UpdateUserPreferenceSelection(UserPreferenceSelection userPreferenceSelection)
    {
        Context.SaveUserPreferencesSelection(userPreferenceSelection);
    }
    public void AddUserKeyword(UserKeywordSelection userKeywordSelection)
    {
        var item = new UserKeyword { Id = userKeywordSelection.Id, WeightedScore = userKeywordSelection.WeightedScore, UserId = userKeywordSelection.UserId, Keyword = userKeywordSelection.Keyword };
        Context.UserKeywords.AddObject(item);
        Context.SaveChanges();
    }
    public void UpdateUserKeyword(UserKeywordSelection userKeywordSelection)
    {
        var current = Context.UserKeywords.Single(x => x.Id == userKeywordSelection.Id);
        current.Keyword = userKeywordSelection.Keyword;
        current.WeightedScore = userKeywordSelection.WeightedScore;
        Context.SaveChanges();
    }
    public void DeleteUserKeyword(UserKeywordSelection userKeywordSelection)
    {
        var item = Context.UserKeywords.Single(x => x.Id == userKeywordSelection.Id);
        Context.DeleteObject(item);
        Context.SaveChanges();
    }
    public void UpdateUserListingCategorySelection(UserListingCategorySelection userListingCategorySelection)
    {
        var target = Context.UserListingCategories.SingleOrDefault(x => x.UserId == userListingCategorySelection.UserId && x.ListingCategoryId == userListingCategorySelection.CategoryId);
        if (target == null && userListingCategorySelection.Selected)
        {
            var item = new UserListingCategory { Id = userListingCategorySelection.Id, ListingCategoryId = userListingCategorySelection.CategoryId, UserId = userListingCategorySelection.UserId, Active = userListingCategorySelection.Selected };
            Context.UserListingCategories.AddObject(item);
        }
        else if (!userListingCategorySelection.Selected)
        {
            Context.UserListingCategories.DeleteObject(target);
        }
        Context.SaveChanges();
    }
    public void UpdateUserCitySelection(UserCitySelection userCitySelection)
    {
        var target = Context.UserCities.SingleOrDefault(x => x.UserId == userCitySelection.UserId && x.CityId == userCitySelection.CityId);
        if (target == null && userCitySelection.Selected.GetValueOrDefault())
        {
            var item = new UserCity { CityId = userCitySelection.CityId, UserId = userCitySelection.UserId, Id = Guid.NewGuid(), Active = userCitySelection.Selected.GetValueOrDefault() };
            Context.UserCities.AddObject(item);
        }
        else if (!userCitySelection.Selected.GetValueOrDefault())
        {
            Context.UserCities.DeleteObject(target);
        }
        Context.SaveChanges();
    }
    public void DeleteUserTemplateItem(UserTemplateItem userTemplateItem)
    {
        Context.DeleteUserTemplateItem(userTemplateItem);
    }
    public void UpdateUserTemplateItem(UserTemplateItem userTemplateItem)
    {
        Context.UpdateUserTemplateItem(userTemplateItem);
    }
    public void UpdateUserPostListFilterItem(UserPostListFilterItem item)
    {
        Context.UpdateUserPostListFilterItem(item);
    }
    public void AddBugReportItem(BugReportItem item)
    {
        Context.InsertBugReportItem(item);
    }
    public void UpdateBugReportItem(BugReportItem item)
    {
        Context.UpdateBugReportItem(item);
    }
    public void AddError(Error item)
    {
        item.InsertError();
    }
    public UserListingItem GetUserListingItemById(Guid? id)
    {
        var userListingUrlId = id.GetValueOrDefault();
        var result = Context.GetUserListingItemById(userListingUrlId);
        return result;
    }
    public void DeleteBugReportItem(BugReportItem item)
    {
        Context.DeleteBugReportItem(item);
    }
       
    #endregion


    #region Actions
    public void RunPurgeOperation(Operation operation)
    {
        //call host eventually
        var invoker = new WorkflowInvoker(new PurgePostsActivity());
        Task t = new Task(() =>
        {
            invoker.Invoke();
        });
        t.Start();
    }
    public void RunKeywordRefresh(Operation operation)
    {
        //call host eventually
        var invoker = new WorkflowInvoker(new RefreshUserKeywordScoresActivity());
        Task t = new Task(() =>
        {
            Dictionary<string, object> inputs = new Dictionary<string, object> { { "UserId", operation.UserId } };
            invoker.Invoke(inputs);
        });
        t.Start();
    }
    private void RunPostingRefresh(Operation operation)
    {
        //call host eventually
        var invoker = new WorkflowInvoker(new RefreshUserDataActivity());
        Task t = new Task(() =>
        {
            Dictionary<string, object> inputs = new Dictionary<string, object> { { "UserId", operation.UserId } };
            invoker.Invoke(inputs);
        });
        t.Start();
    }
    #endregion
  
    

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


