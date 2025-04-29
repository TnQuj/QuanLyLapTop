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
using QuanLyLapTop.Data;
using BC = BCrypt.Net.BCrypt;
namespace QuanLyLapTop.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtHoVaTen.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtSoDienThoai.Enabled = giaTri;
            txtTenDangNhap.Enabled = giaTri;
            txtMatKhau.Enabled = giaTri;
            cboQuyenHan.Enabled = giaTri;

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            var nv = context.NhanVien.ToList();
            dataGridView.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", nv, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", nv, "DiaChi", false, DataSourceUpdateMode.Never);

            txtSoDienThoai.DataBindings.Clear();
            txtSoDienThoai.DataBindings.Add("Text", nv, "DienThoai", false, DataSourceUpdateMode.Never);

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", nv, "TenDangNhap", false, DataSourceUpdateMode.Never);

            cboQuyenHan.DataBindings.Clear();
            cboQuyenHan.DataBindings.Add("Text", nv, "QuyenHan", false, DataSourceUpdateMode.Never);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            txtHoVaTen.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            cboQuyenHan.Text = "";
            txtHoVaTen.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn xóa chứ?","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question) ==  DialogResult.OK)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                var nv = context.NhanVien.Find(id);
                if (nv != null)
                {
                    context.NhanVien.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công");
                    frmNhanVien_Load(sender, e);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                MessageBox.Show("Họ tên không được bỏ trống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); txtHoVaTen.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được bỏ trống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); txtDiaChi.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được bỏ trống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); txtSoDienThoai.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); txtTenDangNhap.Focus(); return;
            }
            else if (string.IsNullOrEmpty(cboQuyenHan.Text))
            {
                MessageBox.Show("Chưa phân quyền cho nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); cboQuyenHan.Focus(); return;
            }
            else
            {
                if (id == 0)
                {
                    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                        MessageBox.Show("Vui lòng nhập mật khẩu?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DienThoai = txtSoDienThoai.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = BC.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? "admin" : "user";
                        context.NhanVien.Add(nv);
                        context.SaveChanges();
                    }

                }
                else
                {
                    var nv = context.NhanVien.Find(id);
                    if (nv != null)
                    {
                        nv.HoVaTen = txtHoVaTen.Text;
                        nv.DiaChi = txtDiaChi.Text;
                        nv.DienThoai = txtSoDienThoai.Text;
                        nv.TenDangNhap = txtTenDangNhap.Text;
                        nv.MatKhau = txtMatKhau.Text;
                        nv.QuyenHan = cboQuyenHan.SelectedIndex == 0 ? "admin" : "user";
                        context.NhanVien.Update(nv);

                        if (string.IsNullOrEmpty(txtMatKhau.Text))
                            context.Entry(nv).Property(x => x.MatKhau).IsModified = false; // Giữ nguyên mật khẩu cũ
                        else
                            nv.MatKhau = BC.HashPassword(txtMatKhau.Text); // Cập nhật mật khẩu mới
                        context.SaveChanges();
                    }
                }
                frmNhanVien_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmNhanVien_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var nv = context.NhanVien.Where(x => x.HoVaTen.Contains(txtTuKhoa.Text) || x.DienThoai!.Contains(txtTuKhoa.Text) || x.DiaChi!.Contains(txtTuKhoa.Text ) || x.TenDangNhap!.Contains(txtTuKhoa.Text) || x.QuyenHan!.Contains(txtTuKhoa.Text)).ToList();
            dataGridView.DataSource = nv;
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
                        string readRange = "1:1";
                        DataTable table = new DataTable();
                        // Đọc Sheet 1 và lưu dữ liệu vào một DataTable tạm
                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            // Đọc dòng tiêu đề (dòng đầu tiên)
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                    table.Columns.Add(cell.Value.ToString()); firstRow = false;
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
                        // Đọc dữ liệu từ DataTable tạm và lưu vào CSDL
                        if (table.Rows.Count > 0)
                        {
                            foreach (DataRow r in table.Rows)
                            {
                                NhanVien nv = new NhanVien();
                                nv.HoVaTen = r["HoVaTen"].ToString() ?? "N/A";
                                nv.DiaChi = r["DiaChi"].ToString() ?? "N/A";
                                nv.DienThoai = r["DienThoai"].ToString() ?? "N/A";
                                nv.TenDangNhap = r["TenDangNhap"].ToString() ?? "N/A";
                                nv.MatKhau = r["MatKhau"].ToString() ?? "N/A";
                                nv.QuyenHan = r["QuyenHan"].ToString() ?? "N/A";
                                context.NhanVien.Add(nv);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmNhanVien_Load(sender, e);
                        }
                        if (firstRow)
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
            SaveFileDialog saveFileDialog = new SaveFileDialog(); saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "NhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[7] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("HoVaTen", typeof(string)),
                    new DataColumn("DiaChi", typeof(string)),
                    new DataColumn("DienThoai", typeof(string)),
                    new DataColumn("TenDangNhap", typeof(string)),
                    new DataColumn("MatKhau", typeof(string)),
                    new DataColumn("QuyenHan", typeof(string)),
                });
                    var nv = context.NhanVien.ToList();
                    if (nv != null)
                    {
                        foreach (var p in nv)
                            table.Rows.Add(p.ID, p.HoVaTen , p.DiaChi, p.DienThoai, p.TenDangNhap, p.MatKhau, p.QuyenHan);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
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
