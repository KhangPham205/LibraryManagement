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
    /// Interaction logic for publisherpage.xaml
    /// </summary>
    public partial class publisherpage : Page
    {
        public publisherpage()
        {
            InitializeComponent();
            List<NhaXuatBan> danhSachNXB = new List<NhaXuatBan>
            {
            new NhaXuatBan { MaNXB = "NXB001", TenNXB = "Kim Đồng" },
            new NhaXuatBan { MaNXB = "NXB002", TenNXB = "Giáo dục Việt Nam" },
            new NhaXuatBan { MaNXB = "NXB003", TenNXB = "Khoa học Kỹ thuật" }
            };
            // Gán danh sách dữ liệu cho DataGrid
            nxb.ItemsSource = danhSachNXB;
        }
    }
}
