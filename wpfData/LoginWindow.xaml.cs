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
using wpfData_Step_4.Model;
using wpfData_Step_4.ViewModel;

namespace wpfData_Step_4
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            UserDB userDB = new UserDB();
            User user = userDB.Login(tbxUsername.Text, tbxPassword.Password.ToString());
            if (user == null)
            {
                MessageBox.Show("Error in login\nCheck the details", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MainWindow main = new MainWindow();
            tbxUsername.Text = tbxPassword.Password = string.Empty;
            if (!user.IsAdmin)
            {
                MessageBox.Show("Not an admin", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            main.ShowDialog();
        }
    }
}
