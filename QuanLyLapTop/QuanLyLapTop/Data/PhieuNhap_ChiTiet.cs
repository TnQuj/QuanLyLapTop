using System;
using System.Collections.Generic;
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
        public short SoLuongNhap { get; set; }
        public int DonGiaNhap { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
}
