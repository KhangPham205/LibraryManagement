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
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public string ISBN { get; set; }
        public string ViTri { get; set; }
        public string NgonNgu { get; set; }
        public string TrangThai { get; set; }
        public string TenTG { get; set; }
        public string TheLoai { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        // Navigation properties

        public Sach() { }
    }
}
