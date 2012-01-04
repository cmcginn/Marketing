using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Marketing.Utils;
using Marketing.Utils.Extensions;
using System.Xml.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Marketing.Tests {
  [TestClass]
  public class CraigslistParsingTests {
    [TestMethod]
    public void GetListingContentItemTest() {
      var target = new ListingContentItem();
      target.ContentHtml = XElement.Parse( TestResources.cl2 );
      target.GetListingContentItem();
      //self asserting
      long.Parse( target.ListingContentId );
      Assert.IsTrue( target.PostDate == System.DateTime.Parse( "12/9/2011 8:31:00 AM" ) );
      Assert.IsTrue(target.ReplyTo.Contains( "@" ));
    }
  }
}
