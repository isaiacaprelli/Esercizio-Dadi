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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Threading;

namespace Es_Dadi
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        bool lanciareDado = false;

        private void btnLanciaDadi_Click(object sender, RoutedEventArgs e)
        {
            if (lanciareDado = true)
            {
                btnLanciaDadi.IsEnabled = true;
                btnStoppaDadi.IsEnabled = false;
            }
            else
            {
                lanciareDado = true;
                Lancia();
            }

        }

        private void btnStoppaDadi_Click(object sender, RoutedEventArgs e)
        {
            if (lanciareDado = false)
            {
                btnStoppaDadi.IsEnabled = true;
                btnLanciaDadi.IsEnabled = false;
            }
            else
            {
                lanciareDado = false;
            }
        }
    }
}
