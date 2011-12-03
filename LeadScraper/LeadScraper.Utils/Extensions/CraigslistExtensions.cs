using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Common.Utils.Extensions;
using Marketing.Data;
using System.Xml.Xsl;
using System.Net.Mail;
using System.Web;
using System.Text.RegularExpressions;
namespace LeadScraper.Utils.Extensions {
  public static class CraigslistExtensions {
    static Regex _rawEmailGroups = new Regex( @"(?:mailto:)(?<email>[\S]+)(?:\?subject=)(?<subject>[^&]+)" );
    static Regex _developmentWithUs = new Regex( @"(?<first>Development with us:)([\W\w\S\s]+)(?<last>Key Responsibilities:)(?<first-last>)" );
    static Regex _requirements = new Regex( @"(?<first>Requirements:)([\W\w\S\s]+)(?<last>Desirable skills:)(?<first-last>)" );
    static Regex _desirableSkills = new Regex( @"(?<first>Desirable skills:)([\W\w\S\s]+)(?<last><!-- START CLTAGS -->)(?<first-last>)" );
    static Regex _postDate = new Regex( @"(?:Date:[\s]+)(20[0-9]{2}-[0-9]{1,2}-[0-9]{1,2},[\s]+[0-9]{1,2}:[0-9]{2}[AM|PM]+)" );
    static Regex _htmlCleanup = new Regex( @"<br>" );
    static Regex _description = new Regex( @"(?<first><div id=""userbody"">)([\W\w\S\s]+)(?<last><!-- START CLTAGS -->)(?<first-last>)" );
    public static XElement GetDetails( this string response ) {
      response = _htmlCleanup.Replace( response, "" );
      var result = new XElement( "Details" );
      result.Add( new XAttribute( "datetime", _postDate.Match( response ).Groups[ 1 ].Value ) );
      result.Value = _description.Match( response ).Groups[ 1 ].Value.Trim();
      return result;
    }

    public static XDocument TransformResponse( this XElement element ) {
      var input = new XDocument();
      input.Add( element );
      var args = new XsltArgumentList();
      args.AddExtensionObject( "urn:extensions", new XsltExtensions() );
      var result = input.Transform( args, XDocument.Parse( TransformationResources.CraigslistResponse ) );
      return result;
    }

    public static void SavePost( this XElement post, Guid craigslistPostCityId, List<Keyword> keywords, MarketingDomainModelContainer context ) {
      var postId = Int64.Parse( post.Attribute( "id" ).Value );
      var result = context.CraigslistPosts.SingleOrDefault( n => n.PostId == postId );
      if( result == null ) {
        result = new CraigslistPost();
        result.Id = Guid.NewGuid();
        result.CraigslistCityId = craigslistPostCityId;
        result.PostId = Int64.Parse( post.Attribute( "id" ).Value );
        result.EmailAddress = post.Attribute( "contact" ).Value;
        result.Title = post.Element( "Title" ).Value;
        result.PostDate = DateTime.Parse( post.Attribute( "datetime" ).Value.Substring( 0, post.Attribute( "datetime" ).Value.LastIndexOf( " " ) ) );
        result.PostsElement = post.ToString();
        if( !String.IsNullOrEmpty( result.EmailAddress.Replace( " ", "" ) ) )
          context.CraigslistPosts.AddObject( result );
      }
      result.GetKeywords( keywords );
    }

    public static void GetKeywords( this CraigslistPost craigslistPost, List<Keyword> keywords ) {
      var post = XElement.Parse(craigslistPost.PostsElement);
        var body = post.Descendants("Body").FirstOrDefault();
        if(body != null &! String.IsNullOrEmpty(body.Value))
        {
          var query = from keyword in keywords
                      let matched = body.Value.ToLower().Contains( keyword.KeywordValue.ToLower() )
                      where matched
                      select keyword;
          query.ToList().ForEach( n => {
            if( craigslistPost.CraigslistPostKeywords.Where( x => x.KeywordId == n.Id ).Count() == 0 )
              craigslistPost.CraigslistPostKeywords.Add( new CraigslistPostKeyword { KeywordId=n.Id } );
          } );
        }
    
      }

    public static MailMessage GetDefaultMailMessageResponse( this CraigsListResponse response, MarketingDomainModelContainer context ) {
      MailMessage result = null;
      var post = context.CraigslistPosts.Single( n => n.Id == response.CraigslitPostsId );
      var rawEmail = System.Web.HttpUtility.UrlDecode(post.EmailAddress).Replace("&amp;","&");
      var matches = _rawEmailGroups.Match(rawEmail);
      if( matches.Groups[ "email" ] != null ) {
        result = new MailMessage();
        //result.To.Add( new MailAddress( matches.Groups[ "email" ].Value ) );
        result.To.Add( "chris.s.mcginn@live.com" );
        if( matches.Groups[ "subject" ] != null )
          result.Subject = matches.Groups[ "subject" ].Value;
        result.IsBodyHtml = true;
        result.Body = response.ResponseHtmlContent;
        
        //result.AlternateViews.Add(new AlternateView(
      }
      return result;
    }
  }
}
