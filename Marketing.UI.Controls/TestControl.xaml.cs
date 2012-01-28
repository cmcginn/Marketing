using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Marketing.UI.Controls {
  public partial class TestControl : UserControl {
    public event EventHandler TitleLinkClick;

    public TestControl() {
      InitializeComponent();
    }
    
    private void HyperlinkButton_Click( object sender, RoutedEventArgs e ) {
      if( null != TitleLinkClick )
        TitleLinkClick( this, EventArgs.Empty );
    }


  }
}
