using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class TaiKhoan
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Loai { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public TaiKhoan() { }
    }
}
