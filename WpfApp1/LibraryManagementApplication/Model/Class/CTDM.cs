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
        public string MaSach { get; set; }
        public int SoLuon { get; set; }
        public CTDM() { }
        public CTDM(string maMuon, string maSach, int soLuon)
        {
            MaMuon = maMuon;
            MaSach = maSach;
            SoLuon = soLuon;
        }
    }
}
