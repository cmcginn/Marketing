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
  public partial class SystemSettings {


    partial void RunOperation_Execute() {

      this.DataWorkspace.MarketingDomainServiceData.RunOperation( this.DataWorkspace.MarketingDomainServiceData.Operations.Where(n=>n.OperationName=="CraigslistRefresh").Single().Id);

    }
  }
}
