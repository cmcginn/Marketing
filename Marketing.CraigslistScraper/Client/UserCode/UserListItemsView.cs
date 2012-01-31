using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Windows.Threading;
namespace LightSwitchApplication {
  public partial class UserListItemsView {
    Marketing.UI.Controls.UserListItemsViewControl _UserListItemsViewControl;
    Marketing.UI.Controls.CustomDataPagerControl _Pager;

    partial void UserListItemsView_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
      // Write your code here.
      this.UserId = Application.UserId;
      this.LoadingModalDisplayText = "Please be patient";
    }

    partial void UserListItemsView_Activated() {
      if(_UserListItemsViewControl==null)      
        this.FindControl( "GetUserListingItems" ).ControlAvailable += new EventHandler<ControlAvailableEventArgs>( UserListItemsView_ControlAvailable );
      this.CloseModalWindow( "LoadingModal" );
    }

    void UserListItemsView_ControlAvailable( object sender, ControlAvailableEventArgs e ) {
      _UserListItemsViewControl = e.Control as Marketing.UI.Controls.UserListItemsViewControl;
      _UserListItemsViewControl.OpenViewLinkClick += new EventHandler( OnOpenViewLinkClick );
      _UserListItemsViewControl.SendDefaultLinkClick += new EventHandler( OnSendDefaultLinkClick );
      _Pager = _UserListItemsViewControl.PagerControl as Marketing.UI.Controls.CustomDataPagerControl;
      _Pager.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler( _Pager_PropertyChanged );

    }

    void _Pager_PropertyChanged( object sender, System.ComponentModel.PropertyChangedEventArgs e ) {
      if(_Pager.PageIndex>0)
        this.GetUserListingItems.Details.PageNumber = _Pager.PageIndex;
    }

    void OnSendDefaultLinkClick( object sender, EventArgs e ) {
      var userListingResponse = this.GetUserListingItems.SelectedItem;
      userListingResponse.UseDefaultResponse = true;
      userListingResponse.Responded = System.DateTime.Now;
      userListingResponse.ResponseSent = System.DateTime.Now;
      
      this.Details.Dispatcher.BeginInvoke( () => {
        this.Save();
       
      } );
    }

    void OnOpenViewLinkClick( object sender, EventArgs e ) {
      OpenResponseView_Execute();
    }

    partial void OpenResponseView_CanExecute( ref bool result ) {
      // Write your code here.
      result = true;
    }

    partial void OpenResponseView_Execute() {
      // Write your code here.
      this.OpenModalWindow( "LoadingModal" );
      this.Details.Dispatcher.BeginInvoke( () => {        
        Application.ShowDefaultScreen( this.GetUserListingItems.SelectedItem );       
        
      } );
      
    }

    partial void GetUserListingItems_Loaded( bool succeeded ) {
      _Pager.Dispatcher.BeginInvoke( () => {
        _Pager.PageCount = this.GetUserListingItems.Details.PageCount;
        _Pager.PageIndex = this.GetUserListingItems.Details.PageNumber;
        _Pager.PageSize = this.GetUserListingItems.Details.PageSize;
      } );
    }
  }
}
