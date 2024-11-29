using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApplication.Model.Class
{
    public class TheLoai
    {
        [Key]
        public string MaTL { get; set; }
        public string TenTL { get; set; }

        // Navigation properties
        public ICollection<SachTheLoai> SachTheLoais { get; set; } = new List<SachTheLoai>();
        public TheLoai() { }
    }
}
