using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class NhaCungCap
    {
        public int ID { get; set; }
        public string TenNhaCungCap { get; set; } = null!;
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        // Navigation property
        public virtual ICollection<SanPham> SanPham { get; set; } = new List<SanPham>();
        public virtual ICollection<PhieuNhap> PhieuNhap { get; set; } = new List<PhieuNhap>();

    }
}
