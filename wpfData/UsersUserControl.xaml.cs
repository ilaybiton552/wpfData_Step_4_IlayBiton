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
using wpfData_Step_4.ServiceReferenceSnack;

namespace wpfData
{
    /// <summary>
    /// Interaction logic for UsersUserControl.xaml
    /// </summary>
    public partial class UsersUserControl : UserControl
    {
        private ServiceSnackClient service = new ServiceSnackClient();
        public UsersUserControl()
        {
            InitializeComponent();
            UserList list = service.GetAllUsers();
            usersListView.ItemsSource = list;
        }
    }
}
