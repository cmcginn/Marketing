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
using System.ComponentModel;
namespace Marketing.UI.Controls {
  public partial class TemplateEditorControl : UserControl {
    string _editorContent;
    public TemplateEditorControl() {
      InitializeComponent();

    }

    string _TemplateHtml = "".ToEditorDocument();
    public string TemplateHtml 
    {
        get { return richEditControl.HtmlText; }
        set {
            _TemplateHtml = value;
            richEditControl.HtmlText = value;
            
        } 
    }
    public string TemplateText { get { return richEditControl.Text; } }

    private void richEditControl_Loaded(object sender, RoutedEventArgs e)
    {

        richEditControl.HtmlText = _TemplateHtml;
    }




  }
}
