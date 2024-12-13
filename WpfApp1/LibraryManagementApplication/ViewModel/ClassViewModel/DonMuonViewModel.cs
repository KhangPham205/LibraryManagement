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

        private string maMuon;
        private string maDG;
        private string maNV;
        private string ngayMuon;
        private string ngayTraDK;
        private string ngayTraTT;
        private string phiPhat;
        public string MaMuon 
        { 
            get => maMuon; 
            set
            {
                if (maMuon != value)
                {
                    maMuon = value;
                    OnPropertyChanged(nameof(MaMuon));
                }
            }
        }
        public string MaDG
        {
            get => maDG;
            set
            {
                if (maDG != value)
                {
                    maDG = value;
                    OnPropertyChanged(nameof(MaDG));
                }
            }
        }
        public string MaNV
        {
            get => maNV;
            set
            {
                if (maNV != value)
                {
                    maNV = value;
                    OnPropertyChanged(nameof(MaNV));
                }
            }
        }
        public string NgayMuon
        {
            get => ngayMuon;
            set
            {
                if (ngayMuon != value)
                {
                    ngayMuon = value;
                    OnPropertyChanged(nameof(NgayMuon));
                }
            }
        }
        public string NgayTraDK
        {
            get => ngayTraDK;
            set
            {
                if (ngayTraDK != value)
                {
                    ngayTraDK = value;
                    OnPropertyChanged(nameof(NgayTraDK));
                }
            }
        }
        public string NgayTraTT
        {
            get => ngayTraTT;
            set
            {
                if (ngayTraTT != value)
                {
                    ngayTraTT = value;
                    OnPropertyChanged(nameof(NgayTraTT));
                }
            }
        }
        public string PhiPhat
        {
            get => phiPhat;
            set
            {
                if (phiPhat != value)
                {
                    phiPhat = value;
                    OnPropertyChanged(nameof(PhiPhat));
                }
            }
        }

        public ObservableCollection<DonMuon> DonMuonList { get; set; }
        private ThongTinDonMuon _selectedDonMuon;
        public ThongTinDonMuon SelectedDonMuon
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
                        MaDG = context.DocGias.Where(t => t.TenDG == SelectedDonMuon.TenDG).Select(t => t.MaDG).FirstOrDefault();
                        MaNV = context.TaiKhoans.Where(nv => nv.UserName == SelectedDonMuon.TenNV).Select(nv => nv.UserID).FirstOrDefault();
                        NgayMuon = SelectedDonMuon.NgayMuon;
                        NgayTraDK = SelectedDonMuon.NgayTraDK;
                        NgayTraTT = SelectedDonMuon.NgayTraTT.ToString();
                        PhiPhat = SelectedDonMuon.PhiPhat.ToString();

                        DanhSachMuon.Clear();
                        foreach (var item in context.CTDMs)
                            if (item != null && item.MaMuon ==  SelectedDonMuon.MaMuon)
                            {
                                Sach sach = context.Sachs.Where(s => s.MaDauSach == item.MaDauSach && s.ISBN == item.ISBN).FirstOrDefault();
                                DanhSachMuon.Add(new BorrowedBook()
                                {
                                    TenDauSach = sach.TenDauSach,
                                    ISBN = sach.ISBN
                                });
                            }
                    }
                }
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand RestoreCommand { get; set; }
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
        private LibraryDbContext context;
        public DonMuonViewModel()
        {
            _ctdmViewModel = new CTDMViewModel();
            context = new LibraryDbContext();
            DanhSachMuon = new ObservableCollection<BorrowedBook>();

            DonMuonList = new ObservableCollection<DonMuon>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddDonMuon());
            EditCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await EditDonMuon());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await DeleteDonMuon());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchDonMuon(p));
            RestoreCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await TraDonMuon());

            //LoadDonMuonList();
        }

        #region Method
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

        private async Task TraDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                DonMuon donMuon = new DonMuon()
                {
                    MaMuon = SelectedDonMuon.MaMuon,
                    MaDG = context.DonMuons.Where(t => t.MaMuon == SelectedDonMuon.MaMuon).Select(t => t.MaDG).FirstOrDefault(),
                    MaNV = GlobalData.LoginUser.UserID,
                    NgayMuon = DateTime.Parse(SelectedDonMuon.NgayMuon),
                    NgayTraDK = DateTime.Parse(SelectedDonMuon.NgayTraDK),
                    NgayTraTT = DateTime.Now,
                    PhiPhat = 0
                };

                bool isSuccess = await UpdateDonMuonInDatabaseAsync(donMuon);
                if (!isSuccess)
                    MessageBox.Show("Cannot update DonMuon");
                else
                    MessageBox.Show("Update DonMuon Successfully");
            }
        }

        //private async Task AddSachToCTDM()
        //{
        //    try
        //    {
        //        if (MaDG == null)
        //            MessageBox.Show("Vui lòng chọn thông tin mã độc giả", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
        //        else
        //        {
        //            bool isAddedToCTDM = false;
        //            if (TenDauSach != null && ISBN != null)
        //            {
        //                var newCTDM = new CTDM
        //                {
        //                    MaMuon = MaMuon,
        //                    MaDauSach = context.DauSachs.Where(t => t.TenDauSach == TenDauSach).Select(t => t.MaDauSach).FirstOrDefault().ToString(),
        //                    ISBN = ISBN
        //                };
        //                isAddedToCTDM = await _ctdmViewModel.AddCTDMToDatabaseAsync(newCTDM);

        //                if (!isAddedToCTDM)
        //                    MessageBox.Show("Cannot save changes to CTDM.");
        //                else
        //                {
        //                    DanhSachMuon.Add(new BorrowedBook
        //                    {
        //                        TenDauSach = TenDauSach,
        //                        ISBN = ISBN
        //                    });
        //                    OnPropertyChanged(nameof(DanhSachMuon));
        //                }
        //            }
        //        }
        //    }
        //    catch (DbUpdateException dbEx)
        //    {
        //        MessageBox.Show($"Database Update Error: {dbEx.Message}\nInner Exception: {dbEx.InnerException?.Message}");
        //    }
        //    catch (SqlException sqlEx)
        //    {
        //        MessageBox.Show($"SQL Error: {sqlEx.Message}\nError Code: {sqlEx.Number}");
        //    }
        //    catch (InvalidOperationException ex)
        //    {
        //        MessageBox.Show($"Invalid Operation: {ex.Message}");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Unexpected Error CTDM: {ex.Message}");
        //    }
        //}

        private async Task EditDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                // Here you would bind the selected object to edit mode, so changes reflect
                bool isSuccess = await UpdateDonMuonInDatabaseAsync(new DonMuon());
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
                    //DonMuonList.Remove(SelectedDonMuon);
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
        #endregion

        #region MethodToDatabase

        public async Task<bool> AddDonMuonToDatabaseAsync(DonMuon donMuon)
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

        public async Task<bool> UpdateDonMuonInDatabaseAsync(DonMuon donMuon)
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

        public async Task<bool> DeleteDonMuonFromDatabaseAsync(string maMuon)
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

        public async Task<List<DonMuon>> SearchDonMuonInDatabaseAsync(string keyword)
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

        public async Task<List<DonMuon>> GetAllDonMuonAsync()
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