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
  public partial class TemplateEditorControl : UserControl,INotifyPropertyChanged {
    
    public TemplateEditorControl() {
      InitializeComponent();

    }

    string _TemplateHtml = "".ToEditorDocument();
    public string TemplateHtml 
    {
        get { return richEditControl.HtmlText; }
        set {
            if (value == richEditControl.HtmlText)
                return;

           richEditControl.HtmlText = value;
           OnPropertyChanged("HtmlText");
            
        } 
    }
    public string TemplateText { get { return richEditControl.Text; } }

    //private void richEditControl_HtmlTextChanged(object sender, EventArgs e)
    //{
    //    if (EditSource.Text != richEditControl.HtmlText)
    //        EditSource.Text = richEditControl.HtmlText;
    //}

    //private void EditSource_TextChanged(object sender, TextChangedEventArgs e)
    //{
    //    if (EditSource.Text != richEditControl.HtmlText)
    //        richEditControl.HtmlText = EditSource.Text;
    //}


    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        if (null != PropertyChanged)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
