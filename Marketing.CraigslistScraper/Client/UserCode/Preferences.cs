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

namespace LightSwitchApplication
{
    public partial class Preferences
    {

      partial void Preferences_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
        this.UserId = Application.UserId;
      }
      void SaveUserCitySelections() {
        var x = "Y";
      }
      partial void Preferences_Saving( ref bool handled ) {
        // Write your code here.
        SaveUserCitySelections();
      }



    }
}