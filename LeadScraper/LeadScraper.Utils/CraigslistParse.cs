using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace LeadScraper.Utils {
  public class CraigslistParse {

    static Regex _master = new Regex( @"(?<first><p>).*(?<last></p>)(?<first-last>)" );
    //Regex _title = new Regex( @"(?<first><title>).*(?<last></title>)(?<first-last>)" );
    //Regex _body = new Regex( @"(?<first><div id=""userbody"">)([\W\w\S\s]+)(?<last></div>)(?<first-last>)" );
    //Regex _tags = new Regex( @"(?<first><li>)([\W\w\S\s]+)(?<last></li>)(?<first-last>)" );
    List<string> _urls;
    public static List<String> GetUrls( string response ) {
      return _master.Matches( response ).OfType<Match>().ToList().Select( n => Regex.Match( n.Value, @"(?:<p><a href="")([:/.A-Za-z0-9]+)(?:"">)" ).Groups[ 1 ].Value ).ToList();
    }
    public static XElement GetPostingElement( string response ) {
      var converter = new LeadScraper.Utils.HtmlToXml.HtmlToXmlConverter();
      var element = converter.ConvertToXml( response.Replace( "<!DOCTYPE html PUBLIC \"-//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">", "" ) );
      return new XElement( "Post", element );
    }

  }
}
