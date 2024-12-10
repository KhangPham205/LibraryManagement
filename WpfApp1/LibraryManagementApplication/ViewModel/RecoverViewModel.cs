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
        public string email {  get; set; }
        public string sdt { get; set; }
        public string cccd { get; set; }

        private string _password;
        public string password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(); // Thông báo giao diện cập nhật giá trị
            }
        }
        public ICommand RecoverCommand { get; set; }
        public RecoverViewModel()
        {
            RecoverCommand = new RelayCommand<UIElement>((p) => true, (p) => { 
                Window window = Window.GetWindow(p);
                recover(p);
                window.Close();
                });
        }
        public void recover(UIElement p)
        {
            try
            {
                using (var context = new LibraryDbContext())
                {
                    // Tìm tài khoản có thông tin khớp với email, số điện thoại và CCCD
                    var taiKhoan = context.TaiKhoans
                        .FirstOrDefault(tk => tk.Email == email && tk.SDT == sdt && tk.CCCD == cccd);

                    if (taiKhoan != null)
                    {
                        // Gán mật khẩu của tài khoản tìm thấy vào thuộc tính password
                        password = taiKhoan.Password;

                        // Hiển thị mật khẩu lên giao diện
                        MessageBox.Show("Tìm thấy tài khoản. Mật khẩu đã được hiển thị.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        // Nếu không tìm thấy tài khoản, hiển thị thông báo lỗi
                        MessageBox.Show("Không tìm thấy tài khoản với thông tin đã cung cấp!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi trong quá trình tương tác với cơ sở dữ liệu
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }//xu ly khoi phuc dung ca 3 thong tin thi tra ra matkhau
    }
}