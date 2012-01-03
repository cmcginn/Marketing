using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace Marketing.Utils.Extensions {
  public static class DocumentExtensions {
    public static string ToEditorDocument( this string content ) {
      var builder = new StringBuilder();
      var element = XElement.Parse( content );
      var head = element.Element( "head" );
      var style = element.Element( "style" );
      var body = element.Element( "body" );
      builder.Append( style.ToString() );
      builder.Append( body.ToString() );
      return builder.ToString();
    }
  }
}
