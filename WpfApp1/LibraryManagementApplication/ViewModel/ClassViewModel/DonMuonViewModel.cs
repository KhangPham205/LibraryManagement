using LibraryManagementApplication.Model.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using LibraryManagementApplication;
using System.Data.SqlClient;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class DonMuonViewModel : BaseViewModel
    {
        private ObservableCollection<BorrowedBook> _danhSachMuon; 
        public ObservableCollection<BorrowedBook> DanhSachMuon 
        { 
            get { return _danhSachMuon; } 
            set 
            { 
                _danhSachMuon = value; 
                OnPropertyChanged(nameof(DanhSachMuon)); 
            } 
        }
        public string TenDauSach {  get; set; }
        public string ISBN { get; set; }


        public string MaMuon { get; set; }
        public string MaDG { get; set; }
        public string MaNV {  get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTraDK { get; set; }
        public DateTime? NgayTraTT { get; set; }
        public decimal? PhiPhat { get; set; }
        public ObservableCollection<DonMuon> DonMuonList { get; set; }
        private DonMuon _selectedDonMuon;
        public DonMuon SelectedDonMuon
        {
            get { return _selectedDonMuon; }
            set
            {
                if (_selectedDonMuon != value)
                {
                    _selectedDonMuon = value;
                    OnPropertyChanged(nameof(SelectedDonMuon));
                    if (SelectedDonMuon != null)
                    {
                        MaMuon = SelectedDonMuon.MaMuon;
                        MaDG = SelectedDonMuon.MaDG;
                        MaNV = SelectedDonMuon.MaNV;
                        NgayMuon = SelectedDonMuon.NgayMuon;
                        NgayTraDK = SelectedDonMuon.NgayTraDK;
                        NgayTraTT = SelectedDonMuon.NgayTraTT;
                        PhiPhat = SelectedDonMuon.PhiPhat;
                    }
                }
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand AddSachCommand {  get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand moveCommand { get; set; }
        public ICommand backCommand { get; set; }
        private async Task<string> CreateMaDMAsync()
        {
            // Generate a hash from MaMuon
            using (var context = new LibraryDbContext())
            {
                // Lấy tất cả các mã "MaMuon" hiện tại trong cơ sở dữ liệu có tiền tố "MN"
                var existingCodes = await context.DonMuons
                                                 .Where(tl => tl.MaMuon.StartsWith("MN"))
                                                 .Select(tl => tl.MaMuon)
                                                 .ToListAsync();

                int maxCodeNumber = existingCodes
                    .Select(code => int.TryParse(code.Substring(2), out int num) ? num : 0) // Lấy phần số sau "MN"
                    .DefaultIfEmpty(0) // Nếu không có mã nào, mặc định là 0
                    .Max(); // Lấy số lớn nhất trong danh sách mã

                // Tạo mã mới với số tăng dần
                int newCodeNumber = maxCodeNumber + 1;

                // Trả về mã mới với định dạng "MN" + số có 3 chữ số
                return $"MN{newCodeNumber:D3}";
            }
        }
        private CTDMViewModel _ctdmViewModel;
        LibraryDbContext context;
        public DonMuonViewModel()
        {
            _ctdmViewModel = new CTDMViewModel();
            context = new LibraryDbContext();
            DanhSachMuon = new ObservableCollection<BorrowedBook>();

            DonMuonList = new ObservableCollection<DonMuon>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddDonMuon());
            AddSachCommand = new RelayCommand<object>((p) => true, async (p) => await AddSachToCTDM());
            EditCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await EditDonMuon());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await DeleteDonMuon());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchDonMuon(p));
            moveCommand = new RelayCommand<Frame>((p) => true, (p) => { p.Content = new addborrow(); OnPropertyChanged(); });
            backCommand = new RelayCommand<Frame>((p) => true, (p) => {  p.Content= new borrowinfo(); OnPropertyChanged(); });

            //LoadDonMuonList();
        }

        private async void LoadDonMuonList()
        {
            var donMuons = await GetAllDonMuonAsync();
            foreach (var donMuon in donMuons)
            {
                DonMuonList.Add(donMuon);
            }
        }

        private async Task AddDonMuon()
        {
            DonMuon newDonMuon = new DonMuon()
            {
                MaMuon = MaMuon = await CreateMaDMAsync(),
                MaDG = MaDG,
                MaNV = MaNV = GlobalData.LoginUser.UserID,
                NgayMuon = DateTime.Now,
                NgayTraDK = DateTime.Now.AddMonths(1),
                NgayTraTT = null,
                PhiPhat = 0
            };
            //MessageBox.Show(newDonMuon.MaMuon + " " + newDonMuon.NgayMuon);
            bool isSuccess = await AddDonMuonToDatabaseAsync(newDonMuon);
            if (!isSuccess)
                MessageBox.Show("Cannot save changes to DonMuon.");
            else
                DonMuonList.Add(newDonMuon);
        }

        private async Task AddSachToCTDM()
        {
            try
            {
                bool isAddedToCTDM = false;
                if (TenDauSach != null && ISBN != null)
                {
                    var newCTDM = new CTDM
                    {
                        MaMuon = MaMuon,
                        MaDauSach = context.DauSachs.Where(t => t.TenDauSach == TenDauSach).Select(t => t.MaDauSach).FirstOrDefault().ToString(),
                        ISBN = ISBN
                    };
                    isAddedToCTDM = await _ctdmViewModel.AddCTDMToDatabaseAsync(newCTDM);

                    if (!isAddedToCTDM)
                        MessageBox.Show("Cannot save changes to CTDM.");
                    else
                    {
                        DanhSachMuon.Add(new BorrowedBook
                        {
                            TenDauSach = TenDauSach,
                            ISBN = ISBN
                        });
                        OnPropertyChanged(nameof(DanhSachMuon));
                    }
                }
                foreach (var item in DanhSachMuon)
                    MessageBox.Show(item.TenDauSach + " " + item.ISBN);
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database Update Error: {dbEx.Message}\nInner Exception: {dbEx.InnerException?.Message}");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}\nError Code: {sqlEx.Number}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Invalid Operation: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error CTDM: {ex.Message}");
            }
        }

        private async Task EditDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                // Here you would bind the selected object to edit mode, so changes reflect
                bool isSuccess = await UpdateDonMuonInDatabaseAsync(SelectedDonMuon);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating the record.");
                }
            }
        }

        private async Task DeleteDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                bool isSuccess = await DeleteDonMuonFromDatabaseAsync(SelectedDonMuon.MaMuon);
                if (isSuccess)
                {
                    DonMuonList.Remove(SelectedDonMuon);
                }
                else
                {
                    MessageBox.Show("Error deleting the record.");
                }
            }
        }

        private async Task SearchDonMuon(string keyword)
        {
            var filteredList = await SearchDonMuonInDatabaseAsync(keyword);
            DonMuonList.Clear();
            foreach (var donMuon in filteredList)
            {
                DonMuonList.Add(donMuon);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddDonMuonToDatabaseAsync(DonMuon donMuon)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.DonMuons.Add(donMuon);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database Update Error: {dbEx.Message}\nInner Exception: {dbEx.InnerException?.Message}");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}\nError Code: {sqlEx.Number}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Invalid Operation: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error DonMuon: {ex.Message}");
            }
            return false;
        }

        public static async Task<bool> UpdateDonMuonInDatabaseAsync(DonMuon donMuon)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.DonMuons.Update(donMuon);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating DonMuon: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteDonMuonFromDatabaseAsync(string maMuon)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var donMuonToDelete = await context.DonMuons.FirstOrDefaultAsync(dm => dm.MaMuon == maMuon);
                    if (donMuonToDelete != null)
                    {
                        context.DonMuons.Remove(donMuonToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting DonMuon: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<DonMuon>> SearchDonMuonInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.DonMuons
                                              .Where(dm => dm.MaMuon.Contains(keyword) || dm.MaDG.Contains(keyword))
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching DonMuon: {ex.Message}");
                return new List<DonMuon>();
            }
        }

        public static async Task<List<DonMuon>> GetAllDonMuonAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.DonMuons.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error getting all DonMuon: {ex.Message}");
                return new List<DonMuon>();
            }
        }

        #endregion
    }
    public class BorrowedBook
    {
        public string TenDauSach { get; set; }
        public string ISBN { get; set; }
    }
}