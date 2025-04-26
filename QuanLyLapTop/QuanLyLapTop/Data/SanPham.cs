using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class SanPham
    {
        public int ID { get; set; }
        public string? TenSanPham { get; set; }

        [Column(TypeName = "decimal(18,2)")]  // precision = 18, scale = 2
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public DateTime NgayNhap { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
        //Khóa 5
        public int HangSanXuatID { get; set; }
        public int LoaiSanPhamID { get; set; }
        public int NhaCungCapID { get; set; }
        public int KhuyenMaiID { get; set; }
        // Navigation properties
        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new List<HoaDon_ChiTiet>();
        public virtual ICollection<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet { get; } = new List<PhieuNhap_ChiTiet>();
        //
        public virtual LoaiSanPham? LoaiSanPham { get; set; }
        public virtual HangSanXuat? HangSanXuat { get; set; }
        public virtual NhaCungCap? NhaCungCap { get; set; }
        public virtual KhuyenMai? KhuyenMai { get; set; } 
    }
}
