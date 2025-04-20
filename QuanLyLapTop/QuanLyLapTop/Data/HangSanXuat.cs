using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class HangSanXuat
    {
        public int ID { get; set; }
        public string? TenHangSanXuat { get; set; }
        public string? Email { get; set; } 
        public string? DiaChi { get; set; }
        public string? HinhAnh { get; set; }
        // Navigation property
        public virtual ICollection<SanPham> SanPham { get; set; } = new HashSet<SanPham>();    
    }
}
