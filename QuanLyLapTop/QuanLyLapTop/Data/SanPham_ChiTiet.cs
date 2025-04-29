 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLapTop.Data
{
    public class SanPham_ChiTiet
    {
        // Properties (Xem chi tiết 1 sản phẩm)
        public int ID { get; set; }
        public int SanPhamID { get; set; } //build ngược khóa 
        public string? CPU { get; set; }
        public string? RAM { get; set; }
        public string? OCung { get; set; }
        public string? ManHinh { get; set; }
        public string? GPU { get; set; }
        public string? Pin { get; set; }
        public string? TrongLuong { get; set; }
        public string? HeDieuHanh { get; set; }
        // Navigation property
        public virtual SanPham? SanPham { get; set; }

    }
    //[NotMapped]
    //public class DS_SanPhamChiTiet
    //{
    //    public int ID { get; set; }
    //    public int SanPhamID { get; set; } //build ngược khóa 
    //    public string? CPU { get; set; }
    //    public string? RAM { get; set; }
    //    public string? OCung { get; set; }
    //    public string? ManHinh { get; set; }
    //    public string? GPU { get; set; }
    //    public string? Pin { get; set; }
    //    public string? TrongLuong { get; set; }
    //    public string? HeDieuHanh { get; set; }
    //}
}
