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
    public partial class CreateNewTemplate
    {
        Marketing.UI.Controls.TemplateEditorControl _TemplateEditor;

        partial void CreateNewTemplate_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.UserTemplateItemProperty = new UserTemplateItem();
            this.UserTemplateItemProperty.UserId = Application.UserId;
        }

        partial void CreateNewTemplate_Saved()
        {
            // Write your code here.
            this.Close(true);

        }
        
        partial void CreateNewTemplate_Saving(ref bool handled)
        {
            this.UserTemplateItemProperty.UserId = Application.UserId;
            this.UserTemplateItemProperty.TemplateHtml = _TemplateEditor.TemplateHtml;
            this.UserTemplateItemProperty.TemplateText = _TemplateEditor.TemplateText;
            handled = false;

        }

        partial void CreateNewTemplate_Activated()
        {
            this.FindControl("TemplateHtml").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(CreateNewTemplate_ControlAvailable);

        }

        void CreateNewTemplate_ControlAvailable(object sender, ControlAvailableEventArgs e)
        {
            _TemplateEditor = e.Control as Marketing.UI.Controls.TemplateEditorControl;
        }
    }
}