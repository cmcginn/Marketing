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
    partial void Templates_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
      // Write your code here.
      this.UserId = Application.UserId;
    }

    partial void gridDeleteSelected_Execute() {  
      this.GetUserTemplates.DeleteSelected();
    }

    partial void GetUserTemplates_Changed( NotifyCollectionChangedEventArgs e ) {
      if( e.NewItems != null ) {
        e.NewItems.OfType<UserTemplateItem>().ToList().ForEach( n => {
          n.UserId = this.Application.UserId;
          n.Created = System.DateTime.Now;
        } );
      }
    }

    partial void GetUserTemplates_SelectionChanged() {
      _TemplateEditorControl.Refresh();
    }

    partial void Templates_Activated() {
      this.FindControl( "TemplateContent" ).ControlAvailable += new EventHandler<ControlAvailableEventArgs>( Templates_ControlAvailable );

    }

    void Templates_ControlAvailable( object sender, ControlAvailableEventArgs e ) {
      _TemplateEditorControl = e.Control as Marketing.UI.Controls.TemplateEditorControl;
    }

    partial void Templates_Saved() {
      this.Refresh();

    }

  }
}
