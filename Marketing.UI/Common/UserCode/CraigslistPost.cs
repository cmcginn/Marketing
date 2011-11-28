using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Xml;
//using System.Xml.Linq;
using Microsoft.LightSwitch;
namespace LightSwitchApplication {
  public partial class CraigslistPost {
    partial void RespondedTo_Compute( ref bool result ) {
      // Set result to the desired field value
      result = this.CraigsListResponses.Count() > 0;
    }

    partial void PostElementBody_Compute( ref string result ) {
      // Set result to the desired field value
      //var element = XElement.Parse( this.PostsElement );
      //result = element.Descendants( "Body" ).First().Value;
    }
  }
}
