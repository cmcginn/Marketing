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
  public partial class Templates {
    Marketing.UI.Controls.TemplateEditorControl _TemplateEditorControl;
    Marketing.UI.Controls.FileUploadControl _FileUploadControl;
    Uri _uploadUri;
    bool _activated = false;

    int collectionCount = 0;
    DateTime? maxUpdated;
    partial void Templates_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
      // Write your code here.
      this.UserId = Application.UserId;
      collectionCount = this.GetUserTemplates.Count;
      maxUpdated = this.GetUserTemplates.Max(n => n.LastUpdated);  
    }
    partial void Templates_Activated()
    {
        _uploadUri = new Uri(Application.CreateDataWorkspace().MarketingDomainServiceData.SystemSettingItems.Where(n => n.SettingName == "UploadUrl").Single().SettingValue);
        var current= Application.CreateDataWorkspace().MarketingDomainServiceData.GetUserTemplates(this.Application.UserId).OfType<UserTemplateItem>();
        var currentCount = current.Count();
        var currentMaxUpdated = current.Max(n=>n.LastUpdated);
        if (currentCount > collectionCount || currentMaxUpdated.GetValueOrDefault() > maxUpdated.GetValueOrDefault())
        {
            this.Refresh();
            collectionCount = currentCount;
            maxUpdated = currentMaxUpdated;
        }
        if (!_activated)
        {
            this.FindControl("FileUploadControl").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(CreateNewUserFile_ControlAvailable);
            _activated = true;
        }
    }
    partial void GetUserTemplates_Changed(NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add)
            this.Refresh();
    }
    partial void gridAddAndEditNew_Execute()
    {
        Application.ShowCreateNewTemplate();

    }

    partial void GetUserFilesByUserIdAddAndEditNew_Execute()
    {
        // Write your code here.
        this._FileUploadControl.Dispatcher.BeginInvoke(() =>
            {
                this._FileUploadControl.IsEnabled = true;
            });
        
        this.GetUserFilesByUserId.SelectedItem = GetUserFilesByUserId.AddNew();
        
    }
    void CreateNewUserFile_ControlAvailable(object sender, ControlAvailableEventArgs e)
    {
        _FileUploadControl = e.Control as Marketing.UI.Controls.FileUploadControl;
     
        _FileUploadControl.UploadUrl = _uploadUri;
        _FileUploadControl.FileUploadComplete += new EventHandler(_FileUploadControl_FileUploadComplete);
        _FileUploadControl.IsEnabled = false;
    }

    void _FileUploadControl_FileUploadComplete(object sender, EventArgs e)
    {       
        
        this.GetUserFilesByUserId.SelectedItem.UserId = Application.UserId;
        this.GetUserFilesByUserId.SelectedItem.RawFile = _FileUploadControl.GetBytes();
        this.GetUserFilesByUserId.SelectedItem.Filename = _FileUploadControl.CurrentFile.Name;
        this.GetUserFilesByUserId.SelectedItem.ByteCount = _FileUploadControl.CurrentFile.FileLength;
        this.GetUserFilesByUserId.SelectedItem.Extension = _FileUploadControl.CurrentFile.File.Extension;
        this._FileUploadControl.Dispatcher.BeginInvoke(() =>
        {
            this._FileUploadControl.IsEnabled =false;
        });
       
    }



   


  


  }
}
