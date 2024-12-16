using LibraryManagementApplication.Model.Class;
using LiveCharts;
using LiveCharts.Wpf;
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
        public mainpage()
        {
            InitializeComponent();
            //List<Sach> danhSachSach = new List<Sach>
            //{
            //    new Sach { MaSach = "S001", TenSach = "Sách A", ISBN = "1234567890", NgonNgu = "Tiếng Việt", ViTri = "Kệ A1", TrangThai = "Còn" },
            //    new Sach {MaSach = "S002", TenSach = "Sách B", ISBN = "0987654321", NgonNgu = "Tiếng Anh", ViTri = "Kệ B2", TrangThai = "Mượn"}
            //};
            // PieChart 
            PointLabel = chartPoint => string.Format("{0},({1:p})", chartPoint.Y, chartPoint.Participation);
            DataContext = this;
            //BarChart
            Series = new SeriesCollection()
            {
                new RowSeries
                {
                    Title = "Được mượn:",
                    Values = new ChartValues<int> {15,35,60,90,120}
                }
            };
            //LineChart
            lineSeries = new SeriesCollection() { 
                new LineSeries
                {
                    Title = "Độc giả:",
                    Values = new ChartValues<int> {15,20,30,20,34,60,12,22,33,91,14,21}  
                }
            
            };
            Labels = new[] { "Cổ tích", "Tin học", "Nấu ăn", "Tình cảm", "Thơ" };
            Months = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            Formatter = value => value.ToString();
        }
        public Func<ChartPoint, string> PointLabel { get; set; }
        public SeriesCollection Series { get; set; }
        public SeriesCollection lineSeries { get; set; }
        public string[] Labels { get; set; }
        public string[] Months { get; set; }

        public Func<double, string> Formatter { get; set; }
    }
}
