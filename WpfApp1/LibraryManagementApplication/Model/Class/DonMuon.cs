﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class DonMuon
    {
        [Key]
        public string MaMuon { get; set; }
        public string MaDG { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTraDK { get; set; }
        public DateTime? NgayTraTT { get; set; } // Nullable for optional values
        public decimal PhiPhat { get; set; }

        // Navigation properties
        public DocGia DocGia { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public ICollection<CTDM> CTDMs { get; set; }

        public DonMuon() { }

        public DonMuon(string maMuon, string maDG, string maNV, DateTime ngayMuon, DateTime ngayTraDK, DateTime? ngayTraTT, decimal phiPhat)
        {
            MaMuon = maMuon;
            MaDG = maDG;
            MaNV = maNV;
            NgayMuon = ngayMuon;
            NgayTraDK = ngayTraDK;
            NgayTraTT = ngayTraTT;
            PhiPhat = phiPhat;
        }
    }
}
