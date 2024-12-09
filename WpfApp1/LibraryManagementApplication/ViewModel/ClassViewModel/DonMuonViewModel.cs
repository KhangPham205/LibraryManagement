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
    public class DonMuonViewModel : BaseViewModel
    {
        public string MaMuon { get; set; }
        public string MaDG { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTraDK { get; set; }
        public DateTime NgayTraTT { get; set; }
        public decimal PhiPhat { get; set; }
        public ObservableCollection<DonMuon> DonMuonList { get; set; }
        private DonMuon _selectedDonMuon;
        public DonMuon SelectedDonMuon
        {
            get { return _selectedDonMuon; }
            set
            {
                if (_selectedDonMuon != value)
                {
                    _selectedDonMuon = value;
                    OnPropertyChanged(nameof(SelectedDonMuon));
                }
            }
        }
        public Page page { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand moveCommand { get; set; }
        public ICommand backCommand { get; set; }

        public DonMuonViewModel()
        {
            DonMuonList = new ObservableCollection<DonMuon>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddDonMuon());
            EditCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await EditDonMuon());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, async (p) => await DeleteDonMuon());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchDonMuon(p));
            moveCommand = new RelayCommand<object>((p) => true, (p) => { page = new addborrow(); });
            backCommand = new RelayCommand<object>((p) => true, (p) => { page = new borrowinfo(); });
            LoadDonMuonList();
        }

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
                MaMuon = MaMuon,
                MaDG = MaDG,
                NgayMuon = DateTime.Now,
                NgayTraDK = DateTime.Now.AddDays(7),
                NgayTraTT = DateTime.MinValue,
                PhiPhat = 0
            };

            DonMuonList.Add(newDonMuon);

            bool isSuccess = await AddDonMuonToDatabaseAsync(newDonMuon);
            if (!isSuccess)
            {
                MessageBox.Show("Cannot save changes.");
            }
        }

        private async Task EditDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                // Here you would bind the selected object to edit mode, so changes reflect
                bool isSuccess = await UpdateDonMuonInDatabaseAsync(SelectedDonMuon);
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
                    DonMuonList.Remove(SelectedDonMuon);
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

        #region MethodToDatabase

        public static async Task<bool> AddDonMuonToDatabaseAsync(DonMuon donMuon)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding DonMuon: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateDonMuonInDatabaseAsync(DonMuon donMuon)
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

        public static async Task<bool> DeleteDonMuonFromDatabaseAsync(string maMuon)
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

        public static async Task<List<DonMuon>> SearchDonMuonInDatabaseAsync(string keyword)
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

        public static async Task<List<DonMuon>> GetAllDonMuonAsync()
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
                MessageBox.Show($"Error getting all DonMuon: {ex.Message}");
                return new List<DonMuon>();
            }
        }

        #endregion
    }
}