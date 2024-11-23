using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryManagementApplication.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel() 
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
