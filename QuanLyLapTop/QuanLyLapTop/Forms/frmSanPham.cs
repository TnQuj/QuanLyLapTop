using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using QuanLyLapTop.Data;
using QuanLyLapTop.Reports;
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
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                this.Hide();
                using (frmSanPham_ChiTiet chitiet = new frmSanPham_ChiTiet(id))
                {
                    chitiet.ShowDialog();
                }
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
            BatTatChucNang(true);
            txtTenSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells["ID"].Value?.ToString());
                var sp = context.SanPham.Find(id)!;
                if (sp != null)
                {
                    if (!string.IsNullOrEmpty(sp.HinhAnh))
                    {
                        string imagePath = Path.Combine(imageFolder, sp.HinhAnh);
                        if (File.Exists(imagePath))
                        {
                            System.GC.Collect();
                            System.GC.WaitForPendingFinalizers();
                            File.Delete(imagePath);
                        }
                    }
                    //xóa hóa đơn chi tiết
                    //var chiTietHoaDon = context.HoaDon_ChiTiet.Where(x => x.SanPhamID == id).ToList();
                    //context.HoaDon_ChiTiet.RemoveRange(chiTietHoaDon);

                    //xóa phiếu nhập chi tiết
                    var chiTietPhieuNhap = context.PhieuNhap_ChiTiet.Where(x => x.SanPhamID == id).ToList();
                    context.PhieuNhap_ChiTiet.RemoveRange(chiTietPhieuNhap);
                    context.SanPham.Remove(sp);
                }
                context.SaveChanges();
                MessageBox.Show("Xóa thành công");
                frmSanPham_Load(sender, e);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSanPham.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống"); txtTenSanPham.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Giá bán không được để trống"); txtGiaBan.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả không được để trống"); txtMoTa.Focus(); return;
            }
            else if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Nhà cung cấp không được để trống"); cboNhaCungCap.Focus(); return;
            }
            else if (cboHangSanXuat.SelectedValue == null)
            {
                MessageBox.Show("Hãng sản xuất không được để trống"); cboHangSanXuat.Focus(); return;
            }
            else if (cboLoaiSanPham.SelectedValue == null)
            {
                MessageBox.Show("Loại sản phẩm không được để trống"); cboLoaiSanPham.Focus(); return;
            }
            else
            {
                if (id == 0)// Thêm mới
                {
                    SanPham sp = new SanPham();
                    sp.TenSanPham = txtTenSanPham.Text;
                    sp.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                    //sp.SoLuongTon = 0;
                    sp.NgayNhap = dateNgayNhap.Value;
                    sp.HinhAnh = imageName;
                    sp.MoTa = txtMoTa.Text;
                    sp.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                    sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                    sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                    context.SanPham.Add(sp);
                }
                else //Sửa
                {
                    var sp = context.SanPham.Find(id)!;
                    if (sp != null)
                    {
                        sp.TenSanPham = txtTenSanPham.Text;
                        sp.GiaBan = Convert.ToDecimal(txtGiaBan.Text);
                        sp.NgayNhap = dateNgayNhap.Value;
                        sp.HinhAnh = imageName;
                        sp.MoTa = txtMoTa.Text;
                        sp.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                        sp.HangSanXuatID = Convert.ToInt32(cboHangSanXuat.SelectedValue);
                        sp.LoaiSanPhamID = Convert.ToInt32(cboLoaiSanPham.SelectedValue);
                        context.SanPham.Update(sp);
                        context.SaveChanges();
                    }
                }
                frmSanPham_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_Load(sender, e);
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

        private void btnThongKeSanPham_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmThongKeSanPham thongKeSanPham = new frmThongKeSanPham(id))
                {
                    thongKeSanPham.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
