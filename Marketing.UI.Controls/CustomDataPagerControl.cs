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
using System.Diagnostics;
using System.ComponentModel;

namespace Marketing.UI.Controls {
  public class PageCommand : ICommand {

    Action<object> _Execute;
    Predicate<object> _CanExecute;
    bool _Executable;
    bool _MayBeExecuted;

    public bool MayBeExecuted {
      get { return _MayBeExecuted; }
      set {
        if( _MayBeExecuted == value )
          return;

        _MayBeExecuted = value;
        OnCanExecuteChanged( value, EventArgs.Empty );
      }
    }

    public PageCommand( Predicate<object> canExecute, Action<object> execute ) {
      _Execute = execute;
      _CanExecute = canExecute;
    }
    public bool CanExecute( object parameter ) {
      MayBeExecuted = _CanExecute( parameter );
      return MayBeExecuted;

    }

    public event EventHandler CanExecuteChanged;


    public virtual void OnCanExecuteChanged( object sender, EventArgs e ) {
      EventHandler handler = CanExecuteChanged;
      if( handler != null )
        handler( sender, e );
    }
    public void Execute( object parameter ) {
      _Execute( parameter );
    }
  }
  public class CustomDataPagerControl : Control, INotifyPropertyChanged {


    public int PageIndex {
      get { return _PageIndex; }
      set {
        if( _PageIndex == value )
          return;
        _PageIndex = value;
        OnPropertyChanged( this, new PropertyChangedEventArgs( "PageIndex" ) );
      }
    }
    public int PageSize {
      get { return _PageSize; }
      set {
        if( _PageSize == value )
          return;
        _PageSize = value;
        OnPropertyChanged( this, new PropertyChangedEventArgs( "PageSize" ) );
      }
    }
    public int PageCount {
      get { return _PageCount; }
      set {
        if( _PageCount == value )
          return;
        _PageCount = value;
        OnPropertyChanged( this, new PropertyChangedEventArgs( "PageCount" ) );

      }
    }

    public CustomDataPagerControl()
      : base() {
      this.PropertyChanged += new PropertyChangedEventHandler( CustomDataPagerControl_PropertyChanged );
      DefaultStyleKey = typeof( CustomDataPagerControl );

    }
    void Refresh() {
      ( ( PageCommand )_NextPageButton.Command ).MayBeExecuted = _NextPageButton.Command.CanExecute( null );
      ( ( PageCommand )_LastPageButton.Command ).MayBeExecuted = _LastPageButton.Command.CanExecute( null );
      ( ( PageCommand )_FirstPageButton.Command ).MayBeExecuted = _FirstPageButton.Command.CanExecute( null );
      ( ( PageCommand )_PreviousPageButton.Command ).MayBeExecuted = _PreviousPageButton.Command.CanExecute( null );
      _CurrentPageTextBox.Text = PageIndex.ToString();

    }
    void CustomDataPagerControl_PropertyChanged( object sender, PropertyChangedEventArgs e ) {
      if( e.PropertyName == "PageIndex" )
        Refresh();
    }
    private int _PageCount;
    private int _PageSize;
    private int _PageIndex;
    Button _FirstPageButton;
    Button _PreviousPageButton;
    Button _NextPageButton;
    Button _LastPageButton;
    TextBox _CurrentPageTextBox;

    public override void OnApplyTemplate() {
      base.OnApplyTemplate();
      _PreviousPageButton = this.GetTemplateChild( "PreviousPageButton" ) as Button;
      _FirstPageButton = this.GetTemplateChild( "FirstPageButton" ) as Button;
      _LastPageButton = this.GetTemplateChild( "LastPageButton" ) as Button;
      _NextPageButton = this.GetTemplateChild( "NextPageButton" ) as Button;
      _CurrentPageTextBox = this.GetTemplateChild( "CurrentPageTextBox" ) as TextBox;

      _PreviousPageButton.Command = new PageCommand( ( a ) => {
        return PageIndex > 0;
      }, ( a ) => { PageIndex -= 1; } );

      _NextPageButton.Command = new PageCommand( ( a ) => {
        return PageIndex < PageCount;
      }, ( a ) => { PageIndex += 1; } );

      _LastPageButton.Command = new PageCommand( ( a ) => {
        return PageIndex != PageCount;
      }, ( a ) => { PageIndex = PageCount; } );

      _FirstPageButton.Command = new PageCommand( ( a ) => {
        return PageIndex != 0;
      }, ( a ) => { PageIndex = 0; } );
      Refresh();
    }

    public Style NumericButtonStyle {
      get { return ( Style )GetValue( NumericButtonStyleProperty ); }
      set { SetValue( NumericButtonStyleProperty, value ); }
    }

    // Using a DependencyProperty as the backing store for NumericButtonStyle.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty NumericButtonStyleProperty =
        DependencyProperty.Register( "NumericButtonStyle", typeof( Style ), typeof( CustomDataPagerControl ), null );
    public event PropertyChangedEventHandler PropertyChanged;
    public virtual void OnPropertyChanged( object sender, PropertyChangedEventArgs e ) {
      PropertyChangedEventHandler handler = PropertyChanged;
      if( handler != null )
        handler( sender, e );
    }
  }
}
