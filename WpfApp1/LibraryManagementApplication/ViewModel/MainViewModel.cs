﻿using LibraryManagementApplication.Model.Class;
using LibraryManagementApplication;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LibraryManagementApplication.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region commands
        public ICommand signincommand { get; set; }
        public ICommand signoutcommand { get; set; }
        public ICommand mainpagecommand { get; set; }
        public ICommand bookpagecommand { get; set; }
        public ICommand borrowpagecommand { get; set; }
        public ICommand readerpagecommand { get; set; }
        public ICommand employeepagecommand { get; set; }
        #endregion
        public MainViewModel()
        { 
            signincommand = new RelayCommand<Window> ( (p) => { return isLogin(); }, (p) => {  Signin window = new Signin(); window.Show(); p.Close(); } );
            signoutcommand = new RelayCommand<object>((p) => { return !isLogin(); }, (p) => { logOut(); });
            mainpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is mainpage); }, (p) => { p.Content = new mainpage(); });
            bookpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is bookpage); }, (p) => { p.Content = new bookpage(); });
            borrowpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is borrowpage); }, (p) => { p.Content = new borrowpage(); });
            readerpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is readerpage); }, (p) => { p.Content = new readerpage(); });
            employeepagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is employeepage); }, (p) => { p.Content = new employeepage(); });
        }
        bool isLogin() { return true; }//kiem tra da dang nhap chua
        void logOut() { }
    }
}
