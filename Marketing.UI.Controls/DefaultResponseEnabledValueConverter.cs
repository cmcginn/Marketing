using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
namespace Marketing.UI.Controls {
  public class DefaultResponseEnabledValueConverter:IValueConverter {

    public object Convert( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture ) {
      bool result = false;
      DateTime? responded= value as DateTime?;
      result = responded.HasValue == false;
      return result;
    }

    public object ConvertBack( object value, Type targetType, object parameter, System.Globalization.CultureInfo culture ) {
      return value;
    }
  }
}
