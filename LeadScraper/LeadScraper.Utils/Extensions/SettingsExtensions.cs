using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Marketing.Data;
namespace LeadScraper.Utils.Extensions {
  public static class SettingsExtensions {
    static bool GetBooleanSettingOrDefault( this SystemSetting setting) {      
      bool result = false;
      var success = ( !String.IsNullOrEmpty( setting.StringValue ) && bool.TryParse( setting.StringValue, out result ) );
      if( !result )
        result = bool.Parse( setting.DefaultValue );
      return result;  
    }
    static string GetStringSettingValueOrDefault(this SystemSetting setting)
    {
      return String.IsNullOrEmpty(setting.StringValue)?setting.DefaultValue:setting.StringValue;
    }
    public static bool GetLiveModeSetting( this MarketingDomainModelContainer context ) {
     return context.SystemSettings.Single( n => n.SettingName == "Live Mode" ).GetBooleanSettingOrDefault();        
    }
    public static string GetEmailBccAddress( this MarketingDomainModelContainer context ) {
      return context.SystemSettings.Single( n => n.SettingName == "Email Bcc Address" ).GetStringSettingValueOrDefault();
    }
    public static string GetEmailFromAddress( this MarketingDomainModelContainer context ) {
      return context.SystemSettings.Single( n => n.SettingName == "Email From Address" ).GetStringSettingValueOrDefault();
    }
  }
}
