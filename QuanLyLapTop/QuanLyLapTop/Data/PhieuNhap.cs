using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class PhieuNhap
    {
        public int ID { get; set; }
        public int NhaCungCapID { get; set; }
        public int NhanVienID { get; set; } //user admin
        public DateTime NgayLap { get; set; }
        public string? GhiChuPhieuNhap { get; set; }
        public virtual ICollection<PhieuNhap_ChiTiet> PhieuNhapChiTiet { get; } = new List<PhieuNhap_ChiTiet>();
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;

    }
}
