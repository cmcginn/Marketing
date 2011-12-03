using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Activities;
using System.Xml.Linq;
using System.Workflow.Activities;
using System.Workflow.Runtime;
using LeadScraper.WorkflowActivities;

namespace LeadScraper.Tests {
  [TestClass]
  public class HostRunner {
    [TestMethod]
    public void Run() {
      var wf = new WorkflowInvoker( new Host() );
      var result = wf.Invoke();
    }
  }
}
