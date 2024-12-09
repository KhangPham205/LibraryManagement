using LibraryManagementApplication.ViewModel.ClassViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Signup : Window
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            // Kiểm tra nếu tài khoản được thêm thành công
            bool isSuccess = (this.DataContext as TaiKhoanViewModel).IsAdded;

            if (isSuccess)
            {
                // Hiển thị thông báo thành công
                MessageBox.Show("Nhân viên đã được thêm thành công.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);

                // Đóng cửa sổ đăng ký
                this.Close();
            }
        }
    }
}
