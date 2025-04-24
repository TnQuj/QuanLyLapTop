using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class PhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SanPhamID { get; set; }
        public int SoLuongNhap { get; set; }
        public int DonGiaNhap { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
    [NotMapped]
    public class DS_PhieuNhap_ChiTiet
    {
        public int ID { get; set; }
        public int PhieuNhapID { get; set; }
        public int SanPhamID { get; set; }
        public string? TenSanPham { get; set; } //
        public int SoLuongNhap { get; set; }
        public int DonGiaNhap { get; set; }
        public double ThanhTien { get; set; } //
    }

}
