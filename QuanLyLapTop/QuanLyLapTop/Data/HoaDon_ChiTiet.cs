using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class HoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }// Giá này là cái giá gốc
        public double? GiamGia { get; set; }  // ví dụ 10% => 10.0
        public double? GiaSauKhiGiam { get; set; }// này là nếu tồn tại Khuyến mãi của sp thì nó tính còn không thì xử lý cho nó bằng cái Dơn giá bán rồi quăn nó qua hóa đơn
        public double? ThanhTien { get; set; } // Bổ sung thêm
        public string TenSanPham { get; set; } = null!;
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; } = null!; // Bổ sung thêm
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        //public double GiamGia { get; set; }  // ví dụ 10% => 10.0
        //public double GiaSauKhiGiam { get; set; }
        //public double ThanhTien { get; set; } // Bổ sung thêm
    }
}
