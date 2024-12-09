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
    /// Interaction logic for employeepage.xaml
    /// </summary>
    public partial class employeepage : Page
    {
        public employeepage()
        {
            InitializeComponent();
            List<TaiKhoan> danhSachNhanVien = new List<TaiKhoan>
            {
                new TaiKhoan { UserID = "NV001", UserName = "Nguyen Van A", Password = "123", Email = "a@gmail.com", CCCD = "123456789", SDT = "0912345678" },
                new TaiKhoan { UserID = "NV002", UserName = "Tran Thi B", Password = "abc", Email = "b@gmail.com", CCCD = "987654321", SDT = "0987654321" }
            };

            // Gán dữ liệu cho DataGrid
            //sach.ItemsSource = danhSachNhanVien;
        }
    }
}
