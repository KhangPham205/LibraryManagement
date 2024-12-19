using System;
using System.IO;
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
            // Lấy đường dẫn tuyệt đối tới thư mục "Model\Database"
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string customPath = Path.Combine(projectDirectory, "Model", "Database");
            AppDomain.CurrentDomain.SetData("DataDirectory", customPath);
            //MessageBox.Show(customPath);
        }
    }
}