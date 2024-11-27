using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class SachTacGia
    {
        public string MaSach { get; set; }
        public Sach Sach { get; set; }

        public string MaTG { get; set; }
        public TacGia TacGia { get; set; }
    }
}
