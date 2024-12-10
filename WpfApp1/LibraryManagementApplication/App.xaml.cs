using System;
using System.Windows;

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Đặt đường dẫn chính xác đến thư mục chứa DatabaseLibrary.mdf
            string customPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Model\Database");
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.GetFullPath(customPath));
        }
    }
}