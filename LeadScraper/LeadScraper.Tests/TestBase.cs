using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Activities;
using System.Xml.Linq;
using System.Workflow.Activities;
using System.Workflow.Runtime;
using Marketing.Data;
using LeadScraper.WorkflowActivities;
namespace LeadScraper.Tests {
 [TestClass]
  public class TestBase {
   MarketingDomainModelContainer _MarketingDomainContainer = new MarketingDomainModelContainer();
   Dictionary<string, object> _DefaultInputs;

   public TestBase() {
    _DefaultInputs = new Dictionary<string,object>{ { "MarketingContext", MarketingDomainContainer }, { "ServerOperationHistory", null } };
   }
   
   public ServerOperationHistory AddNewServerOperationHistoryById( Guid id ) {
     var result = new ServerOperationHistory { Id = Guid.NewGuid(), ServerOperationId = id, Scheduled = System.DateTime.Now };

     _DefaultInputs[ "ServerOperationHistory" ] = result;
     return result;
     
   }

   public Dictionary<string, object> DefaultInputs {
     get {
       return _DefaultInputs;
     }
     set {
       _DefaultInputs = value;
     }
   }
   public MarketingDomainModelContainer MarketingDomainContainer {
     get {
       return _MarketingDomainContainer;
     }
     set {
       _MarketingDomainContainer = value;
     }
   }
  }
}
