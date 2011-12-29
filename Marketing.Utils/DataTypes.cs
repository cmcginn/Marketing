using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace Marketing.Utils{
  public class ListingLocation {
    public Uri Location { get; set; }
    public string ListingId { get; set; }
    public string ListingTitle { get; set; }
    public string ListingSource { get; set; }
  }
  public class ListingContentItem {
    public Uri Location { get; set; }
    public string ListingContentId { get; set; }
    public XElement ContentHtml { get; set; }
  }
}
