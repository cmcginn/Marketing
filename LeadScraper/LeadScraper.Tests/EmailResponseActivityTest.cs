using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marketing.Data;
using System.Activities;
using System.Xml.Linq;
using System.Workflow.Activities;
using System.Workflow.Runtime;
using LeadScraper.WorkflowActivities;
namespace LeadScraper.Tests {
  [TestClass]
  public class EmailResponseActivityTest :TestBase{
    MarketingDomainModelContainer _context = new MarketingDomainModelContainer();

    [TestMethod]
    public void RunActivity() {
      AddNewServerOperationHistoryById( new Guid("5366DA10-1189-4F1A-A51D-20659DE37BB4") );
      var invoker = new WorkflowInvoker( new EmailResponsesActivity() );
      var actual = invoker.Invoke( DefaultInputs );

    }
  }
}
