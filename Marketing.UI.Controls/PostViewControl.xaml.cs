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
using DevExpress.Xpf.RichEdit;
using System.Xml.Linq;
namespace Marketing.UI.Controls {
  public partial class PostViewControl : UserControl {
    public PostViewControl() {
      InitializeComponent();
      var document = this.richEditControl.Document;
    }


    private void BodyText_TextChanged( object sender, TextChangedEventArgs e ) {

      this.richEditControl.HtmlText = System.Windows.Browser.HttpUtility.HtmlDecode(XElement.Parse(this.BodyText.Text).Element("body").ToString());

      }
  }
}
