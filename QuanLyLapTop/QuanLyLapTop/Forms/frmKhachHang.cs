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
namespace QuanLyLapTop.Forms
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
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
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            var kh = context.KhachHang.ToList();
            dataGridView.DataSource = kh;

            //đổ dữ liệu lên các textbox
            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", kh, "HoVaTen", false, DataSourceUpdateMode.Never);
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", kh, "DienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", kh, "DiaChi", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = 0;
            txtHoVaTen.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                var kh = context.KhachHang.Find(id)!;
                if (kh != null)
                {
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thành công - " + HoVaTen.Name);
                    frmKhachHang_Load(sender, e);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
            txtHoVaTen.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtHoVaTen.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoVaTen.Text))
            { MessageBox.Show("Bạn chưa nhập họ và tên"); txtHoVaTen.Focus(); return; }
            else if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập điện thoại");txtDienThoai.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");txtDiaChi.Focus();return;
            }
            else
            {
                if(id == 0)
                {
                    KhachHang kh = new KhachHang();
                    kh.HoVaTen = txtHoVaTen.Text;
                    kh.DienThoai = txtDienThoai.Text;
                    kh.DiaChi = txtDiaChi.Text;
                    context.KhachHang.Add(kh);
                    context.SaveChanges();
                }
                else
                {
                    var kh = context.KhachHang.Find(id);
                    if (kh != null)
                    {
                        kh.HoVaTen = txtHoVaTen.Text;
                        kh.DienThoai = txtDienThoai.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        context.KhachHang.Update(kh);
                        context.SaveChanges();
                    }
                }
                context.SaveChanges();
                frmKhachHang_Load(sender, e);
                MessageBox.Show("Lưu thành công");
                BatTatChucNang(false);
            }


        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmKhachHang_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var kh = context.KhachHang
                .Where(x => x.HoVaTen.Contains(txtTuKhoa.Text) || x.DienThoai!.Contains(txtTuKhoa.Text) || x.DiaChi!.Contains(txtTuKhoa.Text))
                .ToList();
            dataGridView.DataSource = kh;
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {btnTimKiem_Click(sender, e); }
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
                                KhachHang kh = new KhachHang();
                                kh.HoVaTen = r["HoVaTen"].ToString() ?? "N/A";
                                kh.DienThoai = r["DienThoai"].ToString() ?? "N/A";
                                kh.DiaChi = r["DiaChi"].ToString() ?? "N/A";
                                context.KhachHang.Add(kh);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmKhachHang_Load(sender, e);
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
            saveFileDialog.FileName = "KhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[4] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("HoVaTen", typeof(string)),
                    new DataColumn("DienThoai", typeof(string)),
                    new DataColumn("DiaChi", typeof(string))
                    });
                    var kh = context.KhachHang.ToList();
                    if (kh != null)
                    {
                        foreach (var p in kh)
                            table.Rows.Add(p.ID, p.HoVaTen, p.DienThoai, p.DiaChi);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
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
