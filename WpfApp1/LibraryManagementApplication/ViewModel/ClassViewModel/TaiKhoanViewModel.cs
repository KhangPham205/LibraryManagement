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

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class TaiKhoanViewModel : BaseViewModel
    {
        private string userName;
        private string password;
        private string email;
        private string sdt;
        private string cccd;
        public string UserName
        {
            get => userName;
            set
            {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged();
                }
            }
        }
        public string SDT
        {
            get => sdt;
            set
            {
                if (sdt != value)
                {
                    sdt = value;
                    OnPropertyChanged();
                }
            }
        }
        public string CCCD
        {
            get => cccd;
            set
            {
                if (cccd != value)
                {
                    cccd = value;
                    OnPropertyChanged();
                }
            }
        }
        // Mật khẩu mới
        private string newPassWord;
        public string NewPassWord
        {
            get => newPassWord;
            set
            {
                if (newPassWord != value)
                {
                    newPassWord = value; 
                    OnPropertyChanged();
                }
            }
        }
        private string newPassWord2;
        public string NewPassWord2
        {
            get => newPassWord2;
            set
            {
                if (newPassWord2 != value)
                {
                    newPassWord2 = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool IsAdded;
        public ObservableCollection<TaiKhoan> TaiKhoanList { get; set; }
        private TaiKhoan _selectedTaiKhoan;

        public TaiKhoan SelectedTaiKhoan
        {
            get { return _selectedTaiKhoan; }
            set
            {
                if (_selectedTaiKhoan != value)
                {
                    _selectedTaiKhoan = value;
                    OnPropertyChanged(nameof(SelectedTaiKhoan));
                    if (SelectedTaiKhoan != null)
                    {
                        UserName = SelectedTaiKhoan.UserName;
                        Password = SelectedTaiKhoan.Password;
                        Email = SelectedTaiKhoan.Email;
                        SDT = SelectedTaiKhoan.SDT;
                        CCCD = SelectedTaiKhoan.CCCD;
                    }
                }
            }
        }
        private async Task<string> CreateMaNVAsync()
        {
            // Generate a hash from TenTL
            using (var context = new LibraryDbContext())
            {
                // Lấy tất cả các mã UserID hiện tại trong cơ sở dữ liệu có tiền tố "NV"
                var existingCodes = await context.TaiKhoans
                                                 .Where(tl => tl.UserID.StartsWith("NV"))
                                                 .Select(tl => tl.UserID)
                                                 .ToListAsync();

                var minUnusedNumber = existingCodes
                    .Select(code => int.TryParse(code.Substring(2), out int num) ? num : 0) // Lấy phần số sau "NV"
                    .OrderBy(number => number) // Sắp xếp tăng dần
                    .ToList(); // Lấy số lớn nhất trong danh sách mã

                // Tạo mã mới với số tăng dần
                int newCodeNumber = 1;
                foreach (var number in minUnusedNumber)
                {
                    if (number != newCodeNumber)
                    {
                        break; // Nếu phát hiện khoảng trống
                    }
                    newCodeNumber++;
                }

                // Trả về mã mới với định dạng "NV" + số có 3 chữ số
                return $"NV{newCodeNumber:D3}";
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ShowCommand { get; set; }
        public ICommand ChangePasswordCommand { get; set; }

        public TaiKhoanViewModel()
        {
            TaiKhoanList = new ObservableCollection<TaiKhoan>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddTaiKhoan());
            EditCommand = new RelayCommand<object>((p) => SelectedTaiKhoan != null, async (p) => await EditTaiKhoan());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTaiKhoan != null, async (p) => await DeleteTaiKhoan());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchTaiKhoan());
            ShowCommand = new RelayCommand<DataGrid>((p) => true, (p) => ShowTaiKhoan());
            ChangePasswordCommand = new RelayCommand<DataGrid>((p) => true, async (p) => await ChangePassWord());

            LoadTaiKhoanList();
        }

        private async void LoadTaiKhoanList()
        {
            TaiKhoanList.Clear();
            var taiKhoans = await GetAllTaiKhoansAsync();
            foreach (var taiKhoan in taiKhoans)
            {
                TaiKhoanList.Add(taiKhoan);
            }
        }

        private async Task<bool> AddTaiKhoan()
        {
            if (!string.IsNullOrEmpty(UserName) && 
                !string.IsNullOrEmpty(Password) && 
                !string.IsNullOrEmpty(Email) && 
                !string.IsNullOrEmpty(SDT) && 
                !string.IsNullOrEmpty(CCCD))
            {
                bool exists = await IsTaiKhoanExistsAsync(CCCD, Email);
                if (exists)
                {
                    MessageBox.Show("Nhân viên với email hoặc căn cước công dân đã được sử dụng.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }

                TaiKhoan newTaiKhoan = new TaiKhoan()
                {
                    UserID = await CreateMaNVAsync(),
                    UserName = UserName,
                    Password = Password,
                    Loai = "NV",
                    Email = Email,
                    SDT = SDT,
                    CCCD = CCCD
                };

                bool isSuccess = await AddTaiKhoanToDatabaseAsync(newTaiKhoan);
                IsAdded = isSuccess;
                if (isSuccess)
                    TaiKhoanList.Add(newTaiKhoan);
                else
                    MessageBox.Show("Error adding Tai Khoan.");
                return isSuccess;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Cảnh báo", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }    
        }

        private async Task EditTaiKhoan()
        {
            if (SelectedTaiKhoan != null)
            {
                SelectedTaiKhoan.UserName = UserName;
                SelectedTaiKhoan.Password = Password;
                SelectedTaiKhoan.SDT = SDT;
                SelectedTaiKhoan.Email = Email;
                SelectedTaiKhoan.CCCD = CCCD;
                bool isSuccess = await UpdateTaiKhoanInDatabaseAsync(SelectedTaiKhoan);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating Tai Khoan.");
                }
            }
        }

        private async Task DeleteTaiKhoan()
        {
            if (SelectedTaiKhoan != null)
            {
                bool isSuccess = await DeleteTaiKhoanFromDatabaseAsync(SelectedTaiKhoan.UserID);
                if (isSuccess)
                    TaiKhoanList.Remove(SelectedTaiKhoan);
                else
                    MessageBox.Show("Error deleting Tai Khoan.");
            }
        }

        private async Task SearchTaiKhoan()
        {
            var filteredList = await SearchTaiKhoanInDatabaseAsync(UserName);
            TaiKhoanList.Clear();
            foreach (var taiKhoan in filteredList)
            {
                TaiKhoanList.Add(taiKhoan);
            }
        }
        private void ShowTaiKhoan()
        {
            LoadTaiKhoanList();
        }
        private async Task ChangePassWord()
        {
            if (!string.IsNullOrEmpty(Password) &&
                !string.IsNullOrEmpty(NewPassWord) &&
                !string.IsNullOrEmpty(NewPassWord2) &&
                NewPassWord.Equals(NewPassWord2))
            {
                using (var context = new LibraryDbContext())
                {
                    TaiKhoan taiKhoan = context.TaiKhoans.Where(tk => tk.SDT == SDT && tk.Email == Email && tk.CCCD == CCCD && tk.Password == Password).FirstOrDefault();
                    if (taiKhoan != null)
                    {
                        taiKhoan.Password = NewPassWord;
                        bool isSuccess = await UpdateTaiKhoanInDatabaseAsync(taiKhoan);
                        if (!isSuccess)
                            MessageBox.Show("Error updating Tai Khoan.");
                        else
                            MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                        MessageBox.Show("Mật khẩu cũ sai hoặc thông tin không trùng khớp", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
                MessageBox.Show("Vui lòng điền lại mật khẩu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        #region MethodToDatabase
        private static async Task<bool> IsTaiKhoanExistsAsync(string cccd, string email)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    // Kiểm tra xem có tồn tại tài khoản với CCCD hoặc email đã sử dụng hay không
                    return await context.TaiKhoans
                        .AnyAsync(tk => tk.CCCD == cccd ||
                                        tk.Email.ToLower() == email.ToLower());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking existence of Tai Khoan: {ex.Message}");
                return false;
            }
        }
        public static async Task<bool> AddTaiKhoanToDatabaseAsync(TaiKhoan taiKhoan)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.TaiKhoans.Add(taiKhoan);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Tai khoan: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateTaiKhoanInDatabaseAsync(TaiKhoan taiKhoan)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.TaiKhoans.Update(taiKhoan);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Tai khoan: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteTaiKhoanFromDatabaseAsync(string userID)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var taiKhoanToDelete = await context.TaiKhoans.FirstOrDefaultAsync(s => s.UserID == userID);
                    if (taiKhoanToDelete != null)
                    {
                        context.TaiKhoans.Remove(taiKhoanToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Tai khoan: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<TaiKhoan>> SearchTaiKhoanInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.TaiKhoans
                                              .Where(s => s.UserName.Contains(keyword)) // Filtering by UserName
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching Tai khoan: {ex.Message}");
                return new List<TaiKhoan>();
            }
        }

        public static async Task<List<TaiKhoan>> GetAllTaiKhoansAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.TaiKhoans.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all Tai khoan: {ex.Message}");
                return new List<TaiKhoan>();
            }
        }

        #endregion
    }
}