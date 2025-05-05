using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyLapTop.Data;
using QuanLyLapTop.Reports;
namespace QuanLyLapTop.Forms
{
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public void BatTatChucNang()
        {
            btnInPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            using (frmPhieuNhap_ChiTiet chitiet = new frmPhieuNhap_ChiTiet())
            {
                this.Close();
                chitiet.ShowDialog();
            }
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            try
            {
                var phieuNhap = context.PhieuNhap.Select(p => new
                {
                    p.ID,
                    p.NhaCungCapID,
                    TenNhaCungCap = p.NhaCungCap.TenNhaCungCap,
                    p.NhanVienID,
                    HoVaTenNhanVien = p.NhanVien.HoVaTen,
                    p.NgayLap,
                    p.GhiChuPhieuNhap,
                    TongTienNhapHang = p.PhieuNhap_ChiTiet.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap),
                }).ToList();
                dataGridView.DataSource = phieuNhap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            BatTatChucNang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmPhieuNhap_ChiTiet chitiet = new frmPhieuNhap_ChiTiet(id))
                {
                    this.Close();
                    chitiet.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    PhieuNhap phieuNhap = context.PhieuNhap.Find(id)!;
                    if (phieuNhap != null)
                    {
                        //xóa phiếu nhập chi tiết 
                        //PhieuNhap_ChiTiet chitiet = context.PhieuNhap_ChiTiet.Where(x => x.PhieuNhapID == id).SingleOrDefault()!;
                        //context.PhieuNhap_ChiTiet.Remove(chitiet);

                        //xóa phiếu nhập
                        context.PhieuNhap.Remove(phieuNhap);
                        context.SaveChanges();

                        MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    frmPhieuNhap_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn quay lại trang chính không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var mainForm = Application.OpenForms["frmMain"];
                if (mainForm != null)
                {
                    mainForm.Show();
                    mainForm.Activate();
                }
                else
                {
                    frmMain newMainForm = new frmMain();
                    newMainForm.Show();
                }
                this.Close(); // Close luôn form con
            }
        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmInPhieuNhap inPhieuNhap = new frmInPhieuNhap(id))
                {
                    inPhieuNhap.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var phieuNhap = context.PhieuNhap.Select(p => new
            {
                p.ID,
                p.NhaCungCapID,
                TenNhaCungCap = p.NhaCungCap.TenNhaCungCap,
                p.NhanVienID,
                HoVaTenNhanVien = p.NhanVien.HoVaTen,
                p.NgayLap,
                p.GhiChuPhieuNhap,
                TongTienNhapHang = p.PhieuNhap_ChiTiet.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap),
            }).Where(p => p.HoVaTenNhanVien.Contains(txtTuKhoa.Text) || p.TenNhaCungCap.Contains(txtTuKhoa.Text) || p.NgayLap.ToString().Contains(txtTuKhoa.Text) || p.GhiChuPhieuNhap!.Contains(txtTuKhoa.Text)).ToList();
            dataGridView.DataSource = phieuNhap;
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
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
                        bool firstRowPhieuNhap = true;
                        string readRangePhieuNhap = "1:1";
                        DataTable tablePhieuNhap = new DataTable();
                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet1.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowPhieuNhap)
                            {
                                readRangePhieuNhap = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangePhieuNhap))
                                    tablePhieuNhap.Columns.Add(cell.Value.ToString());
                                firstRowPhieuNhap = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tablePhieuNhap.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangePhieuNhap))
                                {
                                    tablePhieuNhap.Rows[tablePhieuNhap.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tablePhieuNhap.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tablePhieuNhap.Rows)
                                {
                                    PhieuNhap phieuNhap = new PhieuNhap();
                                    phieuNhap.ID = Convert.ToInt32(r["ID"].ToString());
                                    phieuNhap.NhanVienID = Convert.ToInt32(r["NhanVienID"].ToString());
                                    phieuNhap.NhaCungCapID = Convert.ToInt32(r["NhaCungCapID"].ToString());
                                    phieuNhap.NgayLap = Convert.ToDateTime(r["NgayLap"].ToString());
                                    phieuNhap.GhiChuPhieuNhap = r["GhiChuPhieuNhap"].ToString();
                                    context.PhieuNhap.Add(phieuNhap);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhap ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhap OFF");
                                transaction.Commit();
                            }
                        }
                        #endregion
                        #region Xử lý sheet Chi tiết hóa đơn (Sheet 2)
                        IXLWorksheet sheet2 = workbook.Worksheet(2);
                        bool firstRowPhieuNhapChiTiet = true;
                        string readRangePhieuNhapChiTiet = "1:1";
                        DataTable tablePhieuNhapChiTiet = new DataTable();
                        // Đọc Sheet 2 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in sheet2.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRowPhieuNhapChiTiet)
                            {
                                readRangePhieuNhapChiTiet = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRangePhieuNhapChiTiet))
                                    tablePhieuNhapChiTiet.Columns.Add(cell.Value.ToString());
                                firstRowPhieuNhapChiTiet = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                tablePhieuNhapChiTiet.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRangePhieuNhapChiTiet))
                                {
                                    tablePhieuNhapChiTiet.Rows[tablePhieuNhapChiTiet.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (tablePhieuNhapChiTiet.Rows.Count > 0)
                        {
                            using (var transaction = context.Database.BeginTransaction())
                            {
                                foreach (DataRow r in tablePhieuNhapChiTiet.Rows)
                                {
                                    PhieuNhap_ChiTiet phieuNhapChiTiet = new PhieuNhap_ChiTiet();
                                    phieuNhapChiTiet.ID = Convert.ToInt32(r["ID"].ToString());
                                    phieuNhapChiTiet.PhieuNhapID = Convert.ToInt32(r["PhieuNhapID"].ToString());
                                    phieuNhapChiTiet.SanPhamID = Convert.ToInt32(r["SanPhamID"].ToString());
                                    phieuNhapChiTiet.SoLuongNhap = Convert.ToInt32(r["SoLuongNhap"].ToString());
                                    phieuNhapChiTiet.DonGiaNhap = Convert.ToInt32(r["DonGiaNhap"].ToString());
                                    context.PhieuNhap_ChiTiet.Add(phieuNhapChiTiet);
                                }
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhap_ChiTiet ON");
                                context.SaveChanges();
                                context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT PhieuNhap_ChiTiet OFF");
                                transaction.Commit();
                            }
                            MessageBox.Show("Đã nhập thành công " + tablePhieuNhap.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmPhieuNhap_Load(sender, e);
                        }
                        #endregion
                        if (firstRowPhieuNhap)
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
            saveFileDialog.FileName = "PhieuNhap_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Xuat du lieu hoa don ra sheet 1( HoaDon)
                    DataTable tablePhieuNhap = new DataTable();
                    tablePhieuNhap.Columns.AddRange(new DataColumn[5]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoVaTenNhanVien", typeof(string)),
                        new DataColumn("TenNhaCungCap", typeof(string)),
                        new DataColumn("NgayLap", typeof(DateTime)),
                        new DataColumn("GhiChuPhieuNhap", typeof(string))
                    });
                    var phieuNhap = context.PhieuNhap.Include(p => p.NhanVien).ToList();
                    if (phieuNhap != null)
                    {
                        foreach (var p in phieuNhap)
                        {
                            string hoTenNhanVien = p.NhanVien != null ? p.NhanVien.HoVaTen : "";
                            string tenNhaCungCap = p.NhaCungCap != null ? p.NhaCungCap.TenNhaCungCap : "";
                            tablePhieuNhap.Rows.Add(p.ID, hoTenNhanVien, tenNhaCungCap, p.NgayLap, p.GhiChuPhieuNhap);
                        }
                    }
                    // Xuat du lieu HoaDonChiTiet Ra sheet 2
                    DataTable tablePhieuNhapChiTiet = new DataTable();
                    tablePhieuNhapChiTiet.Columns.AddRange(new DataColumn[4] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenSanPham", typeof(string)),
                        new DataColumn("SoLuongBan", typeof(int)),
                        new DataColumn("DonGiaBan", typeof(int))
                        });
                    var phieuNhapChiTiet = context.PhieuNhap_ChiTiet.ToList();
                    if (phieuNhapChiTiet != null)
                    {
                        foreach (var p in phieuNhapChiTiet)
                        {
                            string tenSanPham = p.SanPham != null ? p.SanPham.TenSanPham! : "";
                            tablePhieuNhapChiTiet.Rows.Add(p.ID, tenSanPham, p.SoLuongNhap, p.DonGiaNhap);
                        }
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet1 = wb.Worksheets.Add(tablePhieuNhap, "PhieuNhap");
                        sheet1.Columns().AdjustToContents();
                        var sheet2 = wb.Worksheets.Add(tablePhieuNhapChiTiet, "PhieuNhap_ChiTiet");
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
    }
}
