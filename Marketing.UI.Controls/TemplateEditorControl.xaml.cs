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
using DevExpress.XtraRichEdit.Services;
using DevExpress.Utils;
using Marketing.UI.Controls.Extensions;
namespace Marketing.UI.Controls {
  public partial class TemplateEditorControl : UserControl {
    string _editorContent;
    public TemplateEditorControl() {
      InitializeComponent();
    }
    public void Refresh() {
      this.Dispatcher.BeginInvoke( () => {
        _editorContent = this.EditSource.Text.ToEditorDocument();
        richEditControl.HtmlText = _editorContent;
      } );
    }
    private void Source_TextChanged( object sender, TextChangedEventArgs e ) {
      if( String.IsNullOrEmpty( _editorContent ) ) {
        _editorContent = this.EditSource.Text.ToEditorDocument();
        EditText.Text = richEditControl.Text;
        richEditControl.HtmlText = _editorContent;
      }
    }

    private void richEditControl_HtmlTextChanged( object sender, EventArgs e ) {
      if( this.richEditControl.IsEnabled ) {
        HtmlEdit.Text = richEditControl.HtmlText;
        EditText.Text = richEditControl.Text;
        _editorContent = richEditControl.HtmlText;
      }
    }
    private void richEditControl_DocumentLoaded( object sender, EventArgs e ) {
      if( this.richEditControl.IsEnabled ) {
        HtmlEdit.Text = richEditControl.HtmlText;
        EditText.Text = richEditControl.Text;
        _editorContent = richEditControl.HtmlText;
      }
    }
  }
}
