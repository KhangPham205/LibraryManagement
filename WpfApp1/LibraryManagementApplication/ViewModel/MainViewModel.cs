using LibraryManagementApplication.Model.Class;
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
        public ICommand writerpagecommand { get; set; }
        public ICommand typepagecommand { get; set; }
        public ICommand publisherpagecommand { get; set; }
        public ICommand lendpagecommand { get; set; }
        public ICommand headerbookpagecommand { get; set; }
        public ICommand infopagecommand { get; set; }
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
            writerpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is writerpage); }, (p) => { p.Content = new writerpage(); });
            typepagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is typepage); }, (p) => { p.Content = new typepage(); });
            publisherpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is publisherpage); }, (p) => { p.Content = new publisherpage(); });
            lendpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is lendpage); }, (p) => { p.Content = new lendpage(); });
            headerbookpagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is headerbookpage); }, (p) => { p.Content = new headerbookpage(); });
            infopagecommand = new RelayCommand<Frame>((p) => { return !(p.Content is infoxaml); }, (p) => { p.Content = new infoxaml(); });
        }
        bool isLogin() { return true; }//kiem tra da dang nhap chua
        void logOut() { }
    }
}
