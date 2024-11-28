using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class SachTheLoai
    {
        public string MaSach { get; set; }
        public Sach Sach { get; set; }

        public string MaTL { get; set; }
        public TheLoai TheLoai { get; set; }
    }
}
