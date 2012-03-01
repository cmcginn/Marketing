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
    public partial class UserFileUpload
    {
        partial void UserFile_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserFile);
        }

        partial void UserFile_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserFile);
        }

        partial void UserFileUpload_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserFile);
        }
    }
}