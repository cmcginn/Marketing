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



  }
}
