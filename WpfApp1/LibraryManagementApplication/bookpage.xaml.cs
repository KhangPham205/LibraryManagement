using LibraryManagementApplication.Model.Class;
using LibraryManagementApplication.ViewModel;
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
    /// Interaction logic for bookpage.xaml
    /// </summary>
    public partial class bookpage : Page
    {
        public bookpage()
        {
            InitializeComponent();

            trangthaitb.ItemsSource = new List<string>() { "Có sẵn", "Được mượn", "Thất lạc" };
            this.Loaded += (s, e) =>
            {
                LoadDauSach();
            };
        }

        private void trangthaitb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void LoadDauSach()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    tentb.ItemsSource = context.DauSachs.Select(t => t.TenDauSach).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }
    }
}
