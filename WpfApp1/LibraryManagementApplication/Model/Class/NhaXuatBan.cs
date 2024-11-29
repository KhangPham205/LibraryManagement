using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class NhaXuatBan
    {
        [Key]
        public string MaNXB { get; set; }
        public string TenNXB { get; set; }

        // Navigation properties
        public NhaXuatBan() { }
    }
}
