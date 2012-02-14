using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Text;
using System.Xml.Linq;
namespace Marketing.UI.Controls.Extensions {
  public static class DocumentExtensions {
    public const string DEFAULT_DOC = @"<html> <head> <meta HTTP-EQUIV=""Content-Type"" CONTENT=""text/html; charset=utf-8"" /> <title>Untitled Document</title> <style type=""text/css""></style> </head> <body> </body> </html>"; 


    public static string ToEditorDocument( this string content ) {
      if( string.IsNullOrEmpty( content ) )
        content = DEFAULT_DOC;
     
      var builder = new StringBuilder();
      content = System.Text.RegularExpressions.Regex.Replace( content, "<!DOCTYPE html .*>", "" );

      var element = XElement.Parse( content );
      var head = element.Element( "head" );      
      var style = head.Element( "style" );
      var body = element.Element( "body" );
      builder.Append( style.ToString() );
      builder.Append( body.ToString() );
      return builder.ToString();
    }
  }
}
