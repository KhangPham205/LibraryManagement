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
    public class TacGiaViewModel : BaseViewModel
    {
        public ObservableCollection<TacGia> TacGiaList { get; set; }
        private TacGia _selectedTacGia;
        public TacGia SelectedTacGia
        {
            get { return _selectedTacGia; }
            set
            {
                if (_selectedTacGia != value)
                {
                    _selectedTacGia = value;
                    OnPropertyChanged(nameof(SelectedTacGia));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public TacGiaViewModel()
        {
            TacGiaList = new ObservableCollection<TacGia>();
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddTacGia());
            EditCommand = new RelayCommand<object>((p) => SelectedTacGia != null, (p) => EditTacGia());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTacGia != null, (p) => DeleteTacGia());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchTacGia(p));
        }

        private void AddTacGia()
        {
            TacGia newTacGia = new TacGia()
            {
                MaTG = "TG001",
                TenTG = "Tác Giả Mới"
            };
            TacGiaList.Add(newTacGia);
        }

        private void EditTacGia()
        {
            if (SelectedTacGia != null)
            {
                //Sử dụng Binding
                OnPropertyChanged(nameof(SelectedTacGia));
            }
        }

        private void DeleteTacGia()
        {
            if (SelectedTacGia != null)
            {
                TacGiaList.Remove(SelectedTacGia);
            }
        }

        private void SearchTacGia(string keyword)
        {
            var filteredList = TacGiaList.Where(tg => tg.TenTG.Contains(keyword)).ToList();
            TacGiaList.Clear();
            foreach (var tacGia in filteredList)
            {
                TacGiaList.Add(tacGia);
            }
        }
    }
}
