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
    public class CTDMViewModel : BaseViewModel
    {
        public string MaMuon { get; set; }
        public string MaSach { get; set; }
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

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public CTDMViewModel()
        {
            CTDMList = new ObservableCollection<CTDM>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddCTDM());
            EditCommand = new RelayCommand<object>((p) => SelectedCTDM != null, async (p) => await EditCTDM());
            DeleteCommand = new RelayCommand<object>((p) => SelectedCTDM != null, async (p) => await DeleteCTDM());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchCTDM(p));

            LoadCTDMList();
        }

        private async void LoadCTDMList()
        {
            CTDMList.Clear();
            var ctdms = await GetAllCTDMsAsync();
            foreach (var ctdm in ctdms)
            {
                CTDMList.Add(ctdm);
            }
        }

        private async Task AddCTDM()
        {
            var newCTDM = new CTDM()
            {
                MaMuon = MaMuon,
                MaSach = MaSach
            };
            CTDMList.Add(newCTDM);

            bool isSuccess = await AddCTDMToDatabaseAsync(newCTDM);
            if (!isSuccess)
            {
                MessageBox.Show("Cannot save changes.");
            }
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

        private async Task DeleteCTDM()
        {
            if (SelectedCTDM != null)
            {
                bool isSuccess = await DeleteCTDMFromDatabaseAsync(SelectedCTDM.MaMuon);
                if (isSuccess)
                {
                    CTDMList.Remove(SelectedCTDM);
                }
                else
                {
                    MessageBox.Show("Error deleting the record.");
                }
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

        public static async Task<bool> AddCTDMToDatabaseAsync(CTDM ctdm)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding CTDM: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateCTDMInDatabaseAsync(CTDM ctdm)
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

        public static async Task<bool> DeleteCTDMFromDatabaseAsync(string maMuon)
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

        public static async Task<List<CTDM>> SearchCTDMInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.CTDMs
                                              .Where(s => s.MaMuon.Contains(keyword) || s.MaSach.Contains(keyword))
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

        public static async Task<List<CTDM>> GetAllCTDMsAsync()
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
