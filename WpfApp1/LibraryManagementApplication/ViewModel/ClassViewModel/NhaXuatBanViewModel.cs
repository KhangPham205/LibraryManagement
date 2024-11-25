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
    public class NhaXuatBanViewModel : BaseViewModel
    {
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
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddNhaXuatBan());
            EditCommand = new RelayCommand<object>((p) => SelectedNhaXuatBan != null, (p) => EditNhaXuatBan());
            DeleteCommand = new RelayCommand<object>((p) => SelectedNhaXuatBan != null, (p) => DeleteNhaXuatBan());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchNhaXuatBan(p));
        }

        private void AddNhaXuatBan()
        {
            NhaXuatBan newNhaXuatBan = new NhaXuatBan()
            {
                MaNXB = "NXB001",
                TenNXB = "Nhà Xuất Bản Mới"
            };
            NhaXuatBanList.Add(newNhaXuatBan);
        }

        private void EditNhaXuatBan()
        {
            if (SelectedNhaXuatBan != null)
            {
                //Sử dụng Binding
                OnPropertyChanged(nameof(SelectedNhaXuatBan));
            }
        }

        private void DeleteNhaXuatBan()
        {
            if (SelectedNhaXuatBan != null)
            {
                NhaXuatBanList.Remove(SelectedNhaXuatBan);
            }
        }

        private void SearchNhaXuatBan(string keyword)
        {
            var filteredList = NhaXuatBanList.Where(nxb => nxb.TenNXB.Contains(keyword)).ToList();
            NhaXuatBanList.Clear();
            foreach (var nhaXuatBan in filteredList)
            {
                NhaXuatBanList.Add(nhaXuatBan);
            }
        }
    }
}
