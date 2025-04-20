using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class LoaiSanPham
    {
        public int ID { get; set; }
        public string? TenLoaiSanPham { get; set; }
        // Navigation property
        public virtual ICollection<SanPham> SanPham { get; set; } = new List<SanPham>();
    }
}
