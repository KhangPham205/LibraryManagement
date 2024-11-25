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
    public class TaiKhoanViewModel : BaseViewModel
    {
        public ObservableCollection<TaiKhoan> TaiKhoanList { get; set; }
        private TaiKhoan _selectedTaiKhoan;
        public TaiKhoan SelectedTaiKhoan
        {
            get { return _selectedTaiKhoan; }
            set
            {
                if (_selectedTaiKhoan != value)
                {
                    _selectedTaiKhoan = value;
                    OnPropertyChanged(nameof(SelectedTaiKhoan));
                }
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand SearchCommand { get; set; }

        public TaiKhoanViewModel()
        {
            TaiKhoanList = new ObservableCollection<TaiKhoan>();
            AddCommand = new RelayCommand<object>((p) => true, (p) => AddTaiKhoan());
            EditCommand = new RelayCommand<object>((p) => SelectedTaiKhoan != null, (p) => EditTaiKhoan());
            DeleteCommand = new RelayCommand<object>((p) => SelectedTaiKhoan != null, (p) => DeleteTaiKhoan());
            SearchCommand = new RelayCommand<string>((p) => true, (p) => SearchTaiKhoan(p));
        }

        private void AddTaiKhoan()
        {
            TaiKhoan newTaiKhoan = new TaiKhoan()
            {
                UserID = "TK001",
                UserName = "User Mới",
                Password = "password123",
                Loai = "NV",
                Email = "usermoi@example.com",
                SDT = "0123456789",
                CCCD = "123456789"
            };
            TaiKhoanList.Add(newTaiKhoan);
        }

        private void EditTaiKhoan()
        {
            if (SelectedTaiKhoan != null)
            {
                OnPropertyChanged(nameof(SelectedTaiKhoan));
            }
        }

        private void DeleteTaiKhoan()
        {
            if (SelectedTaiKhoan != null)
            {
                TaiKhoanList.Remove(SelectedTaiKhoan);
            }
        }

        private void SearchTaiKhoan(string keyword)
        {
            var filteredList = TaiKhoanList.Where(tk => tk.UserName.Contains(keyword)).ToList();
            TaiKhoanList.Clear();
            foreach (var taiKhoan in filteredList)
            {
                TaiKhoanList.Add(taiKhoan);
            }
        }
    }

    // RelayCommand implementation for ICommand
    public class RelayCommand<T> : ICommand
    {
        private readonly Predicate<T> _canExecute;
        private readonly Action<T> _execute;

        public RelayCommand(Predicate<T> canExecute, Action<T> execute)
        {
            _canExecute = canExecute;
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
