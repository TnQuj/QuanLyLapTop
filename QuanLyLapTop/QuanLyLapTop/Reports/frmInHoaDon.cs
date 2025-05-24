using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyLapTop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLapTop.Reports
{
    public partial class frmInHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachHoaDon_ChiTietDataTable danhSachHoaDon_ChiTietDataTable = new QLBHDataSet.DanhSachHoaDon_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        int id;
        public frmInHoaDon(int maHoaDon =0)
        {
            InitializeComponent();
            id = maHoaDon;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDon.Include(r => r.KhachHang).Include(r => r.HoaDon_ChiTiet)
                .Where(r => r.ID == id).SingleOrDefault();
            if(hoaDon != null)
            {
                var hoaDonChiTiet = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new HoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    TenSanPham = r.SanPham.TenSanPham!,
                    GiamGia = 0,
                    GiaSauKhiGiam = r.DonGiaBan,
                    ThanhTien = r.SoLuongBan * r.GiaSauKhiGiam,
                }).ToList();

                danhSachHoaDon_ChiTietDataTable.Clear();
                foreach (var row in hoaDonChiTiet)
                {
                    danhSachHoaDon_ChiTietDataTable.AddDanhSachHoaDon_ChiTietRow(row.ID,
                    row.HoaDonID,
                    row.SanPhamID,
                    row.TenSanPham,
                    row.SoLuongBan,
                    row.DonGiaBan,
                    row.GiamGia?? 0 ,
                    row.GiaSauKhiGiam ?? 0,
                    row.ThanhTien?? 0);
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsHoadon";
                reportDataSource.Value = danhSachHoaDon_ChiTietDataTable;
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(reportDataSource);
                reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInHoaDon.rdlc");
                IList<ReportParameter> param = new List<ReportParameter>
{
                    new ReportParameter("NgayLap", hoaDon?.NgayLap != null
                        ? string.Format("Ngày {0} Tháng {1} Năm {2}", hoaDon.NgayLap.Day, hoaDon.NgayLap.Month, hoaDon.NgayLap.Year)
                        : "Không xác định"),

                    new ReportParameter("NguoiBan_Ten", "CÔNG TY TNHH LAPTOPVIE"),
                    new ReportParameter("NguoiBan_DiaChi", "Mỹ Hòa, TP. Long Xuyên, An Giang"),
                    new ReportParameter("NguoiBan_MaSoThue", "LTV1602162070"),

                    new ReportParameter("NguoiMua_Ten", hoaDon?.KhachHang?.HoVaTen ?? "Không xác định"),
                    new ReportParameter("NguoiMua_DiaChi", hoaDon?.KhachHang?.DiaChi ?? "Không xác định"),
                    new ReportParameter("NguoiMua_MaSoThue", ""),

                    new ReportParameter("NguoiBan_SoDienThoai", hoaDon?.NhanVien?.DienThoai ?? "Không có"),
                    new ReportParameter("NguoiMua_SoDienThoai", hoaDon?.KhachHang?.DienThoai ?? "Không có"),
                    new ReportParameter("NguoiMua_HinhThucThanhToan", hoaDon?.HinhThucThanhToan ?? "Không rõ"),

                    new ReportParameter("TongTien", hoaDon?.HoaDon_ChiTiet != null
                        ? hoaDon.HoaDon_ChiTiet.Sum(r => (r.SoLuongBan) * (r.GiaSauKhiGiam ?? 0)).ToString()
                        : "0")
                };
                //IList<ReportParameter> param = new List<ReportParameter>
                //{
                //new ReportParameter("NgayLap", string.Format("Ngày {0} Tháng {1} Năm {2}",
                //hoaDon.NgayLap.Day,
                //hoaDon.NgayLap.Month,
                //hoaDon.NgayLap.Year)),
                //new ReportParameter("NguoiBan_Ten", "CÔNG TY TNHH LAPTOPVIE"),
                //new ReportParameter("NguoiBan_DiaChi", "Mỹ Hòa, TP. Long Xuyên, An Giang"),
                //new ReportParameter("NguoiBan_MaSoThue", "LTV1602162070"),
                //new ReportParameter("NguoiMua_Ten", hoaDon.KhachHang.HoVaTen),
                //new ReportParameter("NguoiMua_DiaChi", hoaDon.KhachHang.DiaChi),
                //new ReportParameter("NguoiMua_MaSoThue", ""),
                //new ReportParameter("NguoiBan_SoDienThoai",hoaDon.NhanVien.DienThoai),
                //new ReportParameter("NguoiMua_SoDienThoai", hoaDon.KhachHang.DienThoai),
                //new ReportParameter("NguoiMua_HinhThucThanhToan", hoaDon.HinhThucThanhToan),
                //new ReportParameter("TongTien", hoaDon.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.GiaSauKhiGiam).ToString())
                //};
                reportViewer.LocalReport.SetParameters(param);
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }
    }
}
