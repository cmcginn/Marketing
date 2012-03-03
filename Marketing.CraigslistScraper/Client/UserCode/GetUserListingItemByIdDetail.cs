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
        System.Windows.Controls.ComboBox _UserFileId;
        Dictionary<Guid, String> _UserFiles;
        Guid _selectedAttachmentId = Guid.Empty;
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

        partial void GetUserListingItemByIdDetail_Activated()
        {
            this.FindControl("UserFileId").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(GetUserListingItemByIdDetail_ControlAvailable);

        }

        void GetUserListingItemByIdDetail_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            _UserFileId = e.Control as System.Windows.Controls.ComboBox;
            _UserFiles.Add(Guid.Empty, "<None>");
            _UserFileId.ItemsSource = _UserFiles;
            _UserFileId.DisplayMemberPath = "Value";
            _UserFileId.SelectedValuePath = "Key";
            if (_selectedAttachmentId != Guid.Empty)
                _UserFileId.SelectedValue = _selectedAttachmentId;
            _UserFileId.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(_UserFileId_SelectionChanged);
        }
        void _UserFileId_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _selectedAttachmentId = (Guid)_UserFileId.SelectedValue;
        }

        partial void GetUserListingItemByIdDetail_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            _UserFiles = this.Application.CreateDataWorkspace().MarketingDomainServiceData.GetUserFilesByUserId(this.Application.UserId).OfType<UserFile>().ToDictionary(n => n.Id, n => n.Filename);
            if (this.GetUserListingItemById.UserFileId.HasValue)
                _selectedAttachmentId = this.GetUserListingItemById.UserFileId.Value;

        }

        partial void GetUserListingItemByIdDetail_Saving(ref bool handled)
        {
            if (_selectedAttachmentId != Guid.Empty)
                this.GetUserListingItemById.UserFileId = _selectedAttachmentId;
            else
                this.GetUserListingItemById.UserFileId = null;

        }
  
    }
}