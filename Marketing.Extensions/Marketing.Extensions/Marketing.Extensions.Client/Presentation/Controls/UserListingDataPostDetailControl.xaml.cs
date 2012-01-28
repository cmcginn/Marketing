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
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Details;
using Microsoft.LightSwitch.Model;
using System.Windows.Data;
using System.Diagnostics;
using Microsoft.LightSwitch.Presentation;

namespace Marketing.Extensions.Presentation.Controls {
  public partial class UserListingDataPostDetailControl : UserControl {
    public UserListingDataPostDetailControl() {
      InitializeComponent();
      this.SetBinding( ContentItemProperty, new Binding() );
      this.SetBinding( DisplayPropertyNameProperty, new Binding( "Properties[DetailControlExtension:UserListingDataPostDetailControl/DisplayPropertyName]" ) );
    }
    public string DisplayPropertyName {
      get { return ( string )GetValue( DisplayPropertyNameProperty ); }
      set { SetValue( DisplayPropertyNameProperty, value ); }
    }

    public static readonly DependencyProperty DisplayPropertyNameProperty =
        DependencyProperty.Register( "DisplayPropertyName", typeof( string ), typeof( UserListingDataPostDetailControl ), new PropertyMetadata( OnDisplayPropertyNameChanged ) );

    private static void OnDisplayPropertyNameChanged( DependencyObject d, DependencyPropertyChangedEventArgs e ) {
      // When the DisplayPropertyName is changed, reset the internal data binding.
      ( ( UserListingDataPostDetailControl )d ).SetContentDataBinding();
    }
    public IProperty EntityProperty {
      get { return ( IProperty )GetValue( EntityPropertyProperty ); }
      set { SetValue( EntityPropertyProperty, value ); }
    }

    public static readonly DependencyProperty EntityPropertyProperty =
        DependencyProperty.Register( "EntityProperty", typeof( IProperty ), typeof( UserListingDataPostDetailControl ), new PropertyMetadata( null ) );

    public IContentItem ContentItem {
      get { return ( IContentItem )GetValue( ContentItemProperty ); }
      set { SetValue( ContentItemProperty, value ); }
    }

    public static readonly DependencyProperty ContentItemProperty = DependencyProperty.Register( "ContentItem",
                typeof( IContentItem ), typeof( UserListingDataPostDetailControl ), new PropertyMetadata( OnContentItemChanged ) );

    private static void OnContentItemChanged( DependencyObject d, DependencyPropertyChangedEventArgs e ) {
      // When the ContentItem is changed, reset the internal data binding.
      ( ( UserListingDataPostDetailControl )d ).SetContentDataBinding();
    }
    private void SetContentDataBinding() {
    
      //var x = "Y";

      //this.ClearValue( EntityPropertyProperty );
      var collection = ContentItem.ResultingDataType as Microsoft.LightSwitch.IEntityCollection;
      //if( ContentItem != null ) {
      //  // A detail control can only be bound to an entity object.  We can get the type from the ContentItem.
      //  IEntityType entityType = ContentItem.ResultingDataType as IEntityType;
      //  Debug.Assert( entityType != null, "Detail Control can only bind to an entity type." );

      //  if( entityType != null ) {
      //    string displayPropertyName = this.DisplayPropertyName;

      //    IEntityPropertyDefinition entityProperty =

      //            entityType.Properties.FirstOrDefault( p => String.Equals( p.Name, displayPropertyName, StringComparison.OrdinalIgnoreCase ) );
      //    if( string.IsNullOrEmpty( displayPropertyName ) ) {
      //      entityProperty = entityType.Properties.FirstOrDefault( p => string.Equals( p.Name, displayPropertyName, StringComparison.OrdinalIgnoreCase ) );
      //    }

      //    if( entityProperty != null ) {
      //      // Set data binding to the entity property.
      //      // Because the DataContext of the current control is always a content item, the binding path starts from a ContentItem.  ContentItem.Value should be the entity object.
      //      //  Entity.Details.Properties.[PropertyName] allows us to get the object representing a data property.  A short version "Value.[PropertyName]" can be used to access the
      //      //  value directly.  But using the data property object, we can access additional status, like whether it is readonly, and whether it has a validation error.
      //      this.SetBinding( EntityPropertyProperty, new Binding( String.Format( System.Globalization.CultureInfo.InvariantCulture, "Value.Details.Properties.{0}", entityProperty.Name ) ) );

         // }
       // }
     // }
    }
  }

  [Export( typeof( IControlFactory ) )]
  [ControlFactory( "Marketing.Extensions:UserListingDataPostDetailControl" )]
  internal class UserListingDataPostDetailControlFactory : IControlFactory {
    #region IControlFactory Members

    public DataTemplate DataTemplate {
      get {
        if( null == this.dataTemplate ) {
          this.dataTemplate = XamlReader.Load( UserListingDataPostDetailControlFactory.ControlTemplate ) as DataTemplate;
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
        "<ctl:UserListingDataPostDetailControl/>" +
        "</DataTemplate>";

    #endregion
  }
}
