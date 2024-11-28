﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class CTDM
    {
        public string MaMuon { get; set; }
        public string MaSach { get; set; }
        public int SoLuong { get; set; }

        // Navigation properties
        public DonMuon DonMuon { get; set; }
        public Sach Sach { get; set; }
        public CTDM() { }
        public CTDM(string maMuon, string maSach, int soLuong)
        {
            MaMuon = maMuon;
            MaSach = maSach;
            SoLuong = soLuong;
        }
    }
}