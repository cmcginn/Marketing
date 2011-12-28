using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Marketing.Utils.HtmlToXml;
namespace Marketing.Utils.Extensions {
  public static class CraigslistMessageParsing {
    public static XElement GetPostingElement( string response ) {
      var converter = new HtmlToXmlConverter();
      var element = converter.ConvertToXml( response.Replace( "<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">", "" ) );
      return new XElement( "Post", element );
    }
  }
}
