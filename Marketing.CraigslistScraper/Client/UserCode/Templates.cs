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
        var current= Application.CreateDataWorkspace().MarketingDomainServiceData.GetUserTemplates(this.Application.UserId).OfType<UserTemplateItem>();
        var currentCount = current.Count();
        var currentMaxUpdated = current.Max(n=>n.LastUpdated);
        if (currentCount > collectionCount || currentMaxUpdated.GetValueOrDefault() > maxUpdated.GetValueOrDefault())
        {
            this.Refresh();
            collectionCount = currentCount;
            maxUpdated = currentMaxUpdated;
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

  }
}
