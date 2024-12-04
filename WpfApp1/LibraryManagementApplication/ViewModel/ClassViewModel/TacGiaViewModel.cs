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
    public class TacGiaViewModel : BaseViewModel
    {
        public string MaTG { get; set; }
        public string TenTG { get; set; }
        public ObservableCollection<TacGia> TacGiaList { get; set; }
        private TacGia _selectedTacGia;
        public TacGia SelectedTacGia
        {
            get { return _selectedTacGia; }
            set
            {
                if (_selectedTacGia != value)
                {
                    _selectedTacGia = value;
                    OnPropertyChanged(nameof(SelectedTacGia));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public TacGiaViewModel()
        {
            TacGiaList = new ObservableCollection<TacGia>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddTacGia());
            EditCommand = new RelayCommand<object>((p) => SelectedTacGia != null, async (p) => await EditTacGia());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTacGia != null, async (p) => await DeleteTacGia());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchTacGia(p));
            LoadTacGiaList();
        }

        private async void LoadTacGiaList()
        {
            var tacGias = await GetAllTacGiasAsync();
            foreach (var tacGia in tacGias)
            {
                TacGiaList.Add(tacGia);
            }
        }

        private async Task AddTacGia()
        {
            TacGia newTacGia = new TacGia()
            {
                MaTG = MaTG,  // Assume MaTG and TenTG are set from UI input.
                TenTG = TenTG
            };


            bool isSuccess = await AddTacGiaToDatabaseAsync(newTacGia); // Persist to DB
            if (!isSuccess)
            {
                MessageBox.Show("Cannot save changes.");
            }
            else
            {
                TacGiaList.Add(newTacGia);
            }
        }

        private async Task EditTacGia()
        {
            if (SelectedTacGia != null)
            {
                // Update the selected TacGia in the database
                bool isSuccess = await UpdateTacGiaInDatabaseAsync(SelectedTacGia);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating the record.");
                }
            }
        }

        private async Task DeleteTacGia()
        {
            if (SelectedTacGia != null)
            {
                bool isSuccess = await DeleteTacGiaFromDatabaseAsync(SelectedTacGia.MaTG);
                if (isSuccess)
                {
                    TacGiaList.Remove(SelectedTacGia);
                }
                else
                {
                    MessageBox.Show("Error deleting the record.");
                }
            }
        }

        private async Task SearchTacGia(string keyword)
        {
            var filteredList = await SearchTacGiaInDatabaseAsync(keyword);
            TacGiaList.Clear();
            foreach (var tacGia in filteredList)
            {
                TacGiaList.Add(tacGia);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddTacGiaToDatabaseAsync(TacGia tacGia)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.TacGias.Add(tacGia);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Tac gia: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateTacGiaInDatabaseAsync(TacGia tacGia)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.TacGias.Update(tacGia);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Tac gia: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteTacGiaFromDatabaseAsync(string maTG)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var tacGiaToDelete = await context.TacGias.FirstOrDefaultAsync(s => s.MaTG == maTG);
                    if (tacGiaToDelete != null)
                    {
                        context.TacGias.Remove(tacGiaToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting Tac gia: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<TacGia>> SearchTacGiaInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.TacGias
                                              .Where(s => s.TenTG.Contains(keyword))
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching Tac gia: {ex.Message}");
                return new List<TacGia>();
            }
        }

        /*public static async Task<List<TacGia>> GetAllTacGiasAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.TacGias.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all Tac gia: {ex.Message}");
                return new List<TacGia>();
            }
        }*/

        #endregion
    }
}