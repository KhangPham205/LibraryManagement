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
            List<DocGia> danhSachDocGia = new List<DocGia>
            {
                new DocGia { MaDG = "DG001", TenDG = "Nguyen Van A", Email = "a@gmail.com", CCCD = "123456789", SDT = "0912345678" },
                new DocGia { MaDG = "DG002", TenDG = "Tran Thi B", Email = "b@gmail.com", CCCD = "987654321", SDT = "0987654321" }
            };

            // Gán danh sách dữ liệu cho DataGrid
            sach.ItemsSource = danhSachDocGia;
        }
    }
}
