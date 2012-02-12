using System;
using System.IO;
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
using DevExpress.Xpf.Editors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Model;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.Utils.NumberConverters;
using System.Globalization;
using DevExpress.XtraRichEdit.Services;
using DevExpress.Utils;
using Marketing.UI.Controls.Extensions;
namespace Marketing.UI.Controls {

  public partial class PostDetailsControl : UserControl {
    string _editorContent;
    public PostDetailsControl() { 
      InitializeComponent();

    }
    private void ResponseEditSource_TextChanged( object sender, TextChangedEventArgs e ) {
      if( String.IsNullOrEmpty( _editorContent ) ) {
        _editorContent = this.ResponseEditSource.Text.ToEditorDocument();
        richEditControl.HtmlText = _editorContent;
      }
    }

    private void richEditControl_HtmlTextChanged( object sender, EventArgs e ) {
      if( this.richEditControl.IsEnabled ) {
        ResponseHtmlEdit.Text = richEditControl.HtmlText;
        ResponseEditText.Text = richEditControl.Text;
        _editorContent = richEditControl.HtmlText;
      }
    }
     
    private void ResponseSent_TextChanged( object sender, TextChangedEventArgs e ) {
      this.richEditControl.IsEnabled = false;
    }

    private void richEditControl_DocumentLoaded( object sender, EventArgs e ) {
      if( this.richEditControl.IsEnabled ) {
        ResponseHtmlEdit.Text = richEditControl.HtmlText;
        ResponseEditText.Text = richEditControl.Text;
        _editorContent = richEditControl.HtmlText;
      }
    }



  }
}
