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
    /// Interaction logic for readerpage.xaml
    /// </summary>
    public partial class readerpage : Page
    {
        public readerpage()
        {
            InitializeComponent();
            readerpage page = new readerpage();
        }

        private void adddg_Click(object sender, RoutedEventArgs e)
        {
            Cleartextbox();
        }
        public void Cleartextbox() {
            tentb.Text = "";
            emailtb.Text = "";
            cccdtb.Text = "";
            sdttb.Text = "";
        }
    }
}
