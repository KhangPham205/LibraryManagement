using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.ViewModel.ClassViewModel
{
    using global::LibraryManagementApplication.Model.Class;
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Linq;
    using System.Windows.Input;

    namespace LibraryManagementApplication.ViewModel
    {
        public class CTDMViewModel : BaseViewModel
        {
            public ObservableCollection<CTDM> CTDMList { get; set; }
            private CTDM _selectedCTDM;
            public CTDM SelectedCTDM
            {
                get { return _selectedCTDM; }
                set
                {
                    if (_selectedCTDM != value)
                    {
                        _selectedCTDM = value;
                        OnPropertyChanged(nameof(SelectedCTDM));
                    }
                }
            }

            public ICommand AddCommand { get; set; }
            public ICommand EditCommand { get; set; }
            public ICommand DeleteCommand { get; set; }
            public ICommand SearchCommand { get; set; }

            public CTDMViewModel()
            {
                CTDMList = new ObservableCollection<CTDM>();
                AddCommand = new RelayCommand<object>((p) => true, (p) => AddCTDM());
                EditCommand = new RelayCommand<object>((p) => SelectedCTDM != null, (p) => EditCTDM());
                DeleteCommand = new RelayCommand<object>((p) => SelectedCTDM != null, (p) => DeleteCTDM());
                SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchCTDM(p));
            }

            private void AddCTDM()
            {
                CTDM newCTDM = new CTDM()
                {
                    MaMuon = "DM001",
                    MaSach = "S001",
                    SoLuon = 1
                };
                CTDMList.Add(newCTDM);
            }

            private void EditCTDM()
            {
                if (SelectedCTDM != null)
                {
                    //Sử dụng Binding
                    OnPropertyChanged(nameof(SelectedCTDM));
                }
            }

            private void DeleteCTDM()
            {
                if (SelectedCTDM != null)
                {
                    CTDMList.Remove(SelectedCTDM);
                }
            }

            private void SearchCTDM(string keyword)
            {
                var filteredList = CTDMList.Where(ctdm => ctdm.MaMuon.Contains(keyword) || ctdm.MaSach.Contains(keyword)).ToList();
                CTDMList.Clear();
                foreach (var ctdm in filteredList)
                {
                    CTDMList.Add(ctdm);
                }
            }
        }
    }
}