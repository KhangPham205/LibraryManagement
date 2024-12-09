using LibraryManagementApplication.Model.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class DauSachViewModel : BaseViewModel
    {
        private string maDauSach;
        private string tenDauSach;
        private string tenTG;
        private string ngonNgu;
        private string tenTL;
        private string tenNXB;
        public string MaDauSach 
        { 
            get => maDauSach;
            set 
            {
                if (maDauSach != value)
                {
                    maDauSach = value;
                    OnPropertyChanged();
                }
            } 
        }
        public string TenDauSach
        {
            get => tenDauSach;
            set
            {
                if (tenDauSach != value)
                {
                    tenDauSach = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TenTG
        {
            get => tenTG;
            set
            {
                if (tenTG != value)
                {
                    tenTG = value;
                    OnPropertyChanged();
                }
            }
        }
        public string NgonNgu
        {
            get => ngonNgu;
            set
            {
                if (ngonNgu != value)
                {
                    ngonNgu = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TenTL
        {
            get => tenTL;
            set
            {
                if (tenTL != value)
                {
                    tenTL = value;
                    OnPropertyChanged();
                }
            }
        }
        public string TenNXB
        {
            get => tenNXB;
            set
            {
                if (tenNXB != value)
                {
                    tenNXB = value;
                    OnPropertyChanged();
                }
            }
        }
        public ObservableCollection<DauSach> DauSachList { get; set; }
        private DauSach _selectedDauSach;
        public DauSach SelectedDauSach
        {
            get { return _selectedDauSach; }
            set 
            {
                if (_selectedDauSach != value)
                {
                    _selectedDauSach = value;
                    OnPropertyChanged(nameof(SelectedDauSach));
                    if (SelectedDauSach != null)
                    {
                        MaDauSach = SelectedDauSach.MaDauSach;
                        TenDauSach = SelectedDauSach.TenDauSach;
                        TenTG = SelectedDauSach.TenTG;
                        NgonNgu = SelectedDauSach.NgonNgu;
                        TenTL = SelectedDauSach.TenTL;
                        TenNXB = SelectedDauSach.TenNXB;
                    }
                }
            }
        }
        private async Task<string> CreateMaDSAsync(string TenDauSach)
        {
            // Generate a hash from TenTL
            using (var context = new LibraryDbContext())
            {
                // Lấy tất cả các mã "MaTL" hiện tại trong cơ sở dữ liệu có tiền tố "TL"
                var existingCodes = await context.DauSachs
                                                 .Where(tl => tl.MaDauSach.StartsWith("DS"))
                                                 .Select(tl => tl.MaDauSach)
                                                 .ToListAsync();

                int maxCodeNumber = existingCodes
                    .Select(code => int.TryParse(code.Substring(2), out int num) ? num : 0) // Lấy phần số sau "DS"
                    .DefaultIfEmpty(0) // Nếu không có mã nào, mặc định là 0
                    .Max(); // Lấy số lớn nhất trong danh sách mã

                // Tạo mã mới với số tăng dần
                int newCodeNumber = maxCodeNumber + 1;

                // Trả về mã mới với định dạng "DS" + số có 3 chữ số
                return $"DS{newCodeNumber:D3}";
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public DauSachViewModel()
        {
            DauSachList = new ObservableCollection<DauSach>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddDauSach());
            EditCommand = new RelayCommand<object>((p) => SelectedDauSach != null, async (p) => await EditDauSach());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDauSach != null, async (p) => await DeleteDauSach());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchDauSach());

            LoadDauSachList();
        }

        private async void LoadDauSachList()
        {
            DauSachList.Clear();
            var DauSachs = await GetAllDauSachsAsync();
            foreach (var DauSach in DauSachs)
            {
                DauSachList.Add(DauSach);
            }
        }

        private async Task AddDauSach()
        {
            if (!string.IsNullOrEmpty(TenDauSach) && !string.IsNullOrEmpty(TenTG) &&
                !string.IsNullOrEmpty(NgonNgu) &&
                !string.IsNullOrEmpty(TenTL) &&
                !string.IsNullOrEmpty(TenNXB))
            {
                bool exists = await IsDauSachExistsAsync(TenDauSach);
                if (exists)
                {
                    MessageBox.Show("Thể loại này đã tồn tại.");
                    return;
                }

                var newDauSach = new DauSach()
                {
                    MaDauSach = MaDauSach = await CreateMaDSAsync(TenDauSach),
                    TenDauSach = TenDauSach,
                    TenTG = TenTG,
                    NgonNgu = NgonNgu,
                    TenTL = TenTL,
                    TenNXB = TenNXB
                };
                //MessageBox.Show(newDauSach.MaDauSach + " " + newDauSach.TenDauSach + " " + newDauSach.TenTL);
                bool isSuccess = await AddDauSachToDatabaseAsync(newDauSach);
                if (isSuccess)
                    DauSachList.Add(newDauSach);
                else
                    MessageBox.Show("Cannot save changes.");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private async Task EditDauSach()
        {
            if (SelectedDauSach != null)
            {
                SelectedDauSach.MaDauSach = MaDauSach;
                SelectedDauSach.TenDauSach = TenDauSach;
                SelectedDauSach.TenTG = TenTG;
                SelectedDauSach.NgonNgu = NgonNgu;
                SelectedDauSach.TenTL = TenTL;
                SelectedDauSach.TenNXB = TenNXB;
                bool isSuccess = await UpdateDauSachInDatabaseAsync(SelectedDauSach);
                if (!isSuccess)
                {
                    MessageBox.Show("Cannot edit DauSach");
                }
                LoadDauSachList();
            }
        }

        private async Task DeleteDauSach()
        {
            if (SelectedDauSach != null)
            {
                bool isSuccess = await DeleteDauSachFromDatabaseAsync(SelectedDauSach);
                if (isSuccess)
                {
                    DauSachList.Remove(SelectedDauSach);
                }
                else
                {
                    // Handle failure (e.g. show error message to user)
                }
            }
        }

        private async Task SearchDauSach()
        {
            var filteredListFromDb = await SearchDauSachInDatabaseAsync(TenDauSach, TenTG, NgonNgu, TenTL, TenNXB);
            DauSachList.Clear();
            foreach (var DauSach in filteredListFromDb)
            {
                DauSachList.Add(DauSach);
            }
        }

        #region MethodToDatabase
        private static async Task<bool> IsDauSachExistsAsync(string tenDauSach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    // Chuyển cả hai về chữ thường trước khi so sánh
                    string normalizedTenDS = tenDauSach.ToLower();
                    return await context.DauSachs
                                        .AnyAsync(ds => ds.TenDauSach.ToLower() == normalizedTenDS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking existence of DauSach: {ex.Message}");
                return false;
            }
        }
        private static async Task<bool> AddDauSachToDatabaseAsync(DauSach DauSach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.DauSachs.Add(DauSach);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Error adding header book: {ex.InnerException?.Message ?? ex.Message}");
                return false;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        private static async Task<bool> UpdateDauSachInDatabaseAsync(DauSach DauSach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.DauSachs.Update(DauSach);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating header book: {ex.Message}");
                return false;
            }
        }
        private static async Task<bool> DeleteDauSachFromDatabaseAsync(DauSach dauSach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var DauSachToDelete = await context.DauSachs.FirstOrDefaultAsync(s => s == dauSach);
                    if (DauSachToDelete != null)
                    {
                        context.DauSachs.Remove(DauSachToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting header book: {ex.Message}");
                return false;
            }
        }
        private static async Task<List<DauSach>> SearchDauSachInDatabaseAsync(string tenDauSach, string tenTG, string ngonNgu, string tenTL, string nxb)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var query = context.DauSachs.AsQueryable();

                    // Áp dụng các điều kiện tìm kiếm, chỉ áp dụng nếu các tham số có giá trị.
                    if (!string.IsNullOrEmpty(tenDauSach))
                        query = query.Where(s => s.TenDauSach.Contains(tenDauSach));

                    if (!string.IsNullOrEmpty(tenTG))
                        query = query.Where(s => s.TenTG.Contains(tenTG));

                    if (!string.IsNullOrEmpty(ngonNgu))
                        query = query.Where(s => s.NgonNgu.Contains(ngonNgu));

                    if (!string.IsNullOrEmpty(tenTL))
                        query = query.Where(s => s.TenTL.Contains(tenTL));

                    if (!string.IsNullOrEmpty(nxb))
                        query = query.Where(s => s.TenNXB.Contains(nxb));

                    var result = await query.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching header books: {ex.Message}");
                return new List<DauSach>();
            }
        }
        private static async Task<List<DauSach>> GetAllDauSachsAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.DauSachs.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all dau sach: {ex.Message}");
                return new List<DauSach>();
            }
        }

        #endregion
    }
}
