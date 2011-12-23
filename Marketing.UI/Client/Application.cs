using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Linq;
namespace LightSwitchApplication {
  public partial class Application {
    public static Guid UserId;
    public void OnCraigslistResponseAdded(object sender, EventArgs e) {

      EventHandler handler = CraigslistResponseAdded;
      if( handler != null )
        handler( sender,e);
    }

    public event EventHandler CraigslistResponseAdded;

    partial void Application_LoggedIn() {
      //throw new NotImplementedException();      
     //var user = this.CreateDataWorkspace().MarketingData.vw_aspnet_Users_Single( null, null, this.User.Name, this.User.Name.ToLower(), null, null );

    }
  }
}
