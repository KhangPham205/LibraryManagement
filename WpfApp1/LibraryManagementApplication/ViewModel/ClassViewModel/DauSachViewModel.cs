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
        private Random random = new Random();
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public string TenTG { get; set; }
        public string NgonNgu { get; set; }
        public string TenTL { get; set; }
        public string TenNXB { get; set; }
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
                }
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
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchDauSach(p));

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
            var newDauSach = new DauSach()
            {
                MaDauSach = "1",
                TenDauSach = TenDauSach,
                TenTG = TenTG,
                NgonNgu = NgonNgu,
                TenTL = TenTL,
                TenNXB = TenNXB,
            };
            MessageBox.Show(newDauSach.MaDauSach + " " + newDauSach.TenDauSach + " " + newDauSach.TenTL);
            bool isSuccess = await AddDauSachToDatabaseAsync(newDauSach);
            if (isSuccess)
            {
                DauSachList.Add(newDauSach);
            }
            else
            {
                MessageBox.Show("Cannot save changes.");
            }
        }

        private async Task EditDauSach()
        {
            if (SelectedDauSach != null)
            {
                bool isSuccess = await UpdateDauSachInDatabaseAsync(SelectedDauSach);
                if (!isSuccess)
                {
                    // Handle failure (e.g. show error message to user)
                }
            }
        }

        private async Task DeleteDauSach()
        {
            if (SelectedDauSach != null)
            {
                bool isSuccess = await DeleteDauSachFromDatabaseAsync(SelectedDauSach.MaDauSach);
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

        private async Task SearchDauSach(string keyword)
        {
            var filteredListFromDb = await SearchDauSachInDatabaseAsync(keyword);
            DauSachList.Clear();
            foreach (var DauSach in filteredListFromDb)
            {
                DauSachList.Add(DauSach);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddDauSachToDatabaseAsync(DauSach DauSach)
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

        public static async Task<bool> UpdateDauSachInDatabaseAsync(DauSach DauSach)
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

        public static async Task<bool> DeleteDauSachFromDatabaseAsync(string maDauSach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var DauSachToDelete = await context.DauSachs.FirstOrDefaultAsync(s => s.MaDauSach == maDauSach);
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

        public static async Task<List<DauSach>> SearchDauSachInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.DauSachs
                                              .Where(s => s.TenDauSach.Contains(keyword))
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching header books: {ex.Message}");
                return new List<DauSach>();
            }
        }

        public static async Task<List<DauSach>> GetAllDauSachsAsync()
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
