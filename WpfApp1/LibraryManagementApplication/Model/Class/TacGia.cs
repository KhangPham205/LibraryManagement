using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class TacGia
    {
        [Key]
        public string MaTG { get; set; }
        public string TenTG { get; set; }

        // Navigation properties
        public ICollection<SachTacGia> SachTacGias { get; set; } = new List<SachTacGia>();
        public TacGia() { }
    }
}
