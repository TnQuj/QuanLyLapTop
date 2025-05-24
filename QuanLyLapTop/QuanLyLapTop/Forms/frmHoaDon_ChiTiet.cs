
using Microsoft.EntityFrameworkCore;
using QuanLyLapTop.Data;
using System.ComponentModel;
using System.Data;

namespace QuanLyLapTop.Forms
{
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        BindingList<HoaDon_ChiTiet> hoaDonChiTiet = new BindingList<HoaDon_ChiTiet>();
        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            InitializeComponent();
            id = maHoaDon;
        }
        public void LayNhanVienVaoComBoBox()
        {
            cboNhanVien.DataSource = context.NhanVien.ToList();
            cboNhanVien.ValueMember = "ID";
            cboNhanVien.DisplayMember = "HoVaTen";
        }
        public void LayKhachHangVaoComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.DisplayMember = "HoVaTen";
        }
        public void LaySanPhamVaoComboBox()
        {
            var danhSachSanPham = context.SanPham.Include(sp => sp.KhuyenMai).ToList();
            var sanPhams = context.SanPham.ToList();
            cboSanPham.DataSource = sanPhams;
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void LayHinhThucThanhToanVaoComboBox()
        {
            var dsHinhThuc = context.HoaDon
                .Select(hd => hd.HinhThucThanhToan)
                .Distinct()
                .ToList();

            cboHinhThucThanhToan.DataSource = dsHinhThuc;
            cboHinhThucThanhToan.DisplayMember = null;
            cboHinhThucThanhToan.ValueMember = null;
        }
        public void BatTatChucNang()
        {
            // Bật tắt chức năng khi Thêm hóa đơn
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                // Xóa trắng các trường
                cboKhachHang.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                cboHinhThucThanhToan.Text = "";
                txtGiamGia.Text = "";
                txtGiaSauKhiGiam.Text = "";
                numSoLuongBan.Value = 1;
                numDonGiaBan.Value = 0;
            }
            // Nút lưu và xóa chỉ sáng khi có sản phẩm
            btnLuuHoaDon.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }
        private void frmHoaDon_ChiTiet_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LayKhachHangVaoComboBox();
            LayNhanVienVaoComBoBox();
            LaySanPhamVaoComboBox();
            LayHinhThucThanhToanVaoComboBox();
            txtGiamGia.Enabled = false;
            txtGiaSauKhiGiam.Enabled = false;

            if (id != 0)
            {
                var ct = context.HoaDon_ChiTiet
                .Where(r => r.HoaDonID == id)
                .Include(r => r.SanPham) 
                .Select(r => new HoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    TenSanPham = r.SanPham.TenSanPham!,
                    GiamGia = 0,
                    GiaSauKhiGiam = r.DonGiaBan,
                    ThanhTien = r.SoLuongBan * r.GiaSauKhiGiam,
                })
                .ToList();

                foreach (var item in ct)
                {
                    // Lấy thông tin sản phẩm và khuyến mãi từ SanPham
                    var sanPham = context.SanPham
                        .Where(sp => sp.ID == item.SanPhamID)
                        .Select(sp => new
                        {
                            sp.KhuyenMai,  
                            sp.KhuyenMai!.GiamGia
                        })
                        .FirstOrDefault();

                    if (sanPham != null && sanPham.KhuyenMai != null) 
                    {
                        item.GiamGia = sanPham.KhuyenMai.GiamGia ;
                        double tlgg =Convert.ToDouble(item.GiamGia / 100.0);
                        item.GiaSauKhiGiam = item.DonGiaBan * (1 - tlgg);
                        if (item.GiaSauKhiGiam < 0) item.GiaSauKhiGiam = 0;
                        item.ThanhTien = item.SoLuongBan * item.GiaSauKhiGiam; 
                    }
                    else
                    {
                        item.GiamGia = 0; // Nếu không có khuyến mãi, giảm giá = 0
                        item.GiaSauKhiGiam = item.DonGiaBan; // Giá bán gốc
                        item.ThanhTien = item.SoLuongBan * item.DonGiaBan; // Thành tiền theo giá gốc
                    }
                }

                // BindingList cho DataGridView
                hoaDonChiTiet = new BindingList<HoaDon_ChiTiet>(ct);
                dataGridView.DataSource = hoaDonChiTiet;

                // Dùng BindingSource để hỗ trợ tự động cập nhật khi chọn dòng khác
                var bindingSource = new BindingSource();
                bindingSource.DataSource = hoaDonChiTiet;

                // Gán BindingSource cho DataGridView
                dataGridView.DataSource = bindingSource;

                // Gán DataBindings cho các controls từ BindingSource (chứ không phải từ ct trực tiếp)
                cboSanPham.DataBindings.Clear();
                cboSanPham.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

                numSoLuongBan.DataBindings.Clear();
                numSoLuongBan.DataBindings.Add("Value", bindingSource, "SoLuongBan", false, DataSourceUpdateMode.OnPropertyChanged);

                numDonGiaBan.DataBindings.Clear();
                numDonGiaBan.DataBindings.Add("Value", bindingSource, "DonGiaBan", false, DataSourceUpdateMode.OnPropertyChanged);

                txtGiamGia.DataBindings.Clear();
                txtGiamGia.DataBindings.Add("Text", bindingSource, "GiamGia", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0.##");

                txtGiaSauKhiGiam.DataBindings.Clear();
                txtGiaSauKhiGiam.DataBindings.Add("Text", bindingSource, "GiaSauKhiGiam", true, DataSourceUpdateMode.OnPropertyChanged, "0", "0,0 VNĐ");

                hoaDonChiTiet = new BindingList<HoaDon_ChiTiet>(ct);
            }

            // Gán dữ liệu cho DataGridView
            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();
        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); cboSanPham.Focus();
            }
            else if (numSoLuongBan.Value <= 0)
                MessageBox.Show("Số lượng bán phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numDonGiaBan.Value <= 0)
                MessageBox.Show("Đơn giá bán sản phẩm phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue!.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.SanPhamID == maSanPham);
                // Nếu đã tồn tại sản phẩm thì cập nhật thông tin
                if (chiTiet != null)
                {
                    int soLuong = Convert.ToInt16(numSoLuongBan.Value);
                    int donGia = Convert.ToInt32(numDonGiaBan.Value);
                    double giamGia = 0;
                    double giaSauGiam = donGia;

                    // Kiểm tra khuyến mãi
                    var sanPham = context.SanPham
                        .Where(sp => sp.ID == maSanPham)
                        .Select(sp => new
                        {
                            sp.KhuyenMai
                        })
                        .FirstOrDefault();

                    if (sanPham != null && sanPham.KhuyenMai != null)
                    {
                        giamGia = sanPham.KhuyenMai.GiamGia / 100.0; // ví dụ: 0.2
                        giaSauGiam = donGia * (1 - giamGia);
                    }
                    chiTiet.SoLuongBan = soLuong;
                    chiTiet.DonGiaBan = donGia;
                    chiTiet.GiamGia = giamGia * 100; // phần trăm
                    chiTiet.GiaSauKhiGiam = giaSauGiam;
                    chiTiet.ThanhTien = soLuong * giaSauGiam;

                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    int soLuong = Convert.ToInt32(numSoLuongBan.Value);
                    int donGia = Convert.ToInt32(numDonGiaBan.Value);
                    double giamGia = 0;
                    double giaSauGiam = donGia;

                    // Kiểm tra khuyến mãi
                    var sanPham = context.SanPham
                        .Where(sp => sp.ID == maSanPham)
                        .Select(sp => new
                        {
                            sp.KhuyenMai
                        })
                        .FirstOrDefault();

                    if (sanPham != null && sanPham.KhuyenMai != null)
                    {
                        giamGia = sanPham.KhuyenMai.GiamGia / 100.0; // ví dụ: 0.2
                        giaSauGiam = donGia * (1 - giamGia);
                    }
                    // Nếu chưa có sản phẩm nào
                    HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = soLuong,
                        DonGiaBan = donGia,
                        GiamGia = giamGia,
                        GiaSauKhiGiam = giaSauGiam,
                        ThanhTien = soLuong * giaSauGiam
                    };
                    hoaDonChiTiet.Add(ct);
                }
                BatTatChucNang();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                // Lấy chỉ số dòng đang chọn 
                int selectedIndex = dataGridView.CurrentRow.Index;

                // Kiểm tra chỉ số hợp lệ
                if (selectedIndex >= 0 && selectedIndex < hoaDonChiTiet.Count)
                {
                    // Xóa mục tương ứng trong danh sách
                    hoaDonChiTiet.RemoveAt(selectedIndex);

                    // Cập nhật lại trạng thái nút
                    BatTatChucNang();

                    // Nếu còn dòng, tự chọn lại dòng gần nhất
                    if (hoaDonChiTiet.Count > 0)
                    {
                        int newIndex = Math.Min(selectedIndex, hoaDonChiTiet.Count - 1);
                        dataGridView.ClearSelection();
                        dataGridView.Rows[newIndex].Selected = true;
                        dataGridView.CurrentCell = dataGridView.Rows[newIndex].Cells[1];
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên lập hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboKhachHang.Text))
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(cboHinhThucThanhToan.Text))
                MessageBox.Show("Vui lòng chọn hình thức thanh toán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Kiểm tra trước: số lượng tồn kho đủ  không?
                foreach (var item in hoaDonChiTiet)
                {
                    var sanPham = context.SanPham.Find(item.SanPhamID);
                    if (sanPham == null)
                    {
                        MessageBox.Show($"Sản 1phẩm {item.TenSanPham} không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (sanPham.SoLuongTon < item.SoLuongBan)
                    {
                        MessageBox.Show($"Sản phẩm {item.TenSanPham} chỉ còn {sanPham.SoLuongTon} cái trong kho, không đủ bán {item.SoLuongBan} cái.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (id != 0) // Cập nhật hóa đơn cũ
                {
                    HoaDon hd = context.HoaDon.Find(id)!;
                    if (hd != null)
                    {
                        // Cập nhật hóa đơn tổng
                        hd.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue?.ToString());
                        hd.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue?.ToString());
                        hd.HinhThucThanhToan = cboHinhThucThanhToan.SelectedValue?.ToString();
                        hd.GhiChuHoaDon = txtGhiChuHoaDon.Text;
                        context.HoaDon.Update(hd);

                        // Xóa chi tiết cũ
                        var old = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).ToList();
                        context.HoaDon_ChiTiet.RemoveRange(old);

                        // Thêm lại chi tiết mới và trừ tồn kho
                        foreach (var item in hoaDonChiTiet)
                        {
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                            {
                                HoaDonID = id,
                                SanPhamID = item.SanPhamID,
                                SoLuongBan = item.SoLuongBan,
                                DonGiaBan = item.DonGiaBan,
                                GiamGia = item.GiamGia,
                                GiaSauKhiGiam = item.GiaSauKhiGiam,
                                ThanhTien = item.ThanhTien,
                                TenSanPham = item.TenSanPham
                            };
                            context.HoaDon_ChiTiet.Add(ct);

                            var sanPham = context.SanPham.Find(item.SanPhamID);
                            if (sanPham != null)
                            {
                                sanPham.SoLuongTon -= item.SoLuongBan;
                                if (sanPham.SoLuongTon < 0)
                                    sanPham.SoLuongTon = 0;
                                context.SanPham.Update(sanPham);
                            }
                        }
                        context.SaveChanges();
                    }
                }
                else // Thêm mới hóa đơn
                {
                    HoaDon hd = new HoaDon
                    {
                        NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue?.ToString()),
                        KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue?.ToString()),
                        HinhThucThanhToan = cboHinhThucThanhToan.SelectedValue?.ToString(),
                        NgayLap = DateTime.Now,
                        GhiChuHoaDon = txtGhiChuHoaDon.Text
                    };
                    context.HoaDon.Add(hd);
                    context.SaveChanges();

                    foreach (var item in hoaDonChiTiet)
                    {
                        HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                        {
                            HoaDonID = hd.ID,
                            SanPhamID = item.SanPhamID,
                            SoLuongBan = item.SoLuongBan,
                            DonGiaBan = item.DonGiaBan,
                            GiamGia = item.GiamGia,
                            GiaSauKhiGiam = item.GiaSauKhiGiam,
                            ThanhTien = item.ThanhTien,
                            TenSanPham = item.TenSanPham
                        };
                        context.HoaDon_ChiTiet.Add(ct);

                        var sanPham = context.SanPham.Find(item.SanPhamID);
                        if (sanPham != null)
                        {
                            sanPham.SoLuongTon -= item.SoLuongBan;
                            if (sanPham.SoLuongTon < 0)
                                sanPham.SoLuongTon = 0;
                            context.SanPham.Update(sanPham);
                        }
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Đã lưu hóa đơn và cập nhật tồn kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmHoaDon hoaDon = new frmHoaDon();
                hoaDon.Show();
            }
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue.ToString());
                var sanPham = context.SanPham
                    .Include(sp => sp.KhuyenMai)
                    .FirstOrDefault(sp => sp.ID == maSanPham);

                if (sanPham != null)
                {
                    // Hiển thị giá gốc
                    numDonGiaBan.Value = Convert.ToDecimal(sanPham.GiaBan);

                    double giamGia = 0;
                    if (sanPham.KhuyenMai != null)
                    {
                        giamGia = sanPham.KhuyenMai.GiamGia;
                        txtGiamGia.Text = giamGia.ToString("0.##") + " %";
                    }
                    else
                    {
                        txtGiamGia.Text = "0 %";
                    }
                    double giaGoc = Convert.ToDouble(sanPham.GiaBan);
                    double giaSauGiam = giaGoc - (giaGoc * giamGia / 100);

                    txtGiaSauKhiGiam.Text = giaSauGiam.ToString("N0") + " VND";
                }
            }
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = (DataGridView)sender;

            if (e.Value != null)
            {
                string columnName = dgv.Columns[e.ColumnIndex].Name;

                if (columnName == "DonGiaBan" || columnName == "GiaSauKhiGiam" || columnName == "ThanhTien")
                {
                    if (decimal.TryParse(e.Value.ToString(), out decimal value))
                    {
                        e.Value = string.Format("{0:#,0} VND", value);
                        e.FormattingApplied = true;

                        // Màu cho từng cột
                        if (columnName == "DonGiaBan")
                            e.CellStyle.ForeColor = System.Drawing.Color.Red;
                        else if (columnName == "GiaSauKhiGiam" || columnName == "ThanhTien")
                            e.CellStyle.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn quay lại trang hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var frmHoaDon = Application.OpenForms["frmHoaDon"];
                if (frmHoaDon != null)
                {
                    frmHoaDon.Show();
                    frmHoaDon.Activate();
                }
                else
                {
                    frmHoaDon hoaDon = new frmHoaDon();
                    hoaDon.Show();
                }
                this.Close(); // Close luôn form con
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();
            var sp = context.SanPham
                .Where(r => r.TenSanPham!.Contains(tuKhoa)).ToList();
            dataGridView.DataSource = sp;
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
