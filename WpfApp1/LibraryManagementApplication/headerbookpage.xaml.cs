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
using LibraryManagementApplication.ViewModel.ClassViewModel;

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for bookpage.xaml
    /// </summary>
    public partial class headerbookpage : Page
    {
        public headerbookpage()
        {
            InitializeComponent();

            this.Loaded += (s, e) =>
            {
                LoadTheLoai();
            };
        }
        private void LoadTheLoai()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    theloaitb.ItemsSource = context.TheLoais.Select(t => t.TenTL).ToList();
                    nxbtb.ItemsSource = context.NhaXuatBans.Select(nxb => nxb.TenNXB).ToList();
                    tacgiatb.ItemsSource = context.TacGias.Select(tg => tg.TenTG).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}");
            }
        }
    }
}
