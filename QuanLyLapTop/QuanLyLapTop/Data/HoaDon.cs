using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; }
        public int KhachHangID { get; set; }
        public DateTime NgayLap { get; set; }
        public string? HinhThucThanhToan { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public virtual ICollection<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new List<HoaDon_ChiTiet>();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}
