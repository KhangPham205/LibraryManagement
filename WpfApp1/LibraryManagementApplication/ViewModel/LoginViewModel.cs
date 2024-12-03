using LibraryManagementApplication.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        public ICommand SignupCommand { get; set; }
        public ICommand RecoverCommand { get; set; }
        public LoginViewModel()
        {
            LoginCommand = new RelayCommand<Window>((p) => true, (p) => Login(p));
            SignupCommand = new RelayCommand<Window>((p) => true, (p) => { Signup window = new Signup(); window.ShowDialog(); });
            RecoverCommand = new RelayCommand<object>((p) => true, (p) => { Window window = new Recover(); window.ShowDialog(); });
        }

        private void Login(Window p)
        {
            using (var context = new LibraryDbContext())
            {
                Window mainwindow = new MainWindow1();
                mainwindow.Show();
                p.Close();
                // Tìm người dùng dựa vào Username và Password (cần hash password nếu sử dụng trong thực tế)
                //var user = context.TaiKhoans.FirstOrDefault(u => u.UserName == Username && u.Password == Password);
                //if (user != null)
                //{
                    //IsLoginSuccessful = true;
                    
                    //if(user la admin) 
                    //Window mainwindow = new MainWindow1();
                    //else 
                    //Window mainwindow = new MainWindow2();
                    //mainwindow.Show();
                    //p.Close();
                    // Điều hướng đến trang chính của ứng dụng hoặc hiển thị thông báo thành công
                //}
                //else
                //{
                   //IsLoginSuccessful = false;
                    // Hiển thị thông báo lỗi cho người dùng
                //}
            }
        }
    }
}
