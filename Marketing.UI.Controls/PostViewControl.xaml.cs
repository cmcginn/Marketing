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
      //this.richEditControl.HtmlText = this.BodyText.Text;
      var stuff = this.BodyText.Text;
      var cleaned = XElement.Parse(stuff);
      cleaned.Descendants().Where(x=>x.Attribute("href") != null).ToList().ForEach(x=>
        {
          x.Attribute("href").Value = String.Empty;
        });
      this.richEditControl.Document.HtmlText = cleaned.Element( "body" ).ToString();
      }
  }
}
