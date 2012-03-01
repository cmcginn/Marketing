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
    public partial class CreateNewUserFile
    {
        bool _Activated;
        Marketing.UI.Controls.FileUploadControl _FileUploadControl;
        partial void CreateNewUserFile_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.

            this.UserFileProperty = new UserFile();
        }

        partial void CreateNewUserFile_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.UserFileProperty);
        }

        partial void CreateNewUserFile_Activated()
        {
            // Write your code here.
            if (!_Activated)
            {
                this.FindControl("FileUploadControl").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(CreateNewUserFile_ControlAvailable);
            }

        }

        void CreateNewUserFile_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            _FileUploadControl = e.Control as Marketing.UI.Controls.FileUploadControl;
            _FileUploadControl.FileUploadComplete += new EventHandler(_FileUploadControl_FileUploadComplete);
        }

        void _FileUploadControl_FileUploadComplete(object sender, EventArgs e)
        {
            this.UserFileProperty.UserId = Application.UserId;
            this.UserFileProperty.RawFile = _FileUploadControl.GetBytes();
            this.UserFileProperty.Filename = _FileUploadControl.CurrentFile.Name;
            this.UserFileProperty.ByteCount = _FileUploadControl.CurrentFile.FileLength;
            this.UserFileProperty.Extension = _FileUploadControl.CurrentFile.File.Extension;
        }
    }
}