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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;
        string imageName = "no-image.jpg"; // Hình ảnh mặc định
        string imageFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Images");
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            //
            btnSanPhamChiTiet.Enabled = !giaTri;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenSanPham.Enabled = giaTri;
            txtGiaBan.Enabled = giaTri;
            dateNgayNhap.Enabled = giaTri;
            txtMoTa.Enabled = giaTri;
            picHinhAnh.Enabled = giaTri;
            cboNhaCungCap.Enabled = giaTri;
            cboHangSanXuat.Enabled = giaTri;
            cboLoaiSanPham.Enabled = giaTri;
        }

        public void getNhaCungCap()
        {
            var nhaCungCap = context.NhaCungCap.ToList();
            cboNhaCungCap.DataSource = nhaCungCap;
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";
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

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            getNhaCungCap();
            getHangSanXuat();
            getLoaiSanPham();

            var sp = context.SanPham
                .Select(x => new
                {
                    x.ID,
                    x.TenSanPham,
                    x.GiaBan,
                    x.SoLuongTon,
                    x.NgayNhap,
                    x.HinhAnh,
                    x.MoTa,
                    x.NhaCungCapID,
                    x.NhaCungCap!.TenNhaCungCap,
                    x.HangSanXuatID,
                    x.HangSanXuat!.TenHangSanXuat,
                    x.LoaiSanPhamID,
                    x.LoaiSanPham!.TenLoaiSanPham
                }).ToList();
            dataGridView.DataSource = sp;

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", sp, "GiaBan", false, DataSourceUpdateMode.Never);

            //txtSoLuongTon.DataBindings.Clear();
            //txtSoLuongTon.DataBindings.Add("Text", sp, "SoLuongTon", false, DataSourceUpdateMode.Never);

            dateNgayNhap.DataBindings.Clear();
            dateNgayNhap.DataBindings.Add("Text", sp, "NgayNhap", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", sp, "MoTa", false, DataSourceUpdateMode.Never);

            //
            cboNhaCungCap.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Add("SelectedValue", sp, "NhaCungCapID", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Add("SelectedValue", sp, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            cboLoaiSanPham.DataBindings.Clear();
            cboLoaiSanPham.DataBindings.Add("SelectedValue", sp, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", sp, "HinhAnh", false, DataSourceUpdateMode.Never);
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
        private void dataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        private void btnSanPhamChiTiet_Click(object sender, EventArgs e)
        {
            using (frmSanPham_ChiTiet spct = new frmSanPham_ChiTiet())
            {
                spct.ShowDialog();
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
        }
    }
}
