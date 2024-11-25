﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class DonMuon
    {
        public string MaMuon { get; set; }
        public string MaDG { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTraDK { get; set; }
        public DateTime NgayTraTT { get; set; }
        public decimal PhiPhat { get; set; }

        public DonMuon() { }
        public DonMuon(string maMuon, string maDG, DateTime ngayMuon, DateTime ngayTraDK, DateTime ngayTraTT, decimal phiPhat)
        {
            MaMuon = maMuon;
            MaDG = maDG;
            NgayMuon = ngayMuon;
            NgayTraDK = ngayTraDK;
            NgayTraTT = ngayTraTT;
            PhiPhat = phiPhat;
        }
    }
}
