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
    /// Interaction logic for writerpage.xaml
    /// </summary>
    public partial class writerpage : Page
    {
        public writerpage()
        {
            InitializeComponent();
            List<TacGia> danhSachTacGia = new List<TacGia>
            {
            new TacGia { MaTG = "TG001", TenTG = "Nguyễn Nhật Ánh" },
            new TacGia { MaTG = "TG002", TenTG  = "Tô Hoài" },
            new TacGia { MaTG = "TG003", TenTG = "Vũ Trọng Phụng"}
            };
            // Gán danh sách dữ liệu cho DataGrid
            //tacgia.ItemsSource = danhSachTacGia;
        }

    }
}
