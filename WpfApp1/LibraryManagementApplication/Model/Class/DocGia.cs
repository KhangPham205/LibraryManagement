using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class DocGia
    {
        [Key]
        public string MaDG { get; set; }
        public string TenDG { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string CCCD { get; set; }
        public string SDT { get; set; }
        // Navigation properties
        public ICollection<DonMuon> DonMuons { get; set; }
        public DocGia() { }
    }
}
