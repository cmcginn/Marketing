using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication {
  public partial class CraigslistDetail {
    partial void AddResponse_Execute() {
      // Write your code here.
      this.Application.ShowCreateNewCraigsListResponse( this.CraigslistPosts.SelectedItem.Id );
    
    }
  }
}
