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
    /// Interaction logic for typepage.xaml
    /// </summary>
    public partial class typepage : Page
    {
        public typepage()
        {
            InitializeComponent();
            List<TheLoai> danhSachTheLoai = new List<TheLoai>
            {
                new TheLoai { MaTL = "TL001", TenTL = "Văn học" },
                new TheLoai { MaTL = "TL002", TenTL = "Khoa học" },
                new TheLoai { MaTL = "TL003", TenTL = "Thiếu nhi" }
            };
            // Gán danh sách dữ liệu cho DataGrid
            theloai.ItemsSource = danhSachTheLoai;
        }
    }
}