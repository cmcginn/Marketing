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
    public partial class AddUserFile
    {
        bool _Activated;
        Marketing.UI.Controls.FileUploadControl _FileUploadControl;
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

        partial void AddUserFile_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserFile);
        }

        partial void AddUserFile_Activated()
        {
            if (!_Activated)
            {
                this.FindControl("FileUploadControl").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(CreateNewUserFile_ControlAvailable);
                _Activated = true;
            }

        }
        void CreateNewUserFile_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            _FileUploadControl = e.Control as Marketing.UI.Controls.FileUploadControl;
            _FileUploadControl.FileUploadComplete += new EventHandler(_FileUploadControl_FileUploadComplete);
        }

        void _FileUploadControl_FileUploadComplete(object sender, EventArgs e)
        {
            this.UserFile.UserId = Application.UserId;
            this.UserFile.RawFile = _FileUploadControl.GetBytes();
            this.UserFile.Filename = _FileUploadControl.CurrentFile.Name;
            this.UserFile.ByteCount = _FileUploadControl.CurrentFile.FileLength;
            this.UserFile.Extension = _FileUploadControl.CurrentFile.File.Extension;
        }
    }
}