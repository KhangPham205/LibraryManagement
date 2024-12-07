using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApplication.Model.Class
{
    public class Sach
    {
        [Key]
        public string MaDauSach { get; set; }
        public string ISBN { get; set; }
        public string ViTri { get; set; }
        public string TrangThai { get; set; }
        public int NamXB { get; set; }
        public DauSach DauSach { get; set; }
        public Sach() { }
    }
}
