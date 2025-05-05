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
    public partial class frmInPhieuNhap : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachPhieuNhap_ChiTietDataTable danhSachPhieuNhap_ChiTietDataTable = new QLBHDataSet.DanhSachPhieuNhap_ChiTietDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        int id;
        public frmInPhieuNhap(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;
        }

        private void frmInPhieuNhap_Load(object sender, EventArgs e)
        {
            var phieuNhap = context.PhieuNhap.Include(r => r.NhaCungCap).Include(r => r.PhieuNhap_ChiTiet)
                                .Where(r => r.ID == id).SingleOrDefault();
            if (phieuNhap != null)
            {
                var phieuNhapChiTiet = context.PhieuNhap_ChiTiet.Where(r => r.PhieuNhapID == id).Select(r => new DS_PhieuNhap_ChiTiet
                {
                    ID = r.ID,
                    PhieuNhapID = r.PhieuNhapID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham,
                    SoLuongNhap = r.SoLuongNhap,
                    DonGiaNhap = r.DonGiaNhap,
                    ThanhTien = r.SoLuongNhap * r.DonGiaNhap
                }).ToList();
                danhSachPhieuNhap_ChiTietDataTable.Clear();
                foreach (var row in phieuNhapChiTiet)
                {
                    danhSachPhieuNhap_ChiTietDataTable.AddDanhSachPhieuNhap_ChiTietRow(row.ID,
                    row.PhieuNhapID,
                    row.SanPhamID,
                    row.TenSanPham,
                    row.SoLuongNhap,
                    row.DonGiaNhap,
                    row.ThanhTien);
                }
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsPhieuNhap_ChiTiet";
                reportDataSource.Value = danhSachPhieuNhap_ChiTietDataTable;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptInPhieuNhap.rdlc");
                IList<ReportParameter> param = new List<ReportParameter>
                    {
                    new ReportParameter("NgayNhap", string.Format("Ngày {0} Tháng {1} Năm {2}",phieuNhap.NgayLap.Day,phieuNhap.NgayLap.Month,phieuNhap.NgayLap.Year)),
                    new ReportParameter("TenNhaCungCap", phieuNhap.NhaCungCap.TenNhaCungCap),
                    new ReportParameter("TheoMaSoPhieu", phieuNhap.PhieuNhap_ChiTiet.Count(r => r.PhieuNhapID == id).ToString()),
                    new ReportParameter("DiaChi", phieuNhap.NhaCungCap.DiaChi),
                    new ReportParameter("SoDienThoai", phieuNhap.NhaCungCap.DienThoai),
                    new ReportParameter("TongTien", phieuNhap.PhieuNhap_ChiTiet.Where(r => r.PhieuNhapID == id).Sum(r => r.SoLuongNhap * r.DonGiaNhap).ToString())
                };
                reportViewer1.LocalReport.SetParameters(param);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
        }
    }
}
