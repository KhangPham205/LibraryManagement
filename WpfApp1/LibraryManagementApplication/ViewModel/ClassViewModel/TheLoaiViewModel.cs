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
    public class TheLoaiViewModel : BaseViewModel
    {
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public ObservableCollection<TheLoai> TheLoaiList { get; set; }
        private TheLoai _selectedTheLoai;

        public TheLoai SelectedTheLoai
        {
            get { return _selectedTheLoai; }
            set
            {
                if (_selectedTheLoai != value)
                {
                    _selectedTheLoai = value;
                    OnPropertyChanged(nameof(SelectedTheLoai));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public TheLoaiViewModel()
        {
            TheLoaiList = new ObservableCollection<TheLoai>();
            AddCommand = new RelayCommand<object>((p) => true, async (p) => await AddTheLoai());
            EditCommand = new RelayCommand<object>((p) => SelectedTheLoai != null, async (p) => await EditTheLoai());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTheLoai != null, async (p) => await DeleteTheLoai());
            SearchCommand = new RelayCommand<string>((p) => true, async (p) => await SearchTheLoai(p));
            LoadTheLoaiList();
        }

        private async void LoadTheLoaiList()
        {
            var theLoais = await GetAllTheLoaisAsync();
            foreach (var theLoai in theLoais)
            {
                TheLoaiList.Add(theLoai);
            }
        }

        private async Task AddTheLoai()
        {
            TheLoai newTheLoai = new TheLoai()
            {
                MaTL = MaTL,
                TenTL = TenTL
            };

            bool isSuccess = await AddTheLoaiToDatabaseAsync(newTheLoai);
            if (isSuccess)
            {
                TheLoaiList.Add(newTheLoai); // Add to ObservableCollection only if DB operation succeeds
            }
            else
            {
                MessageBox.Show("Error adding The Loai.");
            }
        }

        private async Task EditTheLoai()
        {
            if (SelectedTheLoai != null)
            {
                bool isSuccess = await UpdateTheLoaiInDatabaseAsync(SelectedTheLoai);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating The Loai.");
                }
            }
        }

        private async Task DeleteTheLoai()
        {
            if (SelectedTheLoai != null)
            {
                bool isSuccess = await DeleteTheLoaiFromDatabaseAsync(SelectedTheLoai.MaTL);
                if (isSuccess)
                {
                    TheLoaiList.Remove(SelectedTheLoai);
                }
                else
                {
                    MessageBox.Show("Error deleting The Loai.");
                }
            }
        }

        private async Task SearchTheLoai(string keyword)
        {
            var filteredList = await SearchTheLoaiInDatabaseAsync(keyword);
            TheLoaiList.Clear();
            foreach (var theLoai in filteredList)
            {
                TheLoaiList.Add(theLoai);
            }
        }

        #region MethodToDatabase

        public static async Task<bool> AddTheLoaiToDatabaseAsync(TheLoai theLoai)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.TheLoais.Add(theLoai);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding The loai: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> UpdateTheLoaiInDatabaseAsync(TheLoai theLoai)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    context.TheLoais.Update(theLoai);
                    await context.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating The loai: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> DeleteTheLoaiFromDatabaseAsync(string maTL)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var theLoaiToDelete = await context.TheLoais.FirstOrDefaultAsync(s => s.MaTL == maTL);
                    if (theLoaiToDelete != null)
                    {
                        context.TheLoais.Remove(theLoaiToDelete);
                        await context.SaveChangesAsync();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting The loai: {ex.Message}");
                return false;
            }
        }

        public static async Task<List<TheLoai>> SearchTheLoaiInDatabaseAsync(string keyword)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.TheLoais
                                              .Where(s => s.MaTL.Contains(keyword) || s.TenTL.Contains(keyword)) // Allows search by either MaTL or TenTL
                                              .ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching The loai: {ex.Message}");
                return new List<TheLoai>();
            }
        }

        /*public static async Task<List<TheLoai>> GetAllTheLoaisAsync()
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var result = await context.TheLoais.ToListAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting all The loai: {ex.Message}");
                return new List<TheLoai>();
            }
        }*/

        #endregion
    }
}