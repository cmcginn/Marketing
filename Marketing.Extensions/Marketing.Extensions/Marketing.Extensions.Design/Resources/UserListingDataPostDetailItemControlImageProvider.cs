using System;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Windows.Media.Imaging;

using Microsoft.LightSwitch.BaseServices.ResourceService;

namespace Marketing.Extensions.Resources {
  [Export( typeof( IResourceProvider ) )]
  [ResourceProvider( "Marketing.Extensions.UserListingDataPostDetailItemControl" )]
  internal class UserListingDataPostDetailItemControlImageProvider : IResourceProvider {
    #region IResourceProvider Members

    public object GetResource( string resourceId, CultureInfo cultureInfo ) {
      return new BitmapImage( new Uri( "/$assemblyname$;component/Resources/ControlImages/UserListingDataPostDetailItemControl.png", UriKind.Relative ) );
    }

    #endregion
  }
}