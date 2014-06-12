﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PrototypeEDUCOM.View
{
    /// <summary>
    /// Logique d'interaction pour RequestsView.xaml
    /// </summary>
    public partial class RequestsView : Window
    {
        public RequestsView()
        {
            InitializeComponent();
            this.DataContext = new ViewModel.RequestsViewModel();
        }
    }
}
