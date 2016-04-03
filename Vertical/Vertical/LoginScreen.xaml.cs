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

namespace Vertical
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loginbox.Clear();
            passwordbox.Clear();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(MainWindow.home);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(MainWindow.home);
        }
    }
}