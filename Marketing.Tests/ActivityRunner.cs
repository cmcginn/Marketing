using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Activities;
using System.ComponentModel;
using System.Workflow.Activities;
using System.Workflow.Runtime;
using Marketing.WorkflowActivities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Marketing.Tests {
  /// <summary>
  /// Summary description for ActivityRunner
  /// </summary>
  [TestClass]
  public class ActivityRunner {
    public ActivityRunner() {
      //
      // TODO: Add constructor logic here
      //
    }

    private TestContext testContextInstance;

    /// <summary>
    ///Gets or sets the test context which provides
    ///information about and functionality for the current test run.
    ///</summary>
    public TestContext TestContext {
      get {
        return testContextInstance;
      }
      set {
        testContextInstance = value;
      }
    }

    #region Additional test attributes
    //
    // You can use the following additional attributes as you write your tests:
    //
    // Use ClassInitialize to run code before running the first test in the class
    // [ClassInitialize()]
    // public static void MyClassInitialize(TestContext testContext) { }
    //
    // Use ClassCleanup to run code after all tests in a class have run
    // [ClassCleanup()]
    // public static void MyClassCleanup() { }
    //
    // Use TestInitialize to run code before running each test 
    // [TestInitialize()]
    // public void MyTestInitialize() { }
    //
    // Use TestCleanup to run code after each test has run
    // [TestCleanup()]
    // public void MyTestCleanup() { }
    //
    #endregion

    [TestMethod]
    public void RunActivity() {
      var inputs = new Dictionary<string, object>();
      var userId = new Guid( "D1111E48-27EF-4774-9DEF-40B4A03D1925" );
      inputs.Add( "UserId", userId );
      var host = new WorkflowInvoker( new RefreshUserDataActivity());
      host.Invoke( inputs );
     
    }
  }
}
