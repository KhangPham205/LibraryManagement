using LibraryManagementApplication.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        // Properties for binding to the UI
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged(nameof(Username));
                }
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        private bool _isLoginSuccessful;
        public bool IsLoginSuccessful
        {
            get { return _isLoginSuccessful; }
            set
            {
                if (_isLoginSuccessful != value)
                {
                    _isLoginSuccessful = value;
                    OnPropertyChanged(nameof(IsLoginSuccessful));
                }
            }
        }

        // Command for login action
        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<object>((p) => true, (p) => Login());
        }

        private void Login()
        {
            using (var context = new LibraryDbContext())
            {
                // Tìm người dùng dựa vào Username và Password (cần hash password nếu sử dụng trong thực tế)
                var user = context.TaiKhoans.FirstOrDefault(u => u.UserName == Username && u.Password == Password);
                if (user != null)
                {
                    IsLoginSuccessful = true;
                    // Điều hướng đến trang chính của ứng dụng hoặc hiển thị thông báo thành công
                }
                else
                {
                    IsLoginSuccessful = false;
                    // Hiển thị thông báo lỗi cho người dùng
                }
            }
        }
    }
}
