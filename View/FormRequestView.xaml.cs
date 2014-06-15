﻿using PrototypeEDUCOM.ViewModel;
using System;
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
    /// Logique d'interaction pour FormRequestView.xaml
    /// </summary>
    public partial class FormRequestView : Window
    {
        public FormRequestView()
        {
            InitializeComponent();
            this.DataContext = new RequestsViewModel();
        }
    }
}
