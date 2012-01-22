using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;

namespace LightSwitchApplication {
  public partial class Application {
    private Guid _UserId;

    partial void Application_LoggedIn() {
      var workspace = this.CreateDataWorkspace().MarketingDomainServiceData;
      UserId = workspace.Users.Where( x => x.Username == this.User.Name ).Single().Id;
      
    }
    public Guid UserId {
      get {
        return _UserId;
      }
      set {
        _UserId = value;
      }
    }

  }
}
