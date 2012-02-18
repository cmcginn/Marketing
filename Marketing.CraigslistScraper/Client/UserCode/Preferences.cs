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

namespace LightSwitchApplication
{
    public partial class Preferences
    {

        partial void Preferences_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
        this.UserId = Application.UserId;
            
        }  
      partial void GetUserKeywordSelectionByUserId_Changed( NotifyCollectionChangedEventArgs e ) {
        if( e.NewItems != null ) {
          var added = e.NewItems.OfType<UserKeywordSelection>().LastOrDefault();
          if( added != null )
            added.UserId = UserId.GetValueOrDefault();
        }
      }

      partial void GetUserCitySelectionByUserId_Changed( NotifyCollectionChangedEventArgs e ) {
        if( this.GetUserCitySelectionByUserId.SelectedItem.UserId == Guid.Empty )
          this.GetUserCitySelectionByUserId.SelectedItem.UserId = Application.UserId;
      }

      partial void Preferences_Saved() {
        var keywordRefreshOperation = this.DataWorkspace.MarketingDomainServiceData.Operations.Where( n => n.OperationName == "Refresh Keyword Scores" ).Single();
        keywordRefreshOperation.UserId = this.Application.UserId;
        this.DataWorkspace.MarketingDomainServiceData.SaveChanges();
        this.Close( false );
      }



    }
}