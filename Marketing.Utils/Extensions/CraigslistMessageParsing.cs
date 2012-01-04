using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Marketing.Utils.HtmlToXml;
using Common.Utils.Extensions;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Xml.Xsl;
using Marketing.Utils;
namespace Marketing.Utils.Extensions {
  public static class CraigslistMessageParsing {
    static Regex _postDate = new Regex( @"(?:Date:[\s]+)(20[0-9]{2}-[0-9]{1,2}-[0-9]{1,2},[\s]+[0-9]{1,2}:[0-9]{2}[AM|PM]+)" );
    static Regex _htmlCleanup = new Regex( @"<br>" );
    static Regex _description = new Regex( @"(?<first><div id=""userbody"">)([\W\w\S\s]+)(?<last><!-- START CLTAGS -->)(?<first-last>)" );
    public static List<ListingLocation> GetListingLocationsFromResponse(string response)
    {
      List<ListingLocation> result = new List<ListingLocation>();
      var converter = new Marketing.Utils.HtmlToXml.HtmlToXmlConverter();
      var xml = converter.ConvertToXml( response );
      xml.Descendants( "p" ).ToList().ForEach( p => {
        var a = p.Element( "a" );
        if( a != null ) {
          var listingLocation = new ListingLocation();          
          listingLocation.Location = new Uri(a.Attribute( "href" ).Value);
          listingLocation.ListingTitle = a.Value;
          listingLocation.ListingId = long.Parse( listingLocation.Location.ToString().Substring( listingLocation.Location.ToString().LastIndexOf( "/" ) +1 ).Replace( ".html", "" ) ).ToString();
          listingLocation.ListingSource="Craigslist";
          result.Add(listingLocation);
        }
      } );
      return result;
    }
    public static XElement GetPostingElement( string response ) {
      var converter = new HtmlToXmlConverter();
      var element = converter.ConvertToXml( response.Replace( "<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">", "" ) );
      return element;
    }
    public static void GetListingContentItem( this ListingContentItem  listingContentItem ) {

      ListingContentItem result = listingContentItem;
      var element = GetPostingElement( listingContentItem.ContentHtml.ToString() );
      var source = new XDocument();
      source.Add( element );
      XsltArgumentList arguments = new XsltArgumentList();
      arguments.AddExtensionObject( "urn:extensions", new XsltExtensions() );
      var post = source.Transform( arguments, XDocument.Parse( TransformationResources.CraigslistResponse ) ).Root;
      result.ContentElement = post;
      result.ListingContentId = long.Parse( post.Attribute( "id" ).Value ).ToString();
      result.ReplyTo = post.Attribute( "contact" ).Value;
      result.PostDate = DateTime.Parse( post.Attribute( "datetime" ).Value.Substring( 0, post.Attribute( "datetime" ).Value.LastIndexOf( " " ) ) );
     
    }
    public static XElement GetDetails( this string response ) {
      response = _htmlCleanup.Replace( response, "" );
      var result = new XElement( "Details" );
      result.Add( new XAttribute( "datetime", _postDate.Match( response ).Groups[ 1 ].Value ) );
      result.Value = _description.Match( response ).Groups[ 1 ].Value.Trim();
      return result;
    }
  }
}
