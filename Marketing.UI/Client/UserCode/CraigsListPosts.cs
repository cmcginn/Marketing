using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Collections.Specialized;

namespace LightSwitchApplication {
  public partial class CraigsListPosts {
    partial void CreateNewResponse_Execute() {
      Application.ShowCreateNewCraigslistResponse( this.CraigslistPostViews.SelectedItem.Id );

    }

    partial void CraigsListPosts_Activated() {
      // Write your code here.
      Application.CraigslistResponseAdded += new EventHandler( Application_CraigslistResponseAdded );

    }

    void Application_CraigslistResponseAdded( object sender, EventArgs e ) {
      if( this.Details.Dispatcher.CheckAccess() )
        Refresh();
      else
        this.Details.Dispatcher.BeginInvoke( delegate() {
          Refresh();
        } );
      Application.CraigslistResponseAdded -= new EventHandler( Application_CraigslistResponseAdded );
    }
  }
}
