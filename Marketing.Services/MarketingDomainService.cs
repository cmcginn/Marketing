
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
  using LeadScraper.WorkflowActivities;
  using System.Threading.Tasks;
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
      var invoker = new WorkflowInvoker( new CraigslistLeadCollector() );
      Task t = new Task( () => {
        invoker.Invoke();
      } );
      t.Start();
      return result;
    }
  }
}


