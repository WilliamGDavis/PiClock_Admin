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

namespace PiClock_Admin
{
    /// <summary>
    /// Interaction logic for UserManagement.xaml
    /// </summary>
    public partial class UserManagement : Window
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void button_AddUser_Click(object sender, RoutedEventArgs e)
        {
            UserManagement_Adduser um_au = new UserManagement_Adduser();
            um_au.ShowDialog();
        }

        private void button_EditUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
