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

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for addborrow.xaml
    /// </summary>
    public partial class addborrow : Page
    {
        private LibraryDbContext _context;
        private List<BorrowedBook> DanhSachMuon;
        public addborrow() 
        { 
            InitializeComponent();

            DanhSachMuon = new List<BorrowedBook>();
            _context = new LibraryDbContext(); 
            LoadBookTitles(); 
        }
        private void LoadBookTitles() 
        { 
            tensachtb.ItemsSource = _context.DauSachs.Select(t => t.TenDauSach).ToList(); 
        }
        private void Tensachtb_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        { 
            if (tensachtb.SelectedItem != null) 
            { 
                string selectedBookTitle = tensachtb.SelectedItem.ToString(); 
                isbn.ItemsSource = _context.Sachs.Where(t => t.TenDauSach == selectedBookTitle).Select(t => t.ISBN).ToList(); 
            } 
        }

        private void addsach_Click(object sender, RoutedEventArgs e)
        {
            if (tensachtb.SelectedItem != null && isbn.SelectedItem != null) 
            {
                DanhSachMuon.Add(new BorrowedBook 
                { 
                    TenDauSach = tensachtb.SelectedItem.ToString(), 
                    ISBN = isbn.SelectedItem.ToString() 
                });
            }
            sachlist.ItemsSource = null; // Reset the ItemsSource to refresh the UI
            sachlist.AutoGenerateColumns = false;
            sachlist.ItemsSource = DanhSachMuon;
        }
    }

    public class BorrowedBook
    {
        public string TenDauSach { get; set; }
        public string ISBN { get; set; }
    }

}
