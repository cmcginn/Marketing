
namespace Marketing.Services {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.ComponentModel.DataAnnotations;
  using System.Linq;
  using System.ServiceModel.DomainServices.Hosting;
  using System.ServiceModel.DomainServices.Server;
  using System.Data.Entity;

  // TODO: Create methods containing your application logic.
  public class Operation {

    [Key]
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public string OperationName { get; set; }
    public List<String> Parameters;
  }
  public class MarketingDomainService : DomainService {
    List<Operation> _Operations = new List<Operation>();
    public MarketingDomainService() {
      _Operations.Add( new Operation {Id=1,OperationName="CraigslistRefresh" } );
    }
    [Query(IsDefault=true)]
    public IQueryable<Operation> GetOperations()
    {
       return _Operations.AsQueryable();
    }
    public Operation RunOperation(int? id) {
      var result = _Operations.SingleOrDefault( n => n.Id == id.GetValueOrDefault() );
      return result;
    }
  }
}


