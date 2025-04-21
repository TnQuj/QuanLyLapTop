using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if(string.IsNullOrEmpty(txtTenHangSanXuat.Text.Trim()))
            {
                MessageBox.Show("Tên hãng sản xuất không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHangSanXuat.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(txtQuocGia.Text.Trim()))
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

        }
    }
}
