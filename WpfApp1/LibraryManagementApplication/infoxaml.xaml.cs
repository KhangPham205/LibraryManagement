using LibraryManagementApplication.Model.Class;
using LibraryManagementApplication.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
        private LibraryDbContext context;
        private BitmapImage _profileImage;
        public infoxaml()
        {
            context = new LibraryDbContext();

            InitializeComponent();
            DataContext = GlobalData.LoginUser;
        }

        private void changemk_Click(object sender, RoutedEventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }
    }
}
