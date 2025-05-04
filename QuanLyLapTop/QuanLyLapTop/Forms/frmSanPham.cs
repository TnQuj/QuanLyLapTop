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
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
        BindingList<SanPham> SanPham = new BindingList<SanPham>();
        public void BatTatChucNang(bool giaTri)
        {
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnThem.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
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
            txtGiamGia.Enabled = giaTri;
            cboKhuyenMai.Enabled = giaTri;
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
        public void LayKhuyenMaiVaoComBoBox()
        {
            cboKhuyenMai.DataSource = context.KhuyenMai.ToList();
            cboKhuyenMai.ValueMember = "ID";
            cboKhuyenMai.DisplayMember = "TenKhuyenMai";
        }


        private void frmSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;

            getNhaCungCap();
            getHangSanXuat();
            getLoaiSanPham();
            LayKhuyenMaiVaoComBoBox();

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
                    x.LoaiSanPham!.TenLoaiSanPham,
                    x.KhuyenMaiID,
                    // Tính toán giá sau khi giảm
                    GiaSauKhiGiam = x.KhuyenMaiID > 0
                                    ? x.GiaBan * (decimal)(1 - (double)x.KhuyenMai!.GiamGia / 100)
                                    : x.GiaBan
                }).ToList();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = sp;
            //
            //cboKhuyenMai.DataBindings.Clear();
            //cboKhuyenMai.DataBindings.Add("SelectedValue", sp, "KhuyenMaiID", false, DataSourceUpdateMode.Never);

            txtGiamGia.DataBindings.Clear();
            txtGiamGia.DataBindings.Add("Text", sp, "GiaSauKhiGiam", false, DataSourceUpdateMode.Never);

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", sp, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", sp, "GiaBan", false, DataSourceUpdateMode.Never);

            dateNgayNhap.DataBindings.Clear();
            dateNgayNhap.DataBindings.Add("Text", sp, "NgayNhap", false, DataSourceUpdateMode.Never);

            txtMoTa.DataBindings.Clear();
            txtMoTa.DataBindings.Add("Text", sp, "MoTa", false, DataSourceUpdateMode.Never);

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
            if (dataGridView.CurrentRow != null)
            {
                BatTatChucNang(true);
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                txtTenSanPham.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                MessageBox.Show("Tên sản phẩm không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSanPham.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Giá bán không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtMoTa.Text))
            {
                MessageBox.Show("Mô tả không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTa.Focus();
                return;
            }
            else if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Nhà cung cấp không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNhaCungCap.Focus();
                return;
            }
            else if (cboHangSanXuat.SelectedValue == null)
            {
                MessageBox.Show("Hãng sản xuất không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHangSanXuat.Focus();
                return;
            }
            else if (cboLoaiSanPham.SelectedValue == null)
            {
                MessageBox.Show("Loại sản phẩm không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiSanPham.Focus();
                return;
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView.Rows[e.RowIndex];
                var value = row.Cells["GiaSauKhiGiam"].Value;

                if (value != null && decimal.TryParse(value.ToString(), out decimal giaSauGiam))
                {
                    txtGiamGia.Text = giaSauGiam.ToString("#,##0 'VND'");
                }
                else
                {
                    txtGiamGia.Text = ""; // Không có giá
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);         // Bật các điều khiển nhập liệu
            id = 0;
            dataGridView.Enabled = false;
            // Gán ID = 0 để xác định là thêm mới

            // Xóa các giá trị trên form
            cboLoaiSanPham.SelectedIndex = -1;
            cboHangSanXuat.SelectedIndex = -1;
            cboNhaCungCap.SelectedIndex = -1;
            cboKhuyenMai.SelectedIndex = -1;

            txtTenSanPham.Clear();
            txtGiaBan.Clear();
            txtMoTa.Clear();
            txtGiamGia.Clear();

            dateNgayNhap.Value = DateTime.Now;  // Gán ngày nhập là ngày hiện tại

            picHinhAnh.Image = null;     // Xóa hình ảnh sản phẩm

            toolStrip.Enabled = false;   // Tắt thanh công cụ (nếu đang dùng lưu/xóa)
            txtTenSanPham.Focus();       // Đưa con trỏ về ô tên sản phẩm
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //ToLower() để tránh lỗi phân biệt hoa thường.
            var tuKhoa = txtTuKhoa.Text.ToLower();
            var sp = context.SanPham
                .Where(r =>
                    r.TenSanPham!.ToLower().Contains(tuKhoa) ||
                    r.GiaBan.ToString().Contains(tuKhoa) ||
                    r.HangSanXuat!.TenHangSanXuat!.ToLower().Contains(tuKhoa) ||
                    r.LoaiSanPham!.TenLoaiSanPham!.ToLower().Contains(tuKhoa)
                ).ToList();

            dataGridView.DataSource = sp;

        }

        private void cboKhuyenMai_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cboKhuyenMai.SelectedItem != null || cboKhuyenMai.SelectedIndex != -1)

            {
                // Lấy mã khuyến mãi từ ComboBox
                int maKhuyenMai = Convert.ToInt32(cboKhuyenMai.SelectedValue?.ToString());

                // Tìm khuyến mãi tương ứng từ danh sách khuyến mãi
                var khuyenMai = context.KhuyenMai.Find(maKhuyenMai);

                if (khuyenMai != null)
                {
                    // Lấy giá trị giảm giá từ khuyến mãi (GiamGia là tỷ lệ giảm giá %)
                    var giamGia = khuyenMai.GiamGia;

                    // Lấy giá bán từ txtGiaBan và tính giá sau khi giảm
                    if (double.TryParse(txtGiaBan.Text, out double giaBan))
                    {
                        // Tính giá sau khi giảm
                        double giaSauGiam = giaBan * (1 - giamGia / 100);

                        // Hiển thị giá sau khi giảm vào txtGiamGia
                        txtGiamGia.Text = giaSauGiam.ToString("#,##0 'VND'");  // Định dạng theo số nguyên, nếu cần
                    }
                }
            }
            else
            {
                // Nếu không có khuyến mãi được chọn, xóa nội dung trong txtGiamGia
                txtGiamGia.Clear();
            }

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
                                SanPham sp = new SanPham();
                                sp.ID = Convert.ToInt32(r["ID"].ToString());
                                sp.TenSanPham = r["TenSanPham"].ToString() ?? "N/A";
                                sp.GiaBan = Convert.ToDecimal(r["GiaBan"].ToString());
                                sp.SoLuongTon = Convert.ToInt32(r["SoLuongTon"].ToString());
                                sp.NgayNhap = Convert.ToDateTime(r["NgayNhap"].ToString());
                                sp.MoTa = r["MoTa"].ToString() ?? "N/A";
                                sp.NhaCungCapID = Convert.ToInt32(r["NhaCungCapID"].ToString());
                                sp.HangSanXuatID = Convert.ToInt32(r["HangSanXuatID"].ToString());
                                sp.LoaiSanPhamID = Convert.ToInt32(r["LoaiSanPhamID"].ToString());
                                context.SanPham.Add(sp); // Thêm vào DB

                            }
                            context.SaveChanges();
                            MessageBox.Show("Đã nhập thành công " + table.Rows.Count + " dòng.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frmSanPham_Load(sender, e);
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
            saveFileDialog.FileName = "SanPham_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Đọc dữ liệu từ CSDL và lưu vào một bảng tạm
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[]
                    {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenSanPham", typeof(string)),
                        new DataColumn("GiaBan", typeof(decimal)),
                        new DataColumn ("SoLuongTon", typeof(int)),
                        new DataColumn("NgayNhap", typeof(DateTime)),
                        new DataColumn("HinhAnh",typeof(string)),
                        new DataColumn("MoTa", typeof(string)), 
                        new DataColumn("HangSanXuatID", typeof(int)),
                        new DataColumn("TenHangSanXuat", typeof(string)),
                        new DataColumn("LoaiSanPhamID", typeof(int)),
                        new DataColumn("TenLoaiSanPham", typeof(string)),
                        new DataColumn("NhaCungCapID", typeof(int)),
                        new DataColumn("TenNhaCungCap", typeof(string)),
                        new DataColumn("KhuyenMaiID", typeof(int)),
                        new DataColumn("TenKhuyenMai",typeof(string))
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
                        var sheet = wb.Worksheets.Add(table, "SanPham");
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
