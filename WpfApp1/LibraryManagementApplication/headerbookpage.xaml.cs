﻿using LibraryManagementApplication.Model.Class;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagementApplication
{
    /// <summary>
    /// Interaction logic for bookpage.xaml
    /// </summary>
    public partial class headerbookpage : Page
    {
        public headerbookpage()
        {
            InitializeComponent();
            List<DauSach> danhSachSach = new List<DauSach> 
            { 
                new DauSach { MaDauSach = "S001", TenDauSach = "Sách A", NgonNgu = "Tiếng Việt" },
                new DauSach {MaDauSach = "S002", TenDauSach = "Sách B", NgonNgu = "Tiếng Anh"}
            };
            // Gán danh sách dữ liệu cho DataGrid
            sach.ItemsSource = danhSachSach;
        }
    }
}