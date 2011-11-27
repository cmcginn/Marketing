using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Microsoft.LightSwitch;
namespace LightSwitchApplication {
  public partial class CraigslistPost {
    partial void Body_Compute( ref string result ) {
      // Set result to the desired field value
      var element =  XElement.Parse(this.PostsElement);
      result = element.Descendants( "Body" ).First().Value;     
    }
  }
}
