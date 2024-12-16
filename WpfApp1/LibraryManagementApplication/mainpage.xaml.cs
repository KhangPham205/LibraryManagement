using LibraryManagementApplication.Model.Class;
using LibraryManagementApplication.ViewModel;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
    /// Interaction logic for mainpage.xaml
    /// </summary>
    public partial class mainpage : Page
    {
        public LibraryDbContext context = new LibraryDbContext();
        public int availableBooksCount { get; set; }
        public int borrowedBooksCount { get; set; }
        public int lostBooksCount { get; set; }
        public mainpage()
        {
            InitializeComponent();
            datagridDSMuon.ItemsSource = context.DonMuons.ToList();
            
            // Gán danh sách dữ liệu cho DataGrid
            PointLabel = chartPoint => string.Format("{0},({1:p})", chartPoint.Y, chartPoint.Participation);
            DataContext = this;
            //Biểu đồ cột
            Series = new SeriesCollection()
            {
                new RowSeries
                {
                    Title = "Được mượn:",
                    Values = new ChartValues<int>(Top5TheLoaiSachs().Select(t => t.SoLuongMuon))
                }
            };
            Labels = Top5TheLoaiSachs().Select(t => t.TenTL).ToList();

            // Biểu đồ đường
            lineSeries = new SeriesCollection() { 
                new LineSeries
                {
                    Title = "Số sách mượn",
                    Values = new ChartValues<int>(GetBooksBorrowedByMonth())
                }
            };
            Months = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            Formatter = value => value.ToString();

            // Biểu đồ tròn
            foreach (var item in context.Sachs.ToList())
            {
                if (item.TrangThai == "Có sẵn")
                    availableBooksCount++;
                else if (item.TrangThai == "Được mượn")
                    borrowedBooksCount++;
                else
                    lostBooksCount++;
            }

            PieSeriesAvailable.Values = new ChartValues<int> { availableBooksCount };
            PieSeriesBorrowed.Values = new ChartValues<int> { borrowedBooksCount };
            PieSeriesLost.Values = new ChartValues<int> { lostBooksCount };
        }
        
        public Func<ChartPoint, string> PointLabel { get; set; }
        public SeriesCollection Series { get; set; }
        public SeriesCollection lineSeries { get; set; }
        public List<string> Labels { get; set; }
        public string[] Months { get; set; }

        public Func<double, string> Formatter { get; set; }

        public List<TheLoaiReport> Top5TheLoaiSachs()
        {
            // Kết nối các bảng: CTDM, Sach, DauSach, TheLoai
            var query = from ctdm in context.CTDMs
                        join sach in context.Sachs on new { ctdm.MaDauSach, ctdm.ISBN } equals new { sach.MaDauSach, sach.ISBN }
                        join dausach in context.DauSachs on sach.MaDauSach equals dausach.MaDauSach
                        join theloai in context.TheLoais on dausach.TenTL equals theloai.TenTL // Giả sử bạn kết nối theo TenTL
                        group theloai by theloai.TenTL into grouped
                        select new
                        {
                            TheLoai = grouped.Key,
                            SoLuongMuon = grouped.Count() // Đếm số lần thể loại này được mượn
                        };

            // Sắp xếp theo số lượng mượn giảm dần và lấy top 5
            var top5TheLoai = query.OrderBy(x => x.SoLuongMuon)
                                   .Take(5)
                                   .Select(x => new TheLoaiReport
                                   {
                                       TenTL = x.TheLoai,
                                       SoLuongMuon = x.SoLuongMuon // Trả về số lượng mượn cùng với tên thể loại
                                   })
                                   .ToList();

            return top5TheLoai;
        }
        public List<int> GetBooksBorrowedByMonth()
        {
            var borrowData = new List<int>(new int[12]); // Mảng lưu số lượng mượn theo tháng

            // Lấy dữ liệu từ bảng DonMuon và nhóm theo tháng
            var query = from donMuon in context.DonMuons
                        join ctdm in context.CTDMs on new {donMuon.MaMuon} equals new {ctdm.MaMuon}
                        where donMuon.NgayMuon != null
                        group donMuon by donMuon.NgayMuon.Month into grouped
                        select new
                        {
                            Month = grouped.Key,
                            Count = grouped.Count()
                        };

            // Cập nhật số lượng sách mượn vào từng tháng trong mảng borrowData
            foreach (var data in query)
            {
                borrowData[data.Month - 1] = data.Count; // Gán số sách mượn vào đúng tháng
            }

            return borrowData;
        }
    }

    public class TheLoaiReport
    {
        public string TenTL { get; set; }  // Tên thể loại
        public int SoLuongMuon { get; set; } // Số lượng sách mượn
    }
}
