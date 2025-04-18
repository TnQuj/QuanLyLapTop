using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class CauHinh
    {
        public int ID { get; set; }
        public string? TenCauHinh { get; set; }
        public string? CPU { get; set; }
        public string? RAM { get; set; }
        public string? OCung { get; set; }
        public string? ManHinh { get; set; }
        public string? GPU { get; set; }
        public string? Pin { get; set; }
        public string? TrongLuong { get; set; }
        public string? HeDieuHanh { get; set; }
        // Navigation property
        public virtual ICollection<SanPham> SanPham { get; set; } = new HashSet<SanPham>();
    }
}
