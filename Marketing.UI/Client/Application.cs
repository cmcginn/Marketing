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

namespace LightSwitchApplication {
  public partial class Application {
    
    public void OnCraigslistResponseAdded(object sender, EventArgs e) {

      EventHandler handler = CraigslistResponseAdded;
      if( handler != null )
        handler( sender,e);
    }

    public event EventHandler CraigslistResponseAdded;

  }
}
