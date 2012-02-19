﻿using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Collections.Specialized;

namespace LightSwitchApplication {
  public partial class UserListItemsView {
    Marketing.UI.Controls.UserListItemsViewControl _UserListItemsViewControl;
    Marketing.UI.Controls.CustomDataPagerControl _Pager;
    
    bool _Activated;
    partial void UserListItemsView_InitializeDataWorkspace( List<IDataService> saveChangesTo ) {
      // Write your code here.
      this.UserId = Application.UserId;

   
    }

    partial void UserListItemsView_Activated() {
        if (!_Activated)
        {
            if (_UserListItemsViewControl == null)
                this.FindControl("GetFilteredUserListingItems").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(UserListItemsView_ControlAvailable);
            this.FindControl("GetUserPostListFilterItemByUserId").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(GetUserPostListFilterItemByUserId_ControlAvailable);           

            this.FindControl("GridPager").ControlAvailable += new EventHandler<ControlAvailableEventArgs>(GridPager_ControlAvailable);
            _Activated = true;
        }
       
    }

    void GetUserPostListFilterItemByUserId_ControlAvailable(object sender, ControlAvailableEventArgs e)
    {
        if (!_Activated)
        {
            var ctl = e.Control as Microsoft.LightSwitch.Runtime.Shell.Framework.ScreenChildWindow;
            ctl.HasCloseButton = false;
        }

    }
    void GridPager_ControlAvailable(object sender, ControlAvailableEventArgs e)
    {
        if (!_Activated)
        {
            var ctl = e.Control as Marketing.UI.Controls.PageControl;

            _Pager = ctl.Page as Marketing.UI.Controls.CustomDataPagerControl;
            _Pager.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(_Pager_PropertyChanged);
        }

    }
    void UserListItemsView_ControlAvailable( object sender, ControlAvailableEventArgs e ) {
        if (!_Activated)
        {
            _UserListItemsViewControl = e.Control as Marketing.UI.Controls.UserListItemsViewControl;
            _UserListItemsViewControl.OpenViewLinkClick += new EventHandler(OnOpenViewLinkClick);
            _UserListItemsViewControl.SendDefaultLinkClick += new EventHandler(OnSendDefaultLinkClick);
            _UserListItemsViewControl.ExcludeLinkClick += new EventHandler(_UserListItemsViewControl_ExcludeLinkClick);
            
        }

    }

    void _UserListItemsViewControl_ExcludeLinkClick(object sender, EventArgs e)
    {
        if (this.GetFilteredUserListingItems.SelectedItem != null)
            this.GetFilteredUserListingItems.SelectedItem.IsHidden = true;
    }

    void _Pager_PropertyChanged( object sender, System.ComponentModel.PropertyChangedEventArgs e ) {
      if(_Pager.PageIndex>0)
        this.GetFilteredUserListingItems.Details.PageNumber = _Pager.PageIndex;
    }

    void OnSendDefaultLinkClick( object sender, EventArgs e ) {
      var userListingResponse = this.GetFilteredUserListingItems.SelectedItem;
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
      this.Details.Dispatcher.BeginInvoke( () => {
          Application.ShowGetUserListingItemByIdDetail(this.GetFilteredUserListingItems.SelectedItem.Id);          
          
      } );
      
    }


    partial void GetFilteredUserListingItems_Loaded(bool succeeded)
    {
      
      _Pager.Dispatcher.BeginInvoke( () => {  
          _Pager.PageCount = this.GetFilteredUserListingItems.Details.PageCount;
          _Pager.PageIndex = this.GetFilteredUserListingItems.Details.PageNumber;
          _Pager.PageSize = this.GetFilteredUserListingItems.Details.PageSize;
          _Pager.Refresh();
      } );
    }

    partial void ShowFilter_Execute() {
      this.OpenModalWindow( "FilterModal" );
    }

    partial void SaveFilters_Execute()
    {
        if (this.GetUserPostListFilterItemByUserId.UserId == Guid.Empty)
            this.GetUserPostListFilterItemByUserId.UserId = Application.UserId;
        this.Save();
        this.CloseModalWindow("GetUserPostListFilterItemByUserId");

        

    }

    partial void ClearFilters_Execute()
    {
        // Write your code here.
        this.GetUserPostListFilterItemByUserId.FilteredCities = null;
        this.GetUserPostListFilterItemByUserId.FilteredCountries = null;
        GetUserPostListFilterItemByUserId.FilteredKeywords = null;
        GetUserPostListFilterItemByUserId.FilteredStates = null;
        GetUserPostListFilterItemByUserId.PostEndDate = null;
        GetUserPostListFilterItemByUserId.PostStartDate = null;
        GetUserPostListFilterItemByUserId.ResponseEndDate = null;
        GetUserPostListFilterItemByUserId.ResponseStartDate = null;
        GetUserPostListFilterItemByUserId.FiltersEnabled = true;
    }

  }
}
