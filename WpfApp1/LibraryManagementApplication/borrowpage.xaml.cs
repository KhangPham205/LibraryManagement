using LibraryManagementApplication.Model.Class;
using LibraryManagementApplication.ViewModel;
using LibraryManagementApplication.ViewModel.ClassViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for muonpage.xaml
    /// </summary>
    public partial class borrowpage : Page
    {
        private ObservableCollection<ThongTinDonMuon> ttdonmuons;
        private LibraryDbContext _context;
        public borrowpage()
        {
            InitializeComponent();

            ttdonmuons = new ObservableCollection<ThongTinDonMuon>();
            _context = new LibraryDbContext();

            _ = LoadThongTin();
        }

        private async Task<bool> LoadThongTin()
        {
            //ttdonmuons.Clear();
            //var donMuons = await _context.DonMuons.ToListAsync();

            //foreach (var item in donMuons)
            //{
            //    var tenDocGia = await _context.DocGias
            //        .Where(t => t.MaDG == item.MaDG)
            //        .Select(x => x.TenDG)
            //        .FirstOrDefaultAsync();

            //    ttdonmuons.Add(new ThongTinDonMuon
            //    {
            //        MaMuon = item.MaMuon,
            //        TenDG = tenDocGia ?? "Unknown",
            //        TenNV = GlobalData.LoginUser.UserID,
            //        NgayMuon = item.NgayMuon.ToShortDateString(),
            //        NgayTraDK = item.NgayTraDK.ToShortDateString(),
            //        NgayTraTT = item.NgayTraTT?.ToShortDateString() ?? "",
            //        PhiPhat = item.PhiPhat?.ToString() ?? "",
            //    });
            //    //MessageBox.Show(item.NgayTraTT.ToString());
            //}

            //datagridMuon.ItemsSource = null;
            //datagridMuon.ItemsSource = ttdonmuons;

            return true;
        }

        private async void adddon_Click(object sender, RoutedEventArgs e)
        {
            var addborrowwindow = new addborrowwindow();
            addborrowwindow.ShowDialog();
            await LoadThongTin();
        }
    }

    public class ThongTinDonMuon
    {
        public string MaMuon { get; set; }
        public string TenDG { get; set; }
        public string TenNV { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTraDK { get; set; }
        public string NgayTraTT { get; set; }
        public string PhiPhat { get; set; }
    }
}
