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
    public partial class TemplateEdit
    {
        Marketing.UI.Controls.TemplateEditorControl _TemplateEditor;
        System.Windows.Controls.ComboBox _UserFileId;
        Dictionary<Guid,String> _UserFiles;
        string _Template;
        partial void UserTemplateItem_Loaded(bool succeeded)
        {

            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserTemplateItem);
            _Template = this.UserTemplateItem.TemplateHtml;
           UserTemplateItem.LastUpdated = System.DateTime.Now;
        }

        partial void UserTemplateItem_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserTemplateItem);
        }

        partial void TemplateEdit_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserTemplateItem);
            this.Close(false);
        }
        
        partial void TemplateEdit_Saving(ref bool handled)
        {
  
            if (_selectedAttachmentId != Guid.Empty)
                this.UserTemplateItem.UserFileId = _selectedAttachmentId;
            this.UserTemplateItem.TemplateHtml = _TemplateEditor.TemplateHtml;
            this.UserTemplateItem.TemplateText = _TemplateEditor.TemplateText;
            this.UserTemplateItem.LastUpdated = System.DateTime.Now;
            handled = false;

        }

        partial void TemplateEdit_Activated()
        {
            this.FindControl("TemplateHtml").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(TemplateEdit_ControlAvailable);
            this.FindControl("UserFileId").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(UserFileId_ControlAvailable);
        }
        void UserFileId_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {

            _UserFileId = e.Control as System.Windows.Controls.ComboBox;
            _UserFileId.ItemsSource = _UserFiles;
            _UserFileId.DisplayMemberPath = "Value";
            _UserFileId.SelectedValuePath = "Key";
            if (_selectedAttachmentId != Guid.Empty)
                _UserFileId.SelectedValue = _selectedAttachmentId;
            _UserFileId.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(_UserFileId_SelectionChanged);

            
        }
        Guid _selectedAttachmentId = Guid.Empty;
        void _UserFileId_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            _selectedAttachmentId = (Guid)_UserFileId.SelectedValue;
        }
        void TemplateEdit_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            _TemplateEditor = e.Control as Marketing.UI.Controls.TemplateEditorControl;
            _TemplateEditor.Dispatcher.BeginInvoke(() =>
            {
                _TemplateEditor.TemplateHtml = _Template;
            });
         
        }
        
        partial void TemplateEdit_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            _UserFiles = this.Application.CreateDataWorkspace().MarketingDomainServiceData.GetUserFilesByUserId(this.Application.UserId).OfType<UserFile>().ToDictionary(n => n.Id, n => n.Filename);
            if (this.UserTemplateItem.UserFileId.HasValue)
                _selectedAttachmentId = this.UserTemplateItem.UserFileId.Value;
        }


    
    }
}

