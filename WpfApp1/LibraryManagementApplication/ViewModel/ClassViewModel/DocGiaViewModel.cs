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
    public class DocGiaViewModel : BaseViewModel
    {
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
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddDocGia());
            EditCommand = new RelayCommand<object>((p) => SelectedDocGia != null, (p) => EditDocGia());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDocGia != null, (p) => DeleteDocGia());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchDocGia(p));
        }

        private void AddDocGia()
        {
            DocGia newDocGia = new DocGia()
            {
                MaDG = "DG001",
                TenDG = "Nguyen Van A",
                Email = "nguyenvana@example.com",
                CCCD = "123456789"
            };
            DocGiaList.Add(newDocGia);
        }

        private void EditDocGia()
        {
            if (SelectedDocGia != null)
            {
                //Sử dụng Binding để chỉnh sửa dữ liệu
                OnPropertyChanged(nameof(SelectedDocGia));
            }
        }

        private void DeleteDocGia()
        {
            if (SelectedDocGia != null)
            {
                DocGiaList.Remove(SelectedDocGia);
            }
        }

        private void SearchDocGia(string keyword)
        {
            var filteredList = DocGiaList.Where(dg => dg.TenDG.Contains(keyword)).ToList();
            DocGiaList.Clear();
            foreach (var docGia in filteredList)
                DocGiaList.Add(docGia);
        }
    }
}
