using LibraryManagementApplication.Model.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class TaiKhoanViewModel : BaseViewModel
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Loai { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }

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
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public TaiKhoanViewModel()
        {
            TaiKhoanList = new ObservableCollection<TaiKhoan>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddTaiKhoan());
            EditCommand = new RelayCommand<object>((p) => SelectedTaiKhoan != null, async (p) => await EditTaiKhoan());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTaiKhoan != null, async (p) => await DeleteTaiKhoan());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchTaiKhoan(p));
            LoadTaiKhoanList();
        }

        private async void LoadTaiKhoanList()
        {
            var taiKhoans = await GetAllTaiKhoansAsync();
            foreach (var taiKhoan in taiKhoans)
            {
                TaiKhoanList.Add(taiKhoan);
            }
        }

        private async Task AddTaiKhoan()
        {
            TaiKhoan newTaiKhoan = new TaiKhoan()
            {
                UserID = UserID,
                UserName = UserName,
                Password = Password,
                Loai = Loai,
                Email = Email,
                SDT = SDT,
                CCCD = CCCD
            };

            bool isSuccess = await AddTaiKhoanToDatabaseAsync(newTaiKhoan);
            if (isSuccess)
            {
                TaiKhoanList.Add(newTaiKhoan); // Add to ObservableCollection only after DB operation succeeds
            }
            else
            {
                MessageBox.Show("Error adding Tai Khoan.");
            }
        }

        private async Task EditTaiKhoan()
        {
            if (SelectedTaiKhoan != null)
            {
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
                {
                    TaiKhoanList.Remove(SelectedTaiKhoan);
                }
                else
                {
                    MessageBox.Show("Error deleting Tai Khoan.");
                }
            }
        }

        private async Task SearchTaiKhoan(string keyword)
        {
            var filteredList = await SearchTaiKhoanInDatabaseAsync(keyword);
            TaiKhoanList.Clear();
            foreach (var taiKhoan in filteredList)
            {
                TaiKhoanList.Add(taiKhoan);
            }
        }

        #region MethodToDatabase

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