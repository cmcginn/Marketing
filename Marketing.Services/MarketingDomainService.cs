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

    [Query]
    public IQueryable<UserCitySelection> GetUserCitySelectionsForUser(Guid? userId) {
      return Context.GetUserCitySelectionFromContext(userId.GetValueOrDefault());
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


