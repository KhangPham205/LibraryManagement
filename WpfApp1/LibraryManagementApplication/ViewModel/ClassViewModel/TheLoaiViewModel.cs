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
    public class TheLoaiViewModel : BaseViewModel
    {
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
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddTheLoai());
            EditCommand = new RelayCommand<object>((p) => SelectedTheLoai != null, (p) => EditTheLoai());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTheLoai != null, (p) => DeleteTheLoai());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchTheLoai(p));
        }

        private void AddTheLoai()
        {
            TheLoai newTheLoai = new TheLoai()
            {
                MaTL = "TL001",
                TenTL = "Thể loại mới"
            };
            TheLoaiList.Add(newTheLoai);
        }

        private void EditTheLoai()
        {
            if (SelectedTheLoai != null)
            {
                //Sử dụng Binding để cập nhật
                OnPropertyChanged(nameof(SelectedTheLoai));
            }
        }

        private void DeleteTheLoai()
        {
            if (SelectedTheLoai != null)
            {
                TheLoaiList.Remove(SelectedTheLoai);
            }
        }

        private void SearchTheLoai(string keyword)
        {
            var filteredList = TheLoaiList.Where(tl => tl.TenTL.Contains(keyword)).ToList();
            TheLoaiList.Clear();
            foreach (var theLoai in filteredList)
            {
                TheLoaiList.Add(theLoai);
            }
        }
    }

}
