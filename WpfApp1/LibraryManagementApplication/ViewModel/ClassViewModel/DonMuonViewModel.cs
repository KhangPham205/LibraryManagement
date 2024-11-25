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
    public class DonMuonViewModel : BaseViewModel
    {
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

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public DonMuonViewModel()
        {
            DonMuonList = new ObservableCollection<DonMuon>();
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddDonMuon());
            EditCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, (p) => EditDonMuon());
            DeleteCommand = new RelayCommand<object>((p) => SelectedDonMuon != null, (p) => DeleteDonMuon());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchDonMuon(p));
        }

        private void AddDonMuon()
        {
            DonMuon newDonMuon = new DonMuon()
            {
                MaMuon = "DM001",
                MaDG = "DG001",
                NgayMuon = DateTime.Now,
                NgayTraDK = DateTime.Now.AddDays(7),
                NgayTraTT = DateTime.MinValue,
                PhiPhat = 0
            };
            DonMuonList.Add(newDonMuon);
        }

        private void EditDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                //Sử dụng Binding
                OnPropertyChanged(nameof(SelectedDonMuon));
            }
        }

        private void DeleteDonMuon()
        {
            if (SelectedDonMuon != null)
            {
                DonMuonList.Remove(SelectedDonMuon);
            }
        }

        private void SearchDonMuon(string keyword)
        {
            var filteredList = DonMuonList.Where(dm => dm.MaMuon.Contains(keyword) || dm.MaDG.Contains(keyword)).ToList();
            DonMuonList.Clear();
            foreach (var donMuon in filteredList)
            {
                DonMuonList.Add(donMuon);
            }
        }
    }
}
