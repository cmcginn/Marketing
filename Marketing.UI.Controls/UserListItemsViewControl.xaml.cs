﻿using System;
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

namespace Marketing.UI.Controls
{
    public partial class UserListItemsViewControl : UserControl
    {
        public event EventHandler OpenViewLinkClick;

        public event EventHandler SendDefaultLinkClick;

        public event EventHandler ExcludeLinkClick;

        public UserListItemsViewControl()
        {
            InitializeComponent();
            
        }

        public virtual void OnOpenViewLinkClick(object sender, EventArgs e)
        {
            EventHandler handler = OpenViewLinkClick;
            if (handler != null)
                handler(sender, e);
        }
        
        public virtual void OnExcludeLinkClick(object sender, EventArgs e)
        {
            var link = sender as System.Windows.Controls.HyperlinkButton;
            var grid = link.CommandParameter as System.Windows.Controls.Grid;
            var cell = grid.Parent as System.Windows.Controls.DataGridCell;
            var presenter = cell.Parent as System.Windows.Controls.Primitives.DataGridCellsPresenter;
            presenter.Visibility = Visibility.Collapsed;
            EventHandler handler = ExcludeLinkClick;
            if (handler != null)
                handler(sender, e);
        }
        public virtual void OnSendDefaultLinkClick(object sender, EventArgs e)
        {
            var link = sender as System.Windows.Controls.HyperlinkButton;
            link.IsEnabled = false;
            EventHandler handler = SendDefaultLinkClick;
            if (handler != null)
                handler(sender, e);
        }


    }
}
