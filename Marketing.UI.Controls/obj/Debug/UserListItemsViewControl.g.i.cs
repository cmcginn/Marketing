﻿#pragma checksum "C:\Projects\Urbana\Marketing\Marketing.UI.Controls\UserListItemsViewControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "707314BFC1300B03343EF32C7E7E47B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Marketing.UI.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Marketing.UI.Controls {
    
    
    public partial class UserListItemsViewControl : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DataGrid DataGridControl;
        
        internal Marketing.UI.Controls.CustomDataPagerControl Pager;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Marketing.UI.Controls;component/UserListItemsViewControl.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.DataGridControl = ((System.Windows.Controls.DataGrid)(this.FindName("DataGridControl")));
            this.Pager = ((Marketing.UI.Controls.CustomDataPagerControl)(this.FindName("Pager")));
        }
    }
}

