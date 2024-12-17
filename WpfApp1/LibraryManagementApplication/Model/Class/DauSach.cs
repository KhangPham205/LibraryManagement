using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementApplication.Model.Class
{
    public class DauSach
    {
        public string MaDauSach { get; set; }
        public string TenDauSach { get; set; }
        public string MaTG { get; set; }
        public string NgonNgu {  get; set; }
        public string MaTL { get; set; }
        public string MaNXB { get; set; }
        public ICollection<Sach> Sachs { get; set; }

        public DauSach() { }
    }
}
