
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
  using Marketing.Data;
  // TODO: Create methods containing your application logic.
  public class Operation {

    [Key]
    public Guid Id { get; set; }
    public List<Guid> ScheduledOperations{get;set;}
  }
  public class MarketingDomainService : DomainService {
    
    //public ServeeOper
    List<Operation> _Operations = new List<Operation>();

    [Query( IsDefault = true )]
    public IQueryable<Operation> GetOperations() {
      return _Operations.AsQueryable();
    }

    public Operation RunServerOperations() {
      using (var ctx = new MarketingDomainModelContainer())
      {
        //call host eventually
        var invoker = new WorkflowInvoker( new CraigslistLeadCollector() );
         Task t = new Task( () => {
          invoker.Invoke();
          //ctx.ServerOperationHistories.ToList().ForEach(n=>n.Completed=System.DateTime.Now);
          //ctx.SaveChanges();
         } );
         t.Start();
      }

      return new Operation { Id = Guid.NewGuid() };
    }
    //public Operation RunOperation(int? id) {
    //  var result = _Operations.SingleOrDefault( n => n.Id == id.GetValueOrDefault() );
    //  var invoker = new WorkflowInvoker( new CraigslistLeadCollector() );
    //  Task t = new Task( () => {
    //    invoker.Invoke();
    //  } );
    //  t.Start();
    //  return result;
    //}
  }
}


