using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Resources;

using Microsoft.LightSwitch.Presentation;

namespace Marketing.Extensions.Presentation.Controls {
  public partial class DataGridCollectionControl : UserControl {
    public DataGridCollectionControl() {
      InitializeComponent();
    }
  }

  [Export( typeof( IControlFactory ) )]
  [ControlFactory( "Marketing.Extensions:DataGridCollectionControl" )]
  internal class DataGridCollectionControlFactory : IControlFactory {
    #region IControlFactory Members

    public DataTemplate DataTemplate {
      get {
        if( null == this.dataTemplate ) {
          this.dataTemplate = XamlReader.Load( DataGridCollectionControlFactory.ControlTemplate ) as DataTemplate;
        }
        return this.dataTemplate;
      }
    }

    public DataTemplate GetDisplayModeDataTemplate( IContentItem contentItem ) {
      return null;
    }

    #endregion

    #region Private Fields

    private DataTemplate dataTemplate;

    #endregion

    #region Constants

    private const string ControlTemplate =
        "<DataTemplate" +
        " xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\"" +
        " xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\"" +
        " xmlns:ctl=\"clr-namespace:Marketing.Extensions.Presentation.Controls;assembly=Marketing.Extensions.Client\">" +
        "<ctl:DataGridCollectionControl/>" +
        "</DataTemplate>";

    #endregion
  }
}
