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

  public partial class CreateNewCraigslistResponse {
    partial void CreateNewCraigslistResponse_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
      this.CraigsListResponseProperty = new CraigsListResponse();
      this.CraigsListResponseProperty.CraigslistPost = this.DataWorkspace.MarketingData.CraigslistPosts.Where( x => x.Id == this.CraigslistPostId ).Single();
    }   
    partial void CreateNewCraigslistResponse_Saved() {
      this.Application.OnCraigslistResponseAdded( this, EventArgs.Empty );
      this.Close( false );
    }
  }
}