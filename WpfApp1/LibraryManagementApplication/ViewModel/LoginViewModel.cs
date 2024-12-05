using LibraryManagementApplication.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {
        // Properties for binding to the UI
        private string _userid;
        public string UserID
        {
            get { return _userid; }
            set
            {
                if (_userid == "" || _userid != value)
                {
                    _userid = value;
                    OnPropertyChanged(nameof(_userid));
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

        private bool _isLoginSuccessful = false;
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
                //Window mainwindow;
                // Tìm người dùng dựa vào Username và Password (cần hash password nếu sử dụng trong thực tế)
                MessageBox.Show(UserID + " " + Password);

                foreach (var item in context.TaiKhoans)
                {
                    if (item.UserID.ToString().Equals(UserID) && item.Password == Password)
                    {
                        MessageBox.Show("Thanh cong dang nhap");
                        IsLoginSuccessful = true;
                    }
                    MessageBox.Show(item.UserID + " " + item.Password);
                }
                if (!IsLoginSuccessful)
                    MessageBox.Show("Failed to login");
                //var user = context.TaiKhoans.FirstOrDefault(u => u.UserID == UserID && u.Password == Password);
                //if (user != null)
                //{
                //    IsLoginSuccessful = true;

                //    if (user.Loai == "AD") 
                //        mainwindow = new MainWindow1();
                //    else
                //        mainwindow = new MainWindow2();
                //    mainwindow.Show();
                //    p.Close();
                //}
                //else
                //{
                //    IsLoginSuccessful = false;
                //}

                //if (IsLoginSuccessful)
                //    MessageBox.Show("Dang nhap thanh cong", "Thong bao");
                //else
                //    MessageBox.Show("Dang nhap that bai" + user.UserID + " " + user.Password, "Thong bao");
            }
        }
    }

    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty BindPasswordProperty =
            DependencyProperty.RegisterAttached("BindPassword", typeof(string), typeof(PasswordBoxHelper), new PropertyMetadata(string.Empty, OnBindPasswordChanged));

        public static void SetBindPassword(DependencyObject element, string value)
        {
            element.SetValue(BindPasswordProperty, value);
        }

        public static string GetBindPassword(DependencyObject element)
        {
            return (string)element.GetValue(BindPasswordProperty);
        }

        private static void OnBindPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox passwordBox)
            {
                passwordBox.PasswordChanged += (sender, args) =>
                {
                    SetBindPassword(passwordBox, passwordBox.Password);
                };
            }
        }
    }
}
