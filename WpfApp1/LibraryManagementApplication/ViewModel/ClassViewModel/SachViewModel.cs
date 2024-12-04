﻿using LibraryManagementApplication.Model.Class;
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
    public class SachViewModel : BaseViewModel
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string ISBN { get; set; }
        public string ViTri { get; set; }
        public string NgonNgu { get; set; }
        public string TrangThai { get; set; }
        public string TenTG { get; set; }
        public string TheLoai { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
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
            var sachs = await GetAllSachsAsync();
            foreach (var sach in sachs)
            {
                SachList.Add(sach);
            }
        }

        private async Task AddSach()
        {
            var newSach = new Sach()
            {
                MaSach = "1", // You might want to generate a unique ID
                TenSach = TenSach,
                ISBN = ISBN,
                ViTri = ViTri,
                NgonNgu = NgonNgu,
                TrangThai = TrangThai,
                TenTG = TenTG,
                NhaXuatBan = NhaXuatBan,
                NamXuatBan = NamXuatBan
            };
            SachList.Add(newSach);

            bool isSuccess = await AddSachToDatabaseAsync(newSach);
            if (!isSuccess)
            {
                MessageBox.Show("Cannot save changes.");
            }
        }

        private async Task EditSach()
        {
            if (SelectedSach != null)
            {
                bool isSuccess = await UpdateSachInDatabaseAsync(SelectedSach);
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
                bool isSuccess = await DeleteSachFromDatabaseAsync(SelectedSach.MaSach);
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
            var filteredListFromDb = await SearchSachInDatabaseAsync(keyword);
            SachList.Clear();
            foreach (var sach in filteredListFromDb)
            {
                SachList.Add(sach);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddSachToDatabaseAsync(Sach sach)
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
                MessageBox.Show($"Error adding book: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateSachInDatabaseAsync(Sach sach)
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
                MessageBox.Show($"Error updating book: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteSachFromDatabaseAsync(string maSach)
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
                MessageBox.Show($"Error deleting book: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<Sach>> SearchSachInDatabaseAsync(string keyword)
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
                MessageBox.Show($"Error searching books: {ex.Message}");
                return new List<Sach>();
            }
        }

        public static async Task<List<Sach>> GetAllSachsAsync()
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
                MessageBox.Show($"Error getting all books: {ex.Message}");
                return new List<Sach>();
            }
        }

        #endregion
    }
}