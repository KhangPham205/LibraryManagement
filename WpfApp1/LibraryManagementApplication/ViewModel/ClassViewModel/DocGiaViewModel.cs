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
    public class DocGiaViewModel : BaseViewModel
    {
        public string MaDG { get; set; }
        public string TenDG { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public ObservableCollection<DocGia> DocGiaList { get; set; }
        private DocGia _selectedDocGia;
        public DocGia SelectedDocGia
        {
            get { return _selectedDocGia; }
            set
            {
                if (_selectedDocGia != value)
                {
                    _selectedDocGia = value;
                    OnPropertyChanged(nameof(SelectedDocGia));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public DocGiaViewModel()
        {
            DocGiaList = new ObservableCollection<DocGia>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddDocGia());
            EditCommand = new RelayCommand<object>((p) => SelectedDocGia != null, async (p) => await EditDocGia());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDocGia != null, async (p) => await DeleteDocGia());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchDocGia(p));

            LoadDocGiaList();
        }

        private async void LoadDocGiaList()
        {
            var docGias = await GetAllDocGiasAsync();
            foreach (var docGia in docGias)
            {
                DocGiaList.Add(docGia);
            }
        }

        private async Task AddDocGia()
        {
            var newDocGia = new DocGia()
            {
                MaDG = MaDG,
                TenDG = TenDG,
                Email = Email,
                CCCD = CCCD
            };
            DocGiaList.Add(newDocGia);

            bool isSuccess = await AddDocGiaToDatabaseAsync(newDocGia);
            if (!isSuccess)
            {
                MessageBox.Show("Cannot save changes.");
            }
        }

        private async Task EditDocGia()
        {
            if (SelectedDocGia != null)
            {
                // Here you can implement logic for editing the selected DocGia.
                // Using data binding to automatically reflect changes in the UI
                bool isSuccess = await UpdateDocGiaInDatabaseAsync(SelectedDocGia);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating the record.");
                }
            }
        }

        private async Task DeleteDocGia()
        {
            if (SelectedDocGia != null)
            {
                bool isSuccess = await DeleteDocGiaFromDatabaseAsync(SelectedDocGia.MaDG);
                if (isSuccess)
                {
                    DocGiaList.Remove(SelectedDocGia);
                }
                else
                {
                    MessageBox.Show("Error deleting the record.");
                }
            }
        }

        private async Task SearchDocGia(string keyword)
        {
            var filteredList = await SearchDocGiaInDatabaseAsync(keyword);
            DocGiaList.Clear();
            foreach (var docGia in filteredList)
            {
                DocGiaList.Add(docGia);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddDocGiaToDatabaseAsync(DocGia docGia)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.DocGias.Add(docGia);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding DocGia: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateDocGiaInDatabaseAsync(DocGia docGia)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.DocGias.Update(docGia);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating DocGia: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteDocGiaFromDatabaseAsync(string maDG)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var docGiaToDelete = await context.DocGias.FirstOrDefaultAsync(dg => dg.MaDG == maDG);
                    if (docGiaToDelete != null)
                    {
                        context.DocGias.Remove(docGiaToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting DocGia: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<DocGia>> SearchDocGiaInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.DocGias
                                              .Where(dg => dg.TenDG.Contains(keyword) || dg.MaDG.Contains(keyword))
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching DocGia: {ex.Message}");
                return new List<DocGia>();
            }
        }

        public static async Task<List<DocGia>> GetAllDocGiasAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.DocGias.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error getting all DocGia: {ex.Message}");
                return new List<DocGia>();
            }
        }

        #endregion
    }
}