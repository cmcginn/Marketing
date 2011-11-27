using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using Common.Utils.Extensions;
namespace LeadScraper.Utils.Extensions {
  public class XsltExtensions {
    public XmlNode GetCraigslistJobDetails( XPathNodeIterator input ) {
      input.MoveNext();
      var body = input.Current.OuterXml;
      var resultDocument = new XDocument();
      var resultElement = body.GetDetails();
      resultDocument.Add( resultElement );
      var result = resultDocument.ToXmlDocument().FirstChild;
      return result;
    }

  }
}
