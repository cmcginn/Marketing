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

    void richEdit_AutoCorrect( object sender, AutoCorrectEventArgs e ) {
      AutoCorrectInfo info = e.AutoCorrectInfo;
      e.AutoCorrectInfo = null;

      //if( !edtCustomAutoCorrect.IsChecked.Value )
      //  return;

      if( info.Text.Length <= 0 || info.Text[ 0 ] != '%' )
        return;
      for( ; ; ) {
        if( !info.DecrementStartPosition() )
          return;

        if( IsSeparator( info.Text[ 0 ] ) )
          return;

        if( info.Text[ 0 ] == '%' ) {
          string replaceString = CalculateFunction( info.Text );
          if( !String.IsNullOrEmpty( replaceString ) ) {
            info.ReplaceWith = replaceString;
            e.AutoCorrectInfo = info;
          }
          return;
        }
      }
    }
    string CalculateFunction( string name ) {
      name = name.ToLower();

      if( name.Length > 2 && name[ 0 ] == '%' && name.EndsWith( "%" ) ) {
        int value;
        if( Int32.TryParse( name.Substring( 1, name.Length - 2 ), out value ) ) {
          OrdinalBasedNumberConverter converter = OrdinalBasedNumberConverter.CreateConverter( NumberingFormat.CardinalText, LanguageId.English );
          return converter.ConvertNumber( value );
        }
      }

      switch( name ) {
        case "%date%":
          return DateTime.Now.ToString( CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern );
        case "%time%":
          return DateTime.Now.ToString( CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern );
        case "%bye%":
          return "Yours sincerely,\r\nDavid B. Smith";
        default:
          return String.Empty;
      }
    }
    bool IsSeparator( char ch ) {
      return ch != '%' && ( ch == '\r' || ch == '\n' || Char.IsPunctuation( ch ) || Char.IsSeparator( ch ) || Char.IsWhiteSpace( ch ) );
    }
    //void edtReplaceAsYouType_CheckedChanged( object sender, RoutedEventArgs e ) {
    //  richEditControl.Options.AutoCorrect.ReplaceTextAsYouType = edtReplaceAsYouType.IsChecked.Value;
    //}
    //void edtDetectUrls_CheckedChanged( object sender, RoutedEventArgs e ) {
    //  richEditControl.Options.AutoCorrect.DetectUrls = edtDetectUrls.IsChecked.Value;
    //}
    //void edtCorrectTwoInitialCapitals_CheckedChanged( object sender, RoutedEventArgs e ) {
    //  richEditControl.Options.AutoCorrect.CorrectTwoInitialCapitals = edtCorrectTwoInitialCapitals.IsChecked.Value;
    //}
    //void edtUseSpellCheckerSuggestions_CheckedChanged( object sender, RoutedEventArgs e ) {
    //  richEditControl.Options.AutoCorrect.UseSpellCheckerSuggestions = edtUseSpellCheckerSuggestions.IsChecked.Value;
   // }
  }
}
