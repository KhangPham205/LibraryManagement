using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class CTDM
    {
        public string MaMuon { get; set; }
        public string MaDauSach { get; set; }
        public string ISBN { get; set; }

        // Navigation properties
        public DonMuon DonMuon { get; set; }
        public Sach Sach { get; set; }

        public CTDM() { }

        public CTDM(string maMuon, string maDauSach, string isbn)
        {
            MaMuon = maMuon;
            MaDauSach = maDauSach;
            ISBN = isbn;
        }
    }
}
