using ClosedXML.Excel;
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
    public partial class frmKhuyenMai : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        public frmKhuyenMai()
        {
            InitializeComponent();
        }
        private void BatTacChucNang(bool giatri)
        {
            //sáng thêm, xóa, sửa 
            btnThem.Enabled = !giatri;
            btnXoa.Enabled = !giatri;
            btnSua.Enabled = !giatri;
            btnTimKiem.Enabled = !giatri;
            btnNhap.Enabled = !giatri;
            btnXuat.Enabled = !giatri;

            // 
            txtTenKhuyenMai.Enabled = giatri;
            numGiamGia.Enabled = giatri;
            dtpNgayBatDau.Enabled = giatri;
            dtpNgayKetThuc.Enabled = giatri;
            btnLuu.Enabled = giatri;
            btnHuyBo.Enabled = giatri;
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            BatTacChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var km = context.KhuyenMai.ToList();
            dataGridView.DataSource = km;

            txtTenKhuyenMai.DataBindings.Clear();
            txtTenKhuyenMai.DataBindings.Add("Text", km, "TenKhuyenMai", false, DataSourceUpdateMode.Never);

            numGiamGia.DataBindings.Clear();
            numGiamGia.DataBindings.Add("Value", km, "GiamGia", false, DataSourceUpdateMode.Never);

            dtpNgayBatDau.DataBindings.Clear();
            dtpNgayBatDau.DataBindings.Add("Value", km, "NgayBatDau", false, DataSourceUpdateMode.Never);

            dtpNgayKetThuc.DataBindings.Clear();
            dtpNgayKetThuc.DataBindings.Add("Value", km, "NgayKetThuc", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            id = 0;
            BatTacChucNang(true);
            txtTenKhuyenMai.Clear();
            numGiamGia.Value = 0;
            dtpNgayBatDau.Value = DateTime.Today;
            dtpNgayKetThuc.Value = DateTime.Today.AddDays(1); // Tăng 1 ngày
            txtTenKhuyenMai.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTacChucNang(true);
            if (dataGridView.CurrentRow != null)
            {
                BatTacChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                txtTenKhuyenMai.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Xác nhận xóa khuyến mãi " + txtTenKhuyenMai.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                    KhuyenMai km = context.KhuyenMai.Find(id)!;
                    if (km != null)
                    {
                        context.KhuyenMai.Remove(km);
                        context.SaveChanges();
                    }
                    frmKhuyenMai_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một khuyến mãi để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên khuyến mãi
            if (string.IsNullOrEmpty(txtTenKhuyenMai.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập tên khuyến mãi!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhuyenMai.Focus();
                return;
            }
            // Kiểm tra giảm giá phải lớn hơn 0
            if (numGiamGia.Value <= 0)
            {
                MessageBox.Show("Giá trị giảm giá phải lớn hơn 0!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numGiamGia.Focus();
                return;
            }
            // Kiểm tra ngày bắt đầu không nhỏ hơn hôm nay
            if (dtpNgayBatDau.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày hôm nay!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayBatDau.Focus();
                return;
            }
            // Kiểm tra ngày bắt đầu không vượt quá ngày kết thúc
            if (dtpNgayBatDau.Value.Date > dtpNgayKetThuc.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayBatDau.Focus();
                return;
            }
            if (dtpNgayKetThuc.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày hôm nay!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKetThuc.Focus();
                return;
            }
            // Xác nhận lưu dữ liệu
            DialogResult result = MessageBox.Show("Bạn có chắc muốn lưu khuyến mãi này?", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Nếu người dùng chọn No, không thực hiện lưu
            }
            if (id == 0)
            {
                KhuyenMai km = new KhuyenMai();
                km.TenKhuyenMai = txtTenKhuyenMai.Text.Trim();
                km.GiamGia = Convert.ToInt32(numGiamGia.Value);
                km.NgayBatDau = dtpNgayBatDau.Value;
                km.NgayKetThuc = dtpNgayKetThuc.Value;
                context.KhuyenMai.Add(km);
                context.SaveChanges();
            }
            else // khi sửa
            {
                var km = context.KhuyenMai.Find(id);
                if (km != null)
                {
                    km.TenKhuyenMai = txtTenKhuyenMai.Text.Trim();
                    km.GiamGia = Convert.ToInt32(numGiamGia.Value);
                    km.NgayBatDau = dtpNgayBatDau.Value;
                    km.NgayKetThuc = dtpNgayKetThuc.Value;
                    context.KhuyenMai.Update(km);
                    context.SaveChanges();
                }
            }
            frmKhuyenMai_Load(sender, e);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhuyenMai_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn quay lại trang chính không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var mainForm = Application.OpenForms["frmMain"];// kt frmMain co mo chua
                if (mainForm != null)
                {
                    mainForm.Show(); // hien thi lai
                    mainForm.Activate();// dua len truoc
                }
                else
                {
                    frmMain newMainForm = new frmMain();
                    newMainForm.Show();
                }
                this.Close(); // Close luôn form con
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var km = context.KhuyenMai
                    .Where(r => r.TenKhuyenMai.Contains(txtTuKhoa.Text)).ToList();
            dataGridView.DataSource = km;
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
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "";
                        DataTable table = new DataTable();
                        // Đọc Sheet 1 và lưu dữ liệu vào một bảng tạm
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString());
                                firstRow = false;
                            }
                            else // Đọc các dòng nội dung (các dòng tiếp theo)
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                        // Đọc dữ liệu từ bảng tạm và lưu vào CSDL
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                KhuyenMai km = new KhuyenMai();
                                km.TenKhuyenMai = r["TenKhuyenMai"].ToString() ?? "N/A";
                                km.GiamGia = Convert.ToInt32(r["GiamGia"].ToString());
                                km.NgayKetThuc = Convert.ToDateTime(r["NgayBatDau"].ToString());
                                km.NgayKetThuc = Convert.ToDateTime(r["NgayKetThuc"].ToString());
                                context.KhuyenMai.Add(km);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhuyenMai_Load(sender, e);
                        }
                        else
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
            saveFileDialog.FileName = "KhuyenMai_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu từ CSDL và lưu vào một bảng tạm
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenKhuyenMai", typeof(string)),
                        new DataColumn("GiamGia", typeof(double)),
                        new DataColumn ("NgayBatDau", typeof(DateTime)),
                        new DataColumn("NgayKetThuc", typeof(DateTime))
                    });
                    var km = context.KhuyenMai.ToList();
                    if (km != null)
                    {
                        foreach (var p in km)
                            table.Rows.Add(p.ID, p.TenKhuyenMai);
                    }
                    // Gán bảng tạm vào Sheet 1 của tập tin Excel
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhuyenMai");
                        sheet.Columns().AdjustToContents();
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
