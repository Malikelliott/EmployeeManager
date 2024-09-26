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

namespace Quiz3_1
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        string username = "admin";
        string password = "system";
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == username && txtPassword.Password == password)
            {
                if (box.IsChecked == false) {
                    
 MessageBox.Show("Check the checkbox please", "Login Failed",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Either username or password is incorrect", "Login Failed", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
