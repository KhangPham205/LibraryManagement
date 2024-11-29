using LibraryManagementApplication.Model.Class;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class SachViewModel : BaseViewModel
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string ISBN { get; set; }
        public string ViTri { get; set; }
        public string NgonNgu { get; set; }
        public string TrangThai { get; set; }
        public ObservableCollection<Sach> SachList { get; set; }
        private Sach _selectedSach;
        public Sach SelectedSach
        {
            get { return _selectedSach; }
            set
            {
                if (_selectedSach != value)
                {
                    _selectedSach = value;
                    OnPropertyChanged(nameof(SelectedSach));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public SachViewModel()
        {
            SachList = new ObservableCollection<Sach>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddSach());
            EditCommand = new RelayCommand<object>((p) => SelectedSach != null, async (p) => await EditSach());
            DeleteCommand = new RelayCommand<object>((p) => SelectedSach != null, async (p) => await DeleteSach());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchSach(p));

            LoadSachList();
        }

        private async void LoadSachList()
        {
            SachList.Clear();
            var sachs = await GetAllSachs();
            foreach (var sach in sachs)
            {
                SachList.Add(sach);
            }
        }

        private async Task AddSach()
        {
            Sach newSach = new Sach()
            {
                MaSach = "1",
                TenSach = TenSach,
                ISBN = ISBN,
                ViTri = ViTri,
                NgonNgu = NgonNgu,
                TrangThai = TrangThai 
            };
            SachList.Add(newSach);

            bool isSuccess = await AddSachToDatabase(newSach);
            if (!isSuccess)
            {
                // Handle failure (e.g. show error message to user)
            }
        }

        private async Task EditSach()
        {
            if (SelectedSach != null)
            {
                OnPropertyChanged(nameof(SelectedSach));

                bool isSuccess = await UpdateSachInDatabase(SelectedSach);
                if (!isSuccess)
                {
                    // Handle failure (e.g. show error message to user)
                }
            }
        }

        private async Task DeleteSach()
        {
            if (SelectedSach != null)
            {
                bool isSuccess = await DeleteSachFromDatabase(SelectedSach.MaSach);
                if (isSuccess)
                {
                    SachList.Remove(SelectedSach);
                }
                else
                {
                    // Handle failure (e.g. show error message to user)
                }
            }
        }

        private async Task SearchSach(string keyword)
        {
            var filteredListFromDb = await SearchSachInDatabase(keyword);
            SachList.Clear();
            foreach (var sach in filteredListFromDb)
            {
                SachList.Add(sach);
            }
        }

        #region MethodToDatabase
        public static async Task<bool> AddSachToDatabase(Sach sach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.Sachs.Add(sach);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding book: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateSachInDatabase(Sach sach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.Sachs.Update(sach);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating book: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteSachFromDatabase(string maSach)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var sachToDelete = await context.Sachs.FirstOrDefaultAsync(s => s.MaSach == maSach);
                    if (sachToDelete != null)
                    {
                        context.Sachs.Remove(sachToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting book: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<Sach>> SearchSachInDatabase(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.Sachs
                        .Where(s => s.TenSach.Contains(keyword))
                        .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching books: {ex.Message}");
                return new List<Sach>();
            }
        }

        public static async Task<List<Sach>> GetAllSachs()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.Sachs.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all books: {ex.Message}");
                return new List<Sach>();
            }
        }
        #endregion
    }
}