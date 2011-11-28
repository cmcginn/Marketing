using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication
{
    public partial class CreateNewCraigsListResponse
    {
        partial void CreateNewCraigsListResponse_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.CraigsListResponseProperty = new CraigsListResponse();
            this.CraigsListResponseProperty.CraigslistPost = this.DataWorkspace.MarketingDomainServiceData.CraigslistPosts.Where( x => x.Id == this.SelectedCraigslistPostId ).Single();
            
        }

        partial void CreateNewCraigsListResponse_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.CraigsListResponseProperty);
        }

        partial void CraigsListResponseProperty_Validate( ScreenValidationResultsBuilder results ) {
          // results.AddPropertyError("<Error-Message>");
          var x = "Y";
        }
    }
}