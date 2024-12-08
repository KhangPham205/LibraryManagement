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
    public class TheLoaiViewModel : BaseViewModel
    {
        public string MaTL { get; set; }
        public string TenTL { get; set; }
        public ObservableCollection<TheLoai> TheLoaiList { get; set; }
        private TheLoai _selectedTheLoai;

        public TheLoai SelectedTheLoai
        {
            get => _selectedTheLoai; 
            set
            {
                if (_selectedTheLoai != value)
                {
                    _selectedTheLoai = value;
                    OnPropertyChanged();
                    if (SelectedTheLoai != null)
                    {
                        DisplayName = SelectedTheLoai.TenTL;
                    }
                }
            }
        }
        private String _displayName;
        public String DisplayName 
        { 
            get => _displayName; 
            set 
            { 
                if (_displayName != value) 
                {  
                    _displayName = value; 
                    OnPropertyChanged(); 
                } 
            } 
        }

        private async Task<string> CreateMaTLAsync()
        {
            // Generate a hash from TenTL
            using (var context = new LibraryDbContext())
            {
                // Lấy tất cả các mã "MaTL" hiện tại trong cơ sở dữ liệu có tiền tố "TL"
                var existingCodes = await context.TheLoais
                                                 .Where(tl => tl.MaTL.StartsWith("TL"))
                                                 .Select(tl => tl.MaTL)
                                                 .ToListAsync();

                int maxCodeNumber = existingCodes
                    .Select(code => int.TryParse(code.Substring(2), out int num) ? num : 0) // Lấy phần số sau "TL"
                    .DefaultIfEmpty(0) // Nếu không có mã nào, mặc định là 0
                    .Max(); // Lấy số lớn nhất trong danh sách mã

                // Tạo mã mới với số tăng dần
                int newCodeNumber = maxCodeNumber + 1;

                // Trả về mã mới với định dạng "TL" + số có 3 chữ số
                return $"TL{newCodeNumber:D3}";
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }
        public ICommand ShowCommand { get; set; }

        public TheLoaiViewModel()
        {
            TheLoaiList = new ObservableCollection<TheLoai>();
            AddCommand = new RelayCommand<object>((p) => { if (string.IsNullOrEmpty(DisplayName)) return false; return true; }, async (p) => await AddTheLoai());
            EditCommand = new RelayCommand<object>((p) => SelectedTheLoai != null, async (p) => await EditTheLoai());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTheLoai != null, async (p) => await DeleteTheLoai());
            SearchCommand = new RelayCommand<DataGrid>((p) => true, async (p) => await SearchTheLoai(p));
            ShowCommand = new RelayCommand<DataGrid>((p) => true, async (p) => await ShowTheLoai(p));
            LoadTheLoaiList();
        }

        private async void LoadTheLoaiList()
        {
            TheLoaiList.Clear();
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
                MaTL = await CreateMaTLAsync(), // Generate unique MaTL
                TenTL = DisplayName
            };

            bool isSuccess = await AddTheLoaiToDatabaseAsync(newTheLoai);
            if (isSuccess)
            {
                TheLoaiList.Add(newTheLoai);
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
                SelectedTheLoai.TenTL = DisplayName;
                bool isSuccess = await UpdateTheLoaiInDatabaseAsync(SelectedTheLoai);
                if (!isSuccess)
                {
                    MessageBox.Show("Error updating The Loai.");
                }
                LoadTheLoaiList();
            }
        }

        private async Task DeleteTheLoai()
        {
            if (SelectedTheLoai != null)
            {
                bool isSuccess = await DeleteTheLoaiFromDatabaseAsync(SelectedTheLoai);
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
        private async Task SearchTheLoai(DataGrid p)
        {
            var TempList = await SearchTheLoaiInDatabaseAsync(DisplayName);
            p.ItemsSource = TempList;
        }
        private async Task ShowTheLoai(DataGrid p)
        {
            p.ItemsSource = TheLoaiList;
        }

        #region MethodToDatabase

        public static async Task<bool> AddTheLoaiToDatabaseAsync(TheLoai theLoai)
        {
            //kiểm tra bị trùng
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

        public static async Task<bool> DeleteTheLoaiFromDatabaseAsync(TheLoai theLoai)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    var theLoaiToDelete = await context.TheLoais.FirstOrDefaultAsync(s => s == theLoai);
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

        public static async Task<List<TheLoai>> GetAllTheLoaisAsync()
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
        }

        #endregion
    }
}