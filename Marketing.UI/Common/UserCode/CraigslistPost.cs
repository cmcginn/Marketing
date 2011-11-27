using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication {
  public partial class CraigslistPost {
    partial void RespondedTo_Compute( ref bool result ) {
      // Set result to the desired field value
      result = this.CraigsListResponses.Count() > 0;
    }
  }
}
