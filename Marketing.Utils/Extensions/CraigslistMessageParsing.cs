using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Marketing.Utils.HtmlToXml;
using System.Text.RegularExpressions;
namespace Marketing.Utils.Extensions {
  public static class CraigslistMessageParsing {

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
      return new XElement( "Post", element );
    }
  }
}
