using LibraryManagementApplication.Model.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    public class SachViewModel : BaseViewModel
    {
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
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddSach());
            EditCommand = new RelayCommand<object>((p) => SelectedSach != null, (p) => EditSach());
            DeleteCommand = new RelayCommand<object>((p) => SelectedSach != null, (p) => DeleteSach());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchSach(p));
        }

        private void AddSach()
        {
            Sach newSach = new Sach()
            {
                MaSach = "S001",
                TenSach = "New Book",
                ISBN = "1234567890",
                ViTri = "A1",
                NgonNgu = "Vietnamese",
                TrangThai = "Available"
            };
            SachList.Add(newSach);
        }

        private void EditSach()
        {
            if (SelectedSach != null)
            {
                //SelectedSach.TenSach = "Edited Book";
                //Sử dụng Binding để cập nhật vào đây
                OnPropertyChanged(nameof(SelectedSach));
            }
        }

        private void DeleteSach()
        {
            if (SelectedSach != null)
            {
                SachList.Remove(SelectedSach);
            }
        }

        private void SearchSach(string keyword)
        {
            var filteredList = SachList.Where(s => s.TenSach.Contains(keyword)).ToList();
            SachList.Clear();
            foreach (var sach in filteredList)
            {
                SachList.Add(sach);
            }
        }
    }
}
