using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication {
  public partial class UserListingItem {
    List<UserKeywordSelection> _UserKeywords;
    List<UserKeywordSelection> UserKeywords {
      get {
        if( _UserKeywords == null ) {
          _UserKeywords = this.DataWorkspace.MarketingDomainServiceData.UserKeywordSelections.Where( x => x.UserId == this.UserId ).OfType<UserKeywordSelection>().ToList();
        }
        return _UserKeywords;
      }
    }
    partial void Score_Compute( ref int result ) {
     
      var score = 0;
      UserKeywords.ForEach( x => {
        if( this.PostHtml.Contains( x.Keyword ) )
          score = score + x.WeightedScore;
      } );
      result = score;
    }
  }
}
