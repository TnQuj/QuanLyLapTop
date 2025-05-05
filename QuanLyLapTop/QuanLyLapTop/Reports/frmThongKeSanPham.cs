using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyLapTop.Data;
using static QuanLyLapTop.Reports.QLBHDataSet;
namespace QuanLyLapTop.Reports
{
    public partial class frmThongKeSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachSanPhamDataTable dsSanPhamDataTable = new QLBHDataSet.DanhSachSanPhamDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        int id;
        public frmThongKeSanPham(int maSanPham = 0)
        {
            InitializeComponent();
            id = maSanPham;
        }

        public void getHangSanXuat()
        {
            var hangSanXuat = context.HangSanXuat.ToList();
            cboHangSanXuat.DataSource = hangSanXuat;
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.ValueMember = "ID";
        }

        public void getLoaiSanPham()
        {
            var loaiSanPham = context.LoaiSanPham.ToList();
            cboLoaiSanPham.DataSource = loaiSanPham;
            cboLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cboLoaiSanPham.ValueMember = "ID";
        }

        public void getNhaCungCap()
        {
            var nhaCungCap = context.NhaCungCap.ToList();
            cboNhaCungCap.DataSource = nhaCungCap;
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            getHangSanXuat();
            getLoaiSanPham();
            getNhaCungCap();
            var phieuNhap = context.PhieuNhap.Include(r => r.NhanVien).Include(r => r.PhieuNhap_ChiTiet)
                                .Where(r => r.ID == id).SingleOrDefault();
           
                var danhsachSanPham = context.SanPham.Select(sp => new
            {
                sp.ID,
                sp.TenSanPham,
                sp.GiaBan,
                sp.SoLuongTon,
                sp.NgayNhap,
                sp.HinhAnh,
                sp.MoTa,
                sp.HangSanXuatID,
                sp.HangSanXuat!.TenHangSanXuat,
                sp.LoaiSanPhamID,
                sp.LoaiSanPham!.TenLoaiSanPham,
                sp.NhaCungCapID,
                sp.NhaCungCap!.TenNhaCungCap,
                sp.KhuyenMaiID,
                sp.KhuyenMai!.TenKhuyenMai,
            }).ToList();
            dsSanPhamDataTable.Clear();
            foreach (var row in danhsachSanPham)
            {
                dsSanPhamDataTable.AddDanhSachSanPhamRow(
                    row.ID,
                    row.TenSanPham,
                    row.GiaBan,
                    row.SoLuongTon,
                    row.NgayNhap,
                    row.HinhAnh,
                    row.MoTa,
                    row.HangSanXuatID,
                    row.TenHangSanXuat,
                    row.LoaiSanPhamID,
                    row.TenLoaiSanPham,
                    row.NhaCungCapID,
                    row.TenNhaCungCap,
                    row.KhuyenMaiID,
                    row.TenKhuyenMai
                );

            }
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsSanPham";
            reportDataSource.Value = dsSanPhamDataTable;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");
            IList<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("MoTaKetQuaHienThi", "(Tất cả các sản phẩm)"),
                new ReportParameter("NgayLap",
                    phieuNhap?.NgayLap != null
                        ? string.Format("Ngày {0} Tháng {1} Năm {2}", phieuNhap.NgayLap.Day, phieuNhap.NgayLap.Month, phieuNhap.NgayLap.Year)
                        : "Không xác định"),

                new ReportParameter("HoVaTenNhanVien",
                    phieuNhap?.NhanVien?.HoVaTen ?? "Không rõ"),

                new ReportParameter("ChucVu",
                    phieuNhap?.NhanVien?.QuyenHan ?? "Không rõ")
            };

            reportViewer1.LocalReport.SetParameters(param);
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            if (cboHangSanXuat.Text == "" && cboLoaiSanPham.Text == "" && cboNhaCungCap.Text == "")
            {
                frmThongKeSanPham_Load(sender, e);
            }
            else
            {
                var danhsachSanPham = context.SanPham.Select(sp => new
                {
                    sp.ID,
                    sp.TenSanPham,
                    sp.GiaBan,
                    sp.SoLuongTon,
                    sp.NgayNhap,
                    sp.HinhAnh,
                    sp.MoTa,
                    sp.HangSanXuatID,
                    sp.HangSanXuat!.TenHangSanXuat,
                    sp.LoaiSanPhamID,
                    sp.LoaiSanPham!.TenLoaiSanPham,
                    sp.NhaCungCapID,
                    sp.NhaCungCap!.TenNhaCungCap,
                    sp.KhuyenMaiID,
                    sp.KhuyenMai!.TenKhuyenMai,
                });
                string hangSanXuat = null!;
                string loaiSanPham = null!;
                string nhaCungCap = null!;

                if (cboHangSanXuat.Text != "")
                {
                    int hangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue?.ToString());
                    hangSanXuat = "Hãng sản xuất: " + cboHangSanXuat.Text;
                    danhsachSanPham = danhsachSanPham.Where(sp => sp.HangSanXuatID == hangSanXuatID);
                }

                if (cboLoaiSanPham.Text != "")
                {
                    int loaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue?.ToString());
                    loaiSanPham = "Loại sản phẩm: " + cboLoaiSanPham.Text;
                    danhsachSanPham = danhsachSanPham.Where(sp => sp.LoaiSanPhamID == loaiSanPhamID);
                }

                if (cboNhaCungCap.Text != "")
                {
                    int nhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue?.ToString());
                    nhaCungCap = "Nhà cung cấp: " + cboNhaCungCap.Text;
                    danhsachSanPham = danhsachSanPham.Where(sp => sp.NhaCungCapID == nhaCungCapID);
                }
                dsSanPhamDataTable.Clear();

                foreach (var row in danhsachSanPham)
                {
                    dsSanPhamDataTable.AddDanhSachSanPhamRow(
                        row.ID,
                        row.TenSanPham,
                        row.GiaBan,
                        row.SoLuongTon,
                        row.NgayNhap,
                        row.HinhAnh,
                        row.MoTa,
                        row.HangSanXuatID,
                        row.TenHangSanXuat,
                        row.LoaiSanPhamID,
                        row.TenLoaiSanPham,
                        row.NhaCungCapID,
                        row.TenNhaCungCap,
                        row.KhuyenMaiID,
                        row.TenKhuyenMai
                    );
                }

                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "dsSanPham";
                reportDataSource.Value = dsSanPhamDataTable;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc"); ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + hangSanXuat + " - " + loaiSanPham + " - " + nhaCungCap + ")");
                reportViewer1.LocalReport.SetParameters(reportParameter);
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }

        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            frmThongKeSanPham_Load(sender, e);
        }
    }
}
