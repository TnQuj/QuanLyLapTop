using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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

namespace QuanLyLapTop.Forms
{
    public partial class frmHoaDon : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public frmHoaDon()
        {
            InitializeComponent();
        }
        public void BatChucNang()
        {
            // Casc nut nay chi sang khi co hoa don
            btnInHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            try
            {
                var hd = context.HoaDon.Select(r => new
                {
                    r.ID,
                    r.NhanVienID,
                    r.KhachHangID,
                    r.NgayLap,
                    r.GhiChuHoaDon,
                    r.HinhThucThanhToan,
                    HoVaTenNhanVien = r.NhanVien.HoVaTen,
                    HoVaTenKhachHang = r.KhachHang.HoVaTen,
                    TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => (r.SoLuongBan) * r.DonGiaBan),
                    XemChiTiet = "Xem chi tiết"
                }).ToList();
                dataGridView.DataSource = hd;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BatChucNang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa hóa đơn đang chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    HoaDon hd = context.HoaDon.Find(id)!;
                    if (hd != null)
                    {
                        // Xóa các chi tiết hóa đơn
                        var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList()!;
                        context.HoaDon_ChiTiet.RemoveRange(ct);
                        // Xóa hóa đơn
                        context.HoaDon.Remove(hd);
                        context.SaveChanges();
                    }
                    frmHoaDon_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet())
            {
                this.Hide();
                chiTiet.ShowDialog();
            }

        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmHoaDon_ChiTiet chiTiet = new frmHoaDon_ChiTiet(id))
                {
                    this.Hide();
                    chiTiet.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var hd = context.HoaDon.Select(r => new
            {
                r.ID,
                r.NgayLap,
                r.KhachHangID,
                r.NhanVienID,
                r.GhiChuHoaDon,
                r.HinhThucThanhToan,
                HoVaTenNhanVien = r.NhanVien.HoVaTen,
                HoVaTenKhachHang = r.KhachHang.HoVaTen,
                TongTienHoaDon = r.HoaDon_ChiTiet.Sum(r => (r.SoLuongBan) * r.DonGiaBan),
                XemChiTiet = "Xem chi tiết"
            }).Where(r => r.HoVaTenNhanVien.Contains(txtTuKhoa.Text) || r.HoVaTenKhachHang!.Contains(txtTuKhoa.Text) || r.HinhThucThanhToan!.Contains(txtTuKhoa.Text) || r.NgayLap.ToString().Contains(txtTuKhoa.Text)).ToList();
            dataGridView.DataSource = hd;

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        #region Xử lý sheet Hóa đơn (Sheet 1)
                        IXLWorksheet sheet1 = workbook.Worksheet(1);
                        bool firstRowHoaDon = true;
                        string readRangeHoaDon = "1:1";
                        DataTable tableHoaDon = new DataTable();
                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowHoaDon)
                            {
                                readRangeHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                    tableHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowHoaDon = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tableHoaDon.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeHoaDon))
                                {
                                    tableHoaDon.Rows[tableHoaDon.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tableHoaDon.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableHoaDon.Rows)
                                {
                                    HoaDon hd = new HoaDon();
                                    hd.ID = Convert.ToInt32(r["ID"].ToString());
                                    hd.NhanVienID = Convert.ToInt32(r["NhanVienID"].ToString());
                                    hd.KhachHangID = Convert.ToInt32(r["KhachHangID"].ToString());
                                    hd.NgayLap = Convert.ToDateTime(r["NgayLap"].ToString());
                                    hd.GhiChuHoaDon = r["GhiChuHoaDon"].ToString();
                                    hd.HinhThucThanhToan = r["HinhThucThanhToan"].ToString();
                                    context.HoaDon.Add(hd);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon OFF");
                                transaction.Commit();
                            }
                        }
                        #endregion
                        #region Xử lý sheet Chi tiết hóa đơn (Sheet 2)
                        IXLWorksheet sheet2 = workbook.Worksheet(2);
                        bool firstRowChiTietHoaDon = true;
                        string readRangeChiTietHoaDon = "1:1";
                        DataTable tableChiTietHoaDon = new DataTable();
                        // Đọc Sheet 2 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet2.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowChiTietHoaDon)
                            {
                                readRangeChiTietHoaDon = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                    tableChiTietHoaDon.Columns.Add(cell.Value.ToString());
                                firstRowChiTietHoaDon = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tableChiTietHoaDon.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangeChiTietHoaDon))
                                {
                                    tableChiTietHoaDon.Rows[tableChiTietHoaDon.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tableChiTietHoaDon.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tableChiTietHoaDon.Rows)
                                {
                                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet();
                                    ct.ID = Convert.ToInt32(r["ID"].ToString());
                                    ct.HoaDonID = Convert.ToInt32(r["HoaDonID"].ToString());
                                    ct.SanPhamID = Convert.ToInt32(r["SanPhamID"].ToString());
                                    ct.SoLuongBan = Convert.ToInt32(r["SoLuongBan"].ToString());
                                    ct.DonGiaBan = Convert.ToInt32(r["DonGiaBan"].ToString());
                                    context.HoaDon_ChiTiet.Add(ct);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon_ChiTiet ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT HoaDon_ChiTiet OFF");
                                transaction.Commit();
                            }
                            MessageBox.Show("Đã nhập thành công " + tableHoaDon.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHoaDon_Load(sender, e);
                        }
                        #endregion
                        if (firstRowHoaDon)
                            MessageBox.Show("Tập tin Excel rỗng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "HoaDon_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xuat du lieu hoa don ra sheet 1( HoaDon)
                    DataTable tableHoaDon = new DataTable();
                    tableHoaDon.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("NhanVienID", typeof(int)),
                        new DataColumn("KhachHangID", typeof(int)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("GhiChuHoaDon", typeof(string))
                    });
                    var hd = context.HoaDon.ToList();
                    if (hd != null)
                    {
                        foreach (var p in hd)
                            tableHoaDon.Rows.Add(p.ID, p.NhanVienID, p.KhachHangID, p.NgayLap, p.GhiChuHoaDon);
                    }
                    // Xuat du lieu HoaDonChiTiet Ra sheet 2
                    DataTable tableHoaDonChiTiet = new DataTable();
                    tableHoaDonChiTiet.Columns.AddRange(new DataColumn[5] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoaDonID", typeof(int)),
                        new DataColumn("SanPhamID", typeof(int)),
                        new DataColumn("SoLuongBan", typeof(int)),
                        new DataColumn("DonGiaBan", typeof(int))
                        });
                    var ct = context.HoaDon_ChiTiet.ToList();
                    if (ct != null)
                    {
                        foreach (var p in ct)
                            tableHoaDonChiTiet.Rows.Add(p.ID, p.HoaDonID, p.SanPhamID, p.SoLuongBan, p.DonGiaBan);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tableHoaDon, "HoaDon");
                        sheet1.Columns().AdjustToContents();
                        var sheet2 = wb.Worksheets.Add(tableHoaDonChiTiet, "HoaDon_ChiTiet");
                        sheet2.Columns().AdjustToContents();
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

    }
}
