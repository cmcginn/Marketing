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
    public partial class Preferences
    {

      partial void Preferences_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
        this.userId = Application.UserId;

      }

      partial void Preferences_Activated() {
        // Write your code here.
       
        var x = "Y";
      }
    }
}