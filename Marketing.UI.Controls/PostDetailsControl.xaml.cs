using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.ComponentModel;
namespace Marketing.UI.Controls {

  public partial class PostDetailsControl : UserControl {
    public PostDetailsControl() {     
      InitializeComponent();
      this.richEditControl.TextChanged += new EventHandler( richEditControl_TextChanged );
    }

    void richEditControl_TextChanged( object sender, EventArgs e ) {

      //ResponseEdit.Text = richEditControl.Text;
      ResponseHtmlEdit.Text = richEditControl.HtmlText;
    }


    
  }
}
