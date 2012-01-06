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
    public partial class UserListingItemDetail
    {
        partial void UserListingItem_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserListingItem);
        }
      
        partial void UserListingItem_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserListingItem);
         
        }

        partial void UserListingItemDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserListingItem);
        }

        partial void UserListingItemDetail_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
          // Write your code here.
         
        }
      
        partial void UserListingItemDetail_Saving( ref bool handled ) {
          // Write your code here.
          if( this.UserListingItem.ResponseSent != null ) {           
            this.ShowMessageBox( "This response has already been sent and cannot be saved." );
            handled = true;
          }          
        }


    }
}