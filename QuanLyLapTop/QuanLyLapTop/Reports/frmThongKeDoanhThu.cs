using Microsoft.Reporting.WinForms;
using QuanLyLapTop.Data;
using QuanLyLapTop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyLapTop.Reports.QLBHDataSet;

namespace QuanLyLapTop.Reports
{
    public partial class frmThongKeDoanhThu : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachHoaDonDataTable danhSachHoaDonDataTable = new QLBHDataSet.DanhSachHoaDonDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        int id;
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new
            {
                r.ID,
                r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                r.NgayLap,
                r.GhiChuHoaDon,
                r.HinhThucThanhToan,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.GiaSauKhiGiam)
            }).ToList();

            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                    row.ID,
                    row.NhanVienID,
                    row.HoVaTenNhanVien,
                    row.KhachHangID,
                    row.HoVaTenKhachHang,
                    row.NgayLap,
                    row.GhiChuHoaDon,
                    row.HinhThucThanhToan,
                    row.TongTienHoaDon ?? 0
                    );
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            IList<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("MoTa", "(Tất cả các hóa đơn)"),
                new ReportParameter("NgayLap", $"Ngày {DateTime.Now.Day} Tháng {DateTime.Now.Month} Năm {DateTime.Now.Year}"),

                new ReportParameter("HoVaTenNhanVien", frmMain.HoVaTenNhanVien),
                new ReportParameter("Chucvu", frmMain.QuyenHan),
                //new ReportParameter("HoVaTenNhanVien",
                //    phieuNhap?.NhanVien?.HoVaTen ?? "Không rõ"),

                //new ReportParameter("ChucVu",
                //    phieuNhap?.NhanVien?.QuyenHan ?? "Không rõ")
            };

            reportViewer.LocalReport.SetParameters(param);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            var danhSachHoaDon = context.HoaDon.Select(r => new
            {
                r.ID,
                r.NhanVienID,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                r.KhachHangID,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                r.NgayLap,
                r.HinhThucThanhToan,
                r.GhiChuHoaDon,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => r.SoLuongBan * r.GiaSauKhiGiam)
            });
            danhSachHoaDon = danhSachHoaDon.Where(r => r.NgayLap >= dtpTuNgay.Value && r.NgayLap <= dtpDenNgay.Value);
            danhSachHoaDonDataTable.Clear();
            foreach (var row in danhSachHoaDon)
            {
                danhSachHoaDonDataTable.AddDanhSachHoaDonRow(
                row.ID,
                row.NhanVienID,
                row.HoVaTenNhanVien,
                row.KhachHangID,
                row.HoVaTenKhachHang,
                row.NgayLap,
                row.GhiChuHoaDon,
                row.HinhThucThanhToan,
                row.TongTienHoaDon ?? 0);
            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsHoaDon";
            reportDataSource.Value = danhSachHoaDonDataTable;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");
            ReportParameter reportParameter = new ReportParameter("MoTa", "Từ ngày " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text);
            reportViewer.LocalReport.SetParameters(reportParameter);
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu_Load(sender, e);
        }
    }
}
