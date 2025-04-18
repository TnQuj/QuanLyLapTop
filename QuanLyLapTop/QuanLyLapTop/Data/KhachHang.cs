using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class KhachHang
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; } = null!;
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        // 
        public virtual ICollection<HoaDon> HoaDon { get; } = new List<HoaDon>();
    }
}
