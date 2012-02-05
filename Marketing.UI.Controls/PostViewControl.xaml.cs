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
    const string MARKUP_ERROR = "There was a problem retrieving this post. The post may no longer be available.";
    public PostViewControl() {
      InitializeComponent(); 
        
    }
    

    private void BodyText_TextChanged( object sender, TextChangedEventArgs e ) {
      if( !String.IsNullOrEmpty( this.BodyText.Text ) ) {
        
        try {
          this.richEditControl.Document.HtmlText = System.Windows.Browser.HttpUtility.HtmlDecode( XElement.Parse( this.BodyText.Text ).Element( "body" ).ToString() );
        } catch {
          this.richEditControl.Document.HtmlText = MARKUP_ERROR;
        }
      }else{
          this.richEditControl.IsEnabled = false;
      }

    }

    private void userControl_SizeChanged(object sender, SizeChangedEventArgs e)
    {
        this.richEditControl.Width = this.ActualWidth-40;
        this.richEditControl.MinHeight = this.richEditControl.Document.HtmlText.Length / 10;


    }
  }
}
