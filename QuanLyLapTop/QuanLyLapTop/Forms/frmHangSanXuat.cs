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
using SlugGenerator;
namespace QuanLyLapTop.Forms
{
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id; // Lấy mã sản phẩm (dùng cho Sửa và Xóa)
        string imageName = "no-image.jpg"; // Hình ảnh mặc định
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "images");

        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;

            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenHangSanXuat.Enabled = giaTri;
            txtQuocGia.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
        }
        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            var hsx = context.HangSanXuat.ToList();
            dataGridView.DataSource = hsx;

            txtTenHangSanXuat.DataBindings.Clear();
            txtTenHangSanXuat.DataBindings.Add("Text", hsx, "TenHangSanXuat", false, DataSourceUpdateMode.Never);

            txtQuocGia.DataBindings.Clear();
            txtQuocGia.DataBindings.Add("Text", hsx, "QuocGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", hsx, "HinhAnh", false, DataSourceUpdateMode.Never);
            hinhAnh.Format += (s, e) =>
            {
                e.Value = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
            };
            picHinhAnh.DataBindings.Add(hinhAnh);

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                string imagePath = Path.Combine(imageFolder, e.Value?.ToString() ?? "");
                if (File.Exists(imagePath))
                {
                    Image image = Image.FromFile(imagePath);
                    image = new Bitmap(image, 24, 24);
                    e.Value = image;
                }
            }
        }

        private void picHinhAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string ext = Path.GetExtension(openFileDialog.FileName);
                // Lưu tên file hình vào biến toàn cục
                imageName = fileName.GenerateSlug() + ext;
                string fileSavePath = Path.Combine(imageFolder, imageName);
                // Giải phóng ảnh cũ nếu có
                if (picHinhAnh.Image != null)
                {
                    picHinhAnh.Image.Dispose();
                    picHinhAnh.Image = null;
                }
                // Tránh copy lên chính file đang mở
                if (!string.Equals(openFileDialog.FileName, fileSavePath, StringComparison.OrdinalIgnoreCase))
                {
                    File.Copy(openFileDialog.FileName, fileSavePath, true);
                }

                // Load ảnh bằng MemoryStream để tránh bị lock
                using (var fs = new FileStream(fileSavePath, FileMode.Open, FileAccess.Read))
                {
                    var ms = new MemoryStream();
                    fs.CopyTo(ms);
                    ms.Position = 0;
                    picHinhAnh.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = 0;
            picHinhAnh.Image = null;
            txtTenHangSanXuat.Clear();
            txtQuocGia.Clear();
            txtTenHangSanXuat.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                var hsx = context.HangSanXuat.Find(id);
                if (hsx != null)
                {
                    // Xóa hình ảnh (nếu có)
                    if (!string.IsNullOrEmpty(hsx.HinhAnh))
                    {
                        string imagePath = Path.Combine(imageFolder, hsx.HinhAnh);
                        if (File.Exists(imagePath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            File.Delete(imagePath);
                        }
                    }
                    context.HangSanXuat.Remove(hsx);
                }
                context.SaveChanges();
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
            txtTenHangSanXuat.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenHangSanXuat.Text.Trim()))
            {
                MessageBox.Show("Tên hãng sản xuất không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangSanXuat.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtQuocGia.Text.Trim()))
            {
                MessageBox.Show("Quốc gia không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuocGia.Focus();
                return;
            }
            else
            {
                if (id == 0)
                {
                    HangSanXuat hsx = new HangSanXuat();
                    hsx.TenHangSanXuat = txtTenHangSanXuat.Text.Trim();
                    hsx.QuocGia = txtQuocGia.Text.Trim();
                    hsx.HinhAnh = imageName;
                    context.HangSanXuat.Add(hsx);
                }
                else
                {
                    var hsx = context.HangSanXuat.Find(id);
                    if (hsx != null)
                    {
                        hsx.TenHangSanXuat = txtTenHangSanXuat.Text.Trim();
                        hsx.QuocGia = txtQuocGia.Text.Trim();
                        hsx.HinhAnh = imageName;
                        context.HangSanXuat.Update(hsx);
                        context.SaveChanges();
                    }
                }
                context.SaveChanges();
                frmHangSanXuat_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var hsx = context.HangSanXuat
                .Where(x => x.TenHangSanXuat!.Contains(txtTuKhoa.Text))
                .ToList();
            dataGridView.DataSource = hsx;
        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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
                                HangSanXuat hsx = new HangSanXuat();
                                hsx.TenHangSanXuat = r["TenHangSanXuat"].ToString() ?? "N/A";
                                hsx.QuocGia = r["QuocGia"].ToString() ?? "N/A";
                                hsx.HinhAnh = r["HinhAnh"].ToString() ?? "N/A";
                                context.HangSanXuat.Add(hsx);
                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmHangSanXuat_Load(sender, e);
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
            saveFileDialog.FileName = "HangSanXuat_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[4] {
                    new DataColumn("ID", typeof(int)),
                    new DataColumn("TenHangSanXuat", typeof(string)),
                    new DataColumn("QuocGia", typeof(string)),
                    new DataColumn("HinhAnh", typeof(string))
                    });
                    var hsx = context.HangSanXuat.ToList();
                    if (hsx != null)
                    {
                        foreach (var p in hsx)
                            table.Rows.Add(p.ID, p.TenHangSanXuat, p.QuocGia, p.HinhAnh);
                    }
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "HangSanXuat");
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
