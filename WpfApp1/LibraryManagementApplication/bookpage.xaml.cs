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
    public partial class bookpage : Page
    {
        public bookpage()
        {
            InitializeComponent();
            List<Sach> danhSachSach = new List<Sach> 
            { 
                new Sach { MaSach = "S001", TenSach = "Sách A", ISBN = "1234567890", NgonNgu = "Tiếng Việt", ViTri = "Kệ A1", TrangThai = "Còn" },
                new Sach {MaSach = "S002", TenSach = "Sách B", ISBN = "0987654321", NgonNgu = "Tiếng Anh", ViTri = "Kệ B2", TrangThai = "Mượn"}
            };
            // Gán danh sách dữ liệu cho DataGrid
            sach.ItemsSource = danhSachSach;

            List<TacGia> danhSachTacGia = new List<TacGia>
            {
            new TacGia { MaTG = "TG001", TenTG = "Nguyễn Nhật Ánh" },
            new TacGia { MaTG = "TG002", TenTG  = "Tô Hoài" },
            new TacGia { MaTG = "TG003", TenTG = "Vũ Trọng Phụng"}
            };
            // Gán danh sách dữ liệu cho DataGrid
            tacgia.ItemsSource = danhSachTacGia;

            List<TheLoai> danhSachTheLoai = new List<TheLoai>
            {
                new TheLoai { MaTL = "TL001", TenTL = "Văn học" },
                new TheLoai { MaTL = "TL002", TenTL = "Khoa học" },
                new TheLoai { MaTL = "TL003", TenTL = "Thiếu nhi" }
            };
            // Gán danh sách dữ liệu cho DataGrid
            theloai.ItemsSource = danhSachTheLoai;

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
