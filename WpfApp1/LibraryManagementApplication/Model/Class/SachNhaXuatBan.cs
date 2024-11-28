using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class SachNhaXuatBan
    {
        public string MaSach { get; set; }
        public Sach Sach { get; set; }

        public string MaNXB { get; set; }
        public NhaXuatBan NhaXuatBan { get; set; }

        public int NamXB { get; set; } // Năm xuất bản
    }
}
