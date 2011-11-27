using System;
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
namespace Marketing.UI.Controls {
  public class PostDetailsControlViewModel:INotifyPropertyChanged {
    public PostDetailsControlViewModel( XElement data ) {
      Title = data.Element( "Title" ).Value;
    }
    // Fields...
    private string _Title;


    public string Title {
      get { return _Title; }
      set {
        if( _Title == value )
          return;
        _Title = value;
        PropertyChanged( this, new PropertyChangedEventArgs( "Title" ) );
      }
    }

      
    public virtual void OnPropertyChanged( object sender, PropertyChangedEventArgs e ) {
      PropertyChangedEventHandler handler = PropertyChanged;
      if( handler != null )
        handler( sender, e );
    }
    public event PropertyChangedEventHandler PropertyChanged;
   
  }
  public partial class PostDetailsControl : UserControl {
    public PostDetailsControl() {
     
      InitializeComponent();
    
    }

    public void Load( XElement data ) {      
      this.DataContext = new PostDetailsControlViewModel( data );
    }
    
  }
}
