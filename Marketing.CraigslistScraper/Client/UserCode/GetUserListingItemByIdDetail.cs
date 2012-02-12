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
    public partial class GetUserListingItemByIdDetail
    {
        partial void GetUserListingItemById_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.GetUserListingItemById);
        }

        partial void GetUserListingItemById_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.GetUserListingItemById);
        }

        partial void GetUserListingItemByIdDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.GetUserListingItemById);
            this.Close(false);
        }
         
  
    }
}