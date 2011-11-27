using System;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using Marketing.UI.Controls;
namespace LightSwitchApplication {
  public partial class PostingListDetail {


    partial void CraigslistPosts_SelectionChanged() {
      var element = this.CraigslistPosts.SelectedItem.PostsElement as XElement;
      var postContent = 
     // this.FindControl("PostElementDisplay")
    }
  }
}
