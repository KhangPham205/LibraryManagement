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
    /// Interaction logic for bookpage.xaml
    /// </summary>
    public partial class headerbookpage : Page
    {
        public headerbookpage()
        {
            InitializeComponent();
            List<Sach> danhSachSach = new List<Sach> 
            { 
                new Sach { MaSach = "S001", TenSach = "Sách A", ISBN = "1234567890", NgonNgu = "Tiếng Việt", ViTri = "Kệ A1", TrangThai = "Còn" },
                new Sach {MaSach = "S002", TenSach = "Sách B", ISBN = "0987654321", NgonNgu = "Tiếng Anh", ViTri = "Kệ B2", TrangThai = "Mượn"}
            };
            // Gán danh sách dữ liệu cho DataGrid
            sach.ItemsSource = danhSachSach;
        }
    }
}
