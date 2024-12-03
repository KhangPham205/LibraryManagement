using LibraryManagementApplication.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
namespace LibraryManagementApplication.ViewModel
{
    public class RecoverViewModel : BaseViewModel
    {
        public ICommand RecoverCommand { get; set; }
        public RecoverViewModel()
        {
            RecoverCommand = new RelayCommand<UIElement>((p) => true, (p) => { 
                Window window = Window.GetWindow(p);
                recover(p);
                window.Close();
                });
        }
        public void recover(UIElement p) { }//xu ly khoi phuc dung ca 3 thong tin thi tra ra matkhau
    }
}