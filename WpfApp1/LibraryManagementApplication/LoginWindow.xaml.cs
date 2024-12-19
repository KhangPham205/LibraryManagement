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

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            loginframe.Content = new SignInPage();  
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            signin.Visibility = Visibility.Visible;
            forgot.Visibility = Visibility.Collapsed;
            signup.Visibility = Visibility.Collapsed;
        }

        private void singin_Click(object sender, RoutedEventArgs e)
        {
            signin.Visibility = Visibility.Collapsed;
            forgot.Visibility = Visibility.Visible;
            signup.Visibility = Visibility.Visible;
        }

        private void forgot_Click(object sender, RoutedEventArgs e)
        {
            signin.Visibility = Visibility.Visible;
            forgot.Visibility = Visibility.Collapsed;
            signup.Visibility = Visibility.Visible;
        }
    }
}
