using LibraryManagementApplication.Model.Class;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for infoxaml.xaml
    /// </summary>
    public partial class infoxaml : Page
    {
        public infoxaml()
        {
            InitializeComponent();
            DataContext = GlobalData.LoginUser;
            MessageBox.Show($"User: {GlobalData.LoginUser.UserName}, Name: {tentb.Text}");
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"User: {GlobalData.LoginUser.UserName}, Name: {tentb.Text}");
        }
    }
}
