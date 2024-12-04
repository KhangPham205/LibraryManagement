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
    public class NhaXuatBanViewModel : BaseViewModel
    {
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }
        public ObservableCollection<NhaXuatBan> NhaXuatBanList { get; set; }
        private NhaXuatBan _selectedNhaXuatBan;
        public NhaXuatBan SelectedNhaXuatBan
        {
            get { return _selectedNhaXuatBan; }
            set
            {
                if (_selectedNhaXuatBan != value)
                {
                    _selectedNhaXuatBan = value;
                    OnPropertyChanged(nameof(SelectedNhaXuatBan));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public NhaXuatBanViewModel()
        {
            NhaXuatBanList = new ObservableCollection<NhaXuatBan>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddNhaXuatBan());
            EditCommand = new RelayCommand<object>((p) => SelectedNhaXuatBan != null, async (p) => await EditNhaXuatBan());
            DeleteCommand = new RelayCommand<object>((p) => SelectedNhaXuatBan != null, async (p) => await DeleteNhaXuatBan());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchNhaXuatBan(p));

            // Load data (or simulate loading data from database)
            LoadNhaXuatBanList();
        }

        private async void LoadNhaXuatBanList()
        {
            var nhaXuatBans = await GetAllNhaXuatBanAsync();
            foreach (var nxb in nhaXuatBans)
            {
                NhaXuatBanList.Add(nxb);
            }
        }

        private async Task AddNhaXuatBan()
        {
            NhaXuatBan newNhaXuatBan = new NhaXuatBan()
            {
                MaNXB = MaNXB,
                TenNXB = TenNXB,
            };

            NhaXuatBanList.Add(newNhaXuatBan);

            bool isSuccess = await AddNhaXuatBanToDatabaseAsync(newNhaXuatBan);
            if (!isSuccess)
            {
                MessageBox.Show("Cannot save changes.");
            }
        }

        private async Task EditNhaXuatBan()
        {
            if (SelectedNhaXuatBan != null)
            {
                // Here you would bind the selected object to edit mode, so changes reflect
                bool isSuccess = await UpdateNhaXuatBanInDatabaseAsync(SelectedNhaXuatBan);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating the record.");
                }
            }
        }

        private async Task DeleteNhaXuatBan()
        {
            if (SelectedNhaXuatBan != null)
            {
                bool isSuccess = await DeleteNhaXuatBanFromDatabaseAsync(SelectedNhaXuatBan.MaNXB);
                if (isSuccess)
                {
                    NhaXuatBanList.Remove(SelectedNhaXuatBan);
                }
                else
                {
                    MessageBox.Show("Error deleting the record.");
                }
            }
        }

        private async Task SearchNhaXuatBan(string keyword)
        {
            var filteredList = await SearchNhaXuatBanInDatabaseAsync(keyword);
            NhaXuatBanList.Clear();
            foreach (var donMuon in filteredList)
            {
                NhaXuatBanList.Add(donMuon);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddNhaXuatBanToDatabaseAsync(NhaXuatBan nhaXuatBan)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.NhaXuatBans.Add(nhaXuatBan);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding Nha Xuat ban: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateNhaXuatBanInDatabaseAsync(NhaXuatBan nhaXuatBan)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.NhaXuatBans.Update(nhaXuatBan);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating Nha xuat ban: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteNhaXuatBanFromDatabaseAsync(string maNXB)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var nhaXuatBanToDelete = await context.NhaXuatBans.FirstOrDefaultAsync(nxb => nxb.MaNXB == maNXB);
                    if (nhaXuatBanToDelete != null)
                    {
                        context.NhaXuatBans.Remove(nhaXuatBanToDelete);
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

        public static async Task<List<NhaXuatBan>> SearchNhaXuatBanInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.NhaXuatBans
                                              .Where(nxb => nxb.MaNXB.Contains(keyword))
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching DonMuon: {ex.Message}");
                return new List<NhaXuatBan>();
            }
        }

        /*public static async Task<List<NhaXuatBan>> GetAllNhaXuatBanAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.NhaXuatBans.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all DonMuon: {ex.Message}");
                return new List<NhaXuatBan>();
            }
        }*/

        #endregion
    }
}