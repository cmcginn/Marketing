using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication {
  public partial class MarketingDomainServiceDataService {
    static Guid _UserId;



    partial void GetUserCitySelections_Executed( Guid? userId, IEnumerable<UserCitySelection> result ) {
      UserId = userId.GetValueOrDefault();
    }
    public static Guid UserId {
      get {
        return _UserId;
      }
      set {
        _UserId = value;
      }
    }


    partial void GetUserListingResponseById_Executed( Guid? responseId, IEnumerable<UserListingResponseItem> result ) {
      if( result.Count() == 0 ) {
        result = new List<UserListingResponseItem> { this.DataWorkspace.MarketingDomainServiceData.UserListingResponseItems.AddNew() };
        result.First().Id = Guid.Empty;
      }
    }

    partial void UserCitySelections_All_PreprocessQuery( ref IQueryable<UserCitySelection> query ) {
      query = query.OrderByDescending( n => n.Selected ).ThenBy( n => n.RegionName ).ThenBy( n => n.StateProvince ).ThenBy( n => n.CityName );
    }

    partial void GetUserListingItems_PreprocessQuery(Guid? userId, string filterKeywords, DateTime? filterStartDate, DateTime? filterEndDate, ref IQueryable<UserListingItem> query)
    {
        if (filterStartDate != null)
            query = query.Where(n => n.PostDate >= System.DateTime.Now);
        if (filterEndDate != null)
            query = query.Where(n => n.PostDate <= System.DateTime.Now);
    }

    partial void UserListingItems_All_PreprocessQuery(ref IQueryable<UserListingItem> query)
    {
        query = query.OrderByDescending(n => n.KeywordScore).ThenByDescending(n => n.Responded).ThenBy(n => n.CategoryName).ThenBy(n => n.RegionName).ThenBy(n => n.StateProvince).ThenBy(n => n.CityName);
    }

   
  }
}
