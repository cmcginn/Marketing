using Marketing.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Xml.Linq;
using Common.Utils.Extensions;
using System.Xml.Xsl;
namespace Marketing.Tests
{
    
    
    /// <summary>
    ///This is a test class for XsltExtensionsTest and is intended
    ///to contain all XsltExtensionsTest Unit Tests
    ///</summary>
  [TestClass()]
  public class XsltExtensionsTest {


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
    //You can use the following additional attributes as you write your tests:
    //
    //Use ClassInitialize to run code before running the first test in the class
    //[ClassInitialize()]
    //public static void MyClassInitialize(TestContext testContext)
    //{
    //}
    //
    //Use ClassCleanup to run code after all tests in a class have run
    //[ClassCleanup()]
    //public static void MyClassCleanup()
    //{
    //}
    //
    //Use TestInitialize to run code before running each test
    //[TestInitialize()]
    //public void MyTestInitialize()
    //{
    //}
    //
    //Use TestCleanup to run code after each test has run
    //[TestCleanup()]
    //public void MyTestCleanup()
    //{
    //}
    //
    #endregion


    /// <summary>
    ///A test for GetCraigslistReplyTo
    ///</summary>
    [TestMethod()]
    public void RunTransformation() {
      var document = XDocument.Parse( TestResources.cl5);
      var xslt = XDocument.Parse( Marketing.Utils.TransformationResources.CraigslistResponse );
      var arguments = new XsltArgumentList();
      arguments.AddExtensionObject( "urn:extensions", new XsltExtensions() );
      var result = document.Transform( arguments, xslt );
      var contact = result.Root.Attribute( "contact" );
      Assert.IsFalse( String.IsNullOrEmpty( contact.Value ) );
    }
  }
}
