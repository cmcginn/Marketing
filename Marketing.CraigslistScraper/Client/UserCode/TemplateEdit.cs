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
        partial void UserTemplateItem_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.UserTemplateItem);
            _TemplateEditor.TemplateHtml = this.UserTemplateItem.TemplateHtml;
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

            this.UserTemplateItem.TemplateHtml = _TemplateEditor.TemplateHtml;
            this.UserTemplateItem.TemplateText = _TemplateEditor.TemplateText;
            this.UserTemplateItem.LastUpdated = System.DateTime.Now;
            handled = false;

        }

        partial void TemplateEdit_Activated()
        {
            this.FindControl("TemplateHtml").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(TemplateEdit_ControlAvailable);

        }

        void TemplateEdit_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            _TemplateEditor = e.Control as Marketing.UI.Controls.TemplateEditorControl;
            
        }

        partial void TemplateEdit_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            
            var x = "Y";
        }
    }
}