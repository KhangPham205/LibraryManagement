using LibraryManagementApplication.Model.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class CTDMViewModel : BaseViewModel
    {
        private LibraryDbContext context;
        public string MaDG {  get; set; }
        public string TenDauSach {  get; set; }
        public string MaMuon { get; set; }
        public string MaDauSach { get; set; }
        public string ISBN { get; set; }
        private ObservableCollection<BorrowedBook> danhSachMuon;
        public ObservableCollection<BorrowedBook> DanhSachMuon
        {
            get => danhSachMuon;
            set
            {
                if (danhSachMuon != value)
                {
                    danhSachMuon = value;
                    OnPropertyChanged();
                }
            }
        }
        private BorrowedBook _selectedBorrowedBook;
        public BorrowedBook SelectedBorrowedBook
        {
            get { return _selectedBorrowedBook; }
            set
            {
                if (_selectedBorrowedBook != value)
                {
                    _selectedBorrowedBook = value;
                    OnPropertyChanged(nameof(SelectedBorrowedBook));
                }
            }
        }
        public ObservableCollection<CTDM> CTDMList { get; set; }
        private CTDM _selectedCTDM;
        public CTDM SelectedCTDM
        {
            get { return _selectedCTDM; }
            set
            {
                if (_selectedCTDM != value)
                {
                    _selectedCTDM = value;
                    OnPropertyChanged(nameof(SelectedCTDM));
                }
            }
        }
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

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand CreateCommand { get; set; }

        public CTDMViewModel()
        {
            context = new LibraryDbContext();
            danhSachMuon = new ObservableCollection<BorrowedBook>();
            InitializeMaMuonAsync(); // Initialize MaMuon asynchronously

            CTDMList = new ObservableCollection<CTDM>();
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddCTDM());
            EditCommand = new RelayCommand<object>((p) => SelectedCTDM != null, async (p) => await EditCTDM());
            DeleteCommand = new RelayCommand<object>((p) => SelectedBorrowedBook != null, (p) => DeleteCTDM());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchCTDM(p));
            CreateCommand = new RelayCommand<object>((p) => true, (p) => AddNewDonMuonAndCTDM());
        }

        private async void InitializeMaMuonAsync()
        {
            MaMuon = await CreateMaDMAsync();
        }

        //private async void LoadCTDMList()
        //{
        //    CTDMList.Clear();
        //    var ctdms = await GetAllCTDMsAsync();
        //    foreach (var ctdm in ctdms)
        //    {
        //        CTDMList.Add(ctdm);
        //    }
        //}

        private async void AddNewDonMuonAndCTDM()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    // Thêm mới DonMuon
                    var newDonMuon = new DonMuon()
                    {
                        MaMuon = MaMuon,
                        MaDG = MaDG,
                        MaNV = GlobalData.LoginUser.UserID,
                        NgayMuon = DateTime.Now,
                        NgayTraDK = DateTime.Now.AddMonths(1),
                        NgayTraTT = null,
                        PhiPhat = 0
                    };
                    context.DonMuons.Add(newDonMuon);

                    // Thêm mới CTDM
                    foreach (var item in danhSachMuon)
                    {
                        var maDauSach = context.DauSachs
                                               .Where(t => t.TenDauSach == item.TenDauSach)
                                               .Select(t => t.MaDauSach)
                                               .FirstOrDefault();

                        var ctdm = new CTDM()
                        {
                            MaMuon = MaMuon,
                            MaDauSach = maDauSach,
                            ISBN = item.ISBN,
                        };
                        context.CTDMs.Add(ctdm);
                    }

                    // Lưu thay đổi vào cơ sở dữ liệu
                    await context.SaveChangesAsync();
                }
                MessageBox.Show("Thêm đơn mượn và chi tiết đơn mượn thành công!");
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Database Update Error: {dbEx.Message}\nInner Exception: {dbEx.InnerException?.Message}");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Error: {sqlEx.Message}\nError Code: {sqlEx.Number}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected Error: {ex.Message}");
            }
        }


        private void AddCTDM()
        {
            // Kiểm tra xem sách và ISBN đã tồn tại trong danh sách chưa
            var existingBook = danhSachMuon.FirstOrDefault(book => book.TenDauSach == TenDauSach && book.ISBN == ISBN);

            if (existingBook != null)
            {
                // Hiển thị thông báo nếu đã tồn tại
                MessageBox.Show("Sách với tên và ISBN này đã tồn tại trong danh sách mượn!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Nếu không tồn tại, thêm mới vào danh sách
            var newBorrowedBook = new BorrowedBook()
            {
                TenDauSach = TenDauSach,
                ISBN = ISBN
            };
            danhSachMuon.Add(newBorrowedBook);
        }

        private async Task EditCTDM()
        {
            if (SelectedCTDM != null)
            {
                // You can use binding to edit the selected CTDM, no need to call OnPropertyChanged here
                bool isSuccess = await UpdateCTDMInDatabaseAsync(SelectedCTDM);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating the record.");
                }
            }
        }

        private void DeleteCTDM()
        {
            if (SelectedBorrowedBook != null)
            {
                // Xóa phần tử được chọn khỏi danh sách
                DanhSachMuon.Remove(SelectedBorrowedBook);

                // Hiển thị thông báo
                MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                // Thông báo nếu không có sách nào được chọn
                MessageBox.Show("Vui lòng chọn sách để xóa!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        private async Task SearchCTDM(string keyword)
        {
            var filteredList = await SearchCTDMInDatabaseAsync(keyword);
            CTDMList.Clear();
            foreach (var ctdm in filteredList)
            {
                CTDMList.Add(ctdm);
            }
        }

        #region MethodToDatabase

        public async Task<bool> AddCTDMToDatabaseAsync(CTDM ctdm)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.CTDMs.Add(ctdm);
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
                MessageBox.Show($"Unexpected Error CTDM: {ex.Message}");
            }
            return false;
        }

        public async Task<bool> UpdateCTDMInDatabaseAsync(CTDM ctdm)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.CTDMs.Update(ctdm);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating CTDM: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteCTDMFromDatabaseAsync(string maMuon)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var ctdmToDelete = await context.CTDMs.FirstOrDefaultAsync(s => s.MaMuon == maMuon);
                    if (ctdmToDelete != null)
                    {
                        context.CTDMs.Remove(ctdmToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting CTDM: {ex.Message}");
                return false;
            }
        }

        public async Task<List<CTDM>> SearchCTDMInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.CTDMs
                                              .Where(s => s.MaMuon.Contains(keyword) || s.MaDauSach.Contains(keyword))
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching CTDM: {ex.Message}");
                return new List<CTDM>();
            }
        }

        public async Task<List<CTDM>> GetAllCTDMsAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.CTDMs.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all CTDM: {ex.Message}");
                return new List<CTDM>();
            }
        }

        #endregion
    }
}
