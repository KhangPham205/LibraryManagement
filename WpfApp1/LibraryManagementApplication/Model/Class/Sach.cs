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

        // Navigation properties
        public ICollection<SachTacGia> SachTacGias { get; set; } = new List<SachTacGia>();
        public ICollection<SachTheLoai> SachTheLoais { get; set; } = new List<SachTheLoai>();
        public ICollection<SachNhaXuatBan> SachNhaXuatBans { get; set; } = new List<SachNhaXuatBan>();
        public ICollection<CTDM> CTDMs { get; set; } = new List<CTDM>();

        public Sach() { }
    }
}
