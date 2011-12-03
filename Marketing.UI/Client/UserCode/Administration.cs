﻿using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication {
  public partial class Administration {

    partial void RunRefresh_Execute() {
      this.DataWorkspace.MarketingDomainServiceData.RunCraigslistRefresh();

    }

    partial void SendQueuedEmails_Execute() {
      this.DataWorkspace.MarketingDomainServiceData.SendEmails();

    }
  }
}
