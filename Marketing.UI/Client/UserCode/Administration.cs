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
  public partial class Administration {

    // Fields...
    private Guid _SendEmailsInQueueId = new Guid("5366DA10-1189-4F1A-A51D-20659DE37BB4");
    private System.Guid _CraigslistRefreshId = new Guid("691167F8-0946-4DB0-A1AC-E71FF40F8605");


    public System.Guid CraigslistRefreshId {
      get { return _CraigslistRefreshId; }
      set { _CraigslistRefreshId = value; }
    }


    public Guid SendEmailsInQueueId {
      get { return _SendEmailsInQueueId; }
      set { _SendEmailsInQueueId = value; }
    }

    void RunServerCommand( Guid id ) {      
      var process = this.DataWorkspace.MarketingData.ServerOperationHistories.AddNew();
      process.Scheduled = System.DateTime.Now;
      process.ServerOperation = this.DataWorkspace.MarketingData.ServerOperations.Where( n => n.Id == id ).Single();
      this.Save();
      this.DataWorkspace.MarketingDomainServiceData.RunServerOperations();
    }
    bool ServerCommandCanExecute( Guid id ) {
      var pending = this.DataWorkspace.MarketingData.ServerOperationHistories.Where( n => n.ServerOperation.Id == id && n.Completed.HasValue == false ).FirstOrDefault();
      return pending == null;
    }
    partial void RunRefresh_Execute() {
      RunServerCommand( CraigslistRefreshId );
    }

    partial void SendQueuedEmails_Execute() {
      RunServerCommand( SendEmailsInQueueId );
    }

    partial void RunRefresh_CanExecute( ref bool result ) {
      result = ServerCommandCanExecute( CraigslistRefreshId );

    }

    partial void SendQueuedEmails_CanExecute( ref bool result ) {
      result = ServerCommandCanExecute( SendEmailsInQueueId );

    }

    partial void ViewResponse_Execute() {
      Application.ShowViewCraigslistResponse( this.CraigsListResponses.SelectedItem.Id );

    }

    partial void Administration_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
      // Write your code here.
   
    }
  }
}
