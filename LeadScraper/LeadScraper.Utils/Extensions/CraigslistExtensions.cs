using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Marketing.Data;
using System.Text.RegularExpressions;
namespace LeadScraper.Utils.Extensions {
  public static class CraigslistExtensions {
    static Regex _developmentWithUs = new Regex( @"(?<first>Development with us:)([\W\w\S\s]+)(?<last>Key Responsibilities:)(?<first-last>)" );
    static Regex _requirements = new Regex( @"(?<first>Requirements:)([\W\w\S\s]+)(?<last>Desirable skills:)(?<first-last>)" );
    static Regex _desirableSkills = new Regex( @"(?<first>Desirable skills:)([\W\w\S\s]+)(?<last><!-- START CLTAGS -->)(?<first-last>)" );
    static Regex _htmlCleanup = new Regex( @"<br>" );
    
    public static XElement GetDetails( this string response ) {
      response = _htmlCleanup.Replace( response, "" );
      var result = new XElement( "Details" );
      var developWithUs = new XElement( "Section" );
      developWithUs.Add( new XAttribute( "sectionName", "Develop With Us" ) );
      developWithUs.Value = _developmentWithUs.Match( response ).Groups[ 1 ].Value;
      result.Add( developWithUs );

      var requirements = new XElement("Section");
      requirements.Add( new XAttribute( "sectionName", "Requirements" ) );
      requirements.Value = _requirements.Match( response ).Groups[ 1 ].Value;
      result.Add( requirements );

      var desirableSkills = new XElement( "Section" );
      desirableSkills.Add( new XAttribute( "sectionName", "Desirable Skills" ) );
      desirableSkills.Value = _desirableSkills.Match( response ).Groups[ 1 ].Value;

      result.Add(desirableSkills);

      return result;
    }
  }


}
