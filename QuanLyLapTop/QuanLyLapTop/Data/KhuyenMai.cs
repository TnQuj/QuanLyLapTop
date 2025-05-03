using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class KhuyenMai
    {
        public int ID { get; set; }
        public string TenKhuyenMai { get; set; } = string.Empty;// = string.Empty == public string? TenKhuyenMai { get; set; }
        public double GiamGia { get; set; }  // ví dụ 10% => 10.0
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        // Liên kết với sản phẩm (nếu khuyến mãi áp dụng cho 1 vài sản phẩm)
        public virtual ICollection<SanPham> SanPham { get; } = new List<SanPham>();
    }
}
