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
namespace QuanLyLapTop.Forms
{
    public partial class frmPhieuNhap_ChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        BindingList<DS_PhieuNhap_ChiTiet> dsPhieuNhapChiTiet = new BindingList<DS_PhieuNhap_ChiTiet>();
        string imageName = "no-image.jpg"; // Hình ảnh mặc định

        public frmPhieuNhap_ChiTiet(int maPhieuNhap = 0)
        {
            InitializeComponent();
            id = maPhieuNhap;

        }

        public void getNhanVien()
        {
            cboNhanVien.DataSource = context.NhanVien
            .Select(nv => new { nv.ID, nv.HoVaTen }) // chỉ lấy 2 thuộc tính đơn giản
            .ToList();
            cboNhanVien.DisplayMember = "HoVaTen";
            cboNhanVien.ValueMember = "ID";
        }

        public void getNhaCungCap()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";
        }

        public void getSanPham()
        {
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "ID";
        }

        public void getHangSanXuat()
        {
            cboHangSanXuat.DataSource = context.HangSanXuat.ToList();
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.ValueMember = "ID";
        }

        public void getLoaiSanPham()
        {
            cboLoaiSanPham.DataSource = context.LoaiSanPham.ToList();
            cboLoaiSanPham.DisplayMember = "TenLoaiSanPham";
            cboLoaiSanPham.ValueMember = "ID";
        }

        public void BatTatChucNang()
        {
            if (id == 0 && dataGridView.Rows.Count == 0)
            {
                cboNhaCungCap.Text = "";
                cboNhanVien.Text = "";
                cboSanPham.Text = "";
                numSoLuong.Value = 1;
                numGiaNhap.Value = 0;
            }
            btnLapPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnInPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;

        }

        private void frmPhieuNhap_ChiTiet_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            getNhanVien();
            getNhaCungCap();
            getSanPham();
            getHangSanXuat();
            getLoaiSanPham();
            if (id != 0)
            {
                var phieunhap = context.PhieuNhap.Find(id)!;
                cboNhaCungCap.SelectedValue = phieunhap.NhaCungCapID;
                cboNhanVien.SelectedValue = phieunhap.NhanVienID;
                txtGhiChu.Text = phieunhap.GhiChuPhieuNhap;

                var chitiet = context.PhieuNhap_ChiTiet.Where(p => p.PhieuNhapID == id).Select(p => new DS_PhieuNhap_ChiTiet()
                {
                    ID = p.ID,
                    PhieuNhapID = p.PhieuNhapID,
                    SanPhamID = p.SanPhamID,
                    TenSanPham = p.SanPham.TenSanPham,
                    SoLuongNhap = p.SoLuongNhap,
                    DonGiaNhap = p.DonGiaNhap,
                    ThanhTien = (double)p.SoLuongNhap * (double)p.DonGiaNhap
                }).ToList();


                cboSanPham.DataBindings.Clear();
                cboSanPham.DataBindings.Add("Text", chitiet, "TenSanPham", false, DataSourceUpdateMode.Never);

                numSoLuong.DataBindings.Clear();
                numSoLuong.DataBindings.Add("Value", chitiet, "SoLuongNhap", false, DataSourceUpdateMode.Never);

                numGiaNhap.DataBindings.Clear();
                numGiaNhap.DataBindings.Add("Value", chitiet, "DonGiaNhap", false, DataSourceUpdateMode.Never);

                dsPhieuNhapChiTiet = new BindingList<DS_PhieuNhap_ChiTiet>(chitiet);
            }
            dataGridView.DataSource = dsPhieuNhapChiTiet;
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboNhaCungCap.Text))
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(cboNhanVien.Text))
                MessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (dsPhieuNhapChiTiet.Count == 0)
                MessageBox.Show("Vui lòng thêm sản phẩm vào phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (id != 0)
                {
                    var phieuNhap = context.PhieuNhap.Find(id)!;
                    if (phieuNhap != null)
                    {
                        //cập nhật phiếu nhập chi tiết
                        phieuNhap.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue?.ToString());
                        phieuNhap.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue?.ToString());
                        phieuNhap.GhiChuPhieuNhap = txtGhiChu.Text;
                        context.PhieuNhap.Update(phieuNhap);

                        //xóa phiếu nhập chi tiết cũ
                        var old = context.PhieuNhap_ChiTiet.Where(p => p.PhieuNhapID == id).ToList();
                        context.PhieuNhap_ChiTiet.RemoveRange(old);

                        //thêm phiếu nhập chi tiết mới
                        foreach (var item in dsPhieuNhapChiTiet.ToList())
                        {
                            PhieuNhap_ChiTiet ct = new PhieuNhap_ChiTiet();
                            ct.PhieuNhapID = id;
                            ct.SanPhamID = item.SanPhamID;
                            ct.SoLuongNhap = item.SoLuongNhap;
                            ct.DonGiaNhap = item.DonGiaNhap;
                            context.PhieuNhap_ChiTiet.Add(ct);

                            //cập nhật sản phẩm mới từ phiếu nhập
                            var sanPham = context.SanPham.FirstOrDefault(sp => sp.ID == item.SanPhamID);
                            int hangSanXuatID = 0, loaiSanPhamID = 0, nhaCungCapID = 0;
                            int.TryParse(cboHangSanXuat.SelectedValue?.ToString(), out hangSanXuatID);
                            int.TryParse(cboLoaiSanPham.SelectedValue?.ToString(), out loaiSanPhamID);
                            int.TryParse(cboNhaCungCap.SelectedValue?.ToString(), out nhaCungCapID);
                            decimal giaNhap = numGiaNhap.Value;
                            if (sanPham != null)
                            {
                                sanPham.SoLuongTon += item.SoLuongNhap; // cộng thêm số lượng nhập mới
                                sanPham.GiaBan = 1 * TinhGiaBan(giaNhap); // Tính giá bán mới
                                sanPham.HinhAnh = imageName;
                                sanPham.MoTa = txtGhiChu.Text;
                                sanPham.HangSanXuatID = hangSanXuatID;
                                sanPham.LoaiSanPhamID = loaiSanPhamID;
                                sanPham.NhaCungCapID = nhaCungCapID;
                                context.SanPham.Update(sanPham);
                            }
                        }
                        context.SaveChanges();
                    }
                }
                else
                {
                    //thêm phiếu nhập mới 
                    PhieuNhap phieunhap = new PhieuNhap();
                    phieunhap.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue?.ToString());
                    phieunhap.NhanVienID = Convert.ToInt32(cboNhanVien.SelectedValue?.ToString());
                    phieunhap.GhiChuPhieuNhap = txtGhiChu.Text;
                    phieunhap.NgayLap = DateTime.Now;
                    context.PhieuNhap.Add(phieunhap);
                    context.SaveChanges();
                    //thêm phiếu nhập chi tiết 
                    foreach (var item in dsPhieuNhapChiTiet.ToList())
                    {
                        PhieuNhap_ChiTiet ct = new PhieuNhap_ChiTiet();

                        ct.PhieuNhapID = phieunhap.ID;
                        ct.SanPhamID = item.SanPhamID;
                        ct.SoLuongNhap = item.SoLuongNhap;
                        ct.DonGiaNhap = item.DonGiaNhap;
                        context.PhieuNhap_ChiTiet.Add(ct);

                        //cập nhật sản phẩm mới từ phiếu nhập
                        var sanPham = context.SanPham.FirstOrDefault(sp => sp.ID == item.SanPhamID);
                        int hangSanXuatID = 0, loaiSanPhamID = 0, nhaCungCapID = 0;
                        int.TryParse(cboHangSanXuat.SelectedValue?.ToString(), out hangSanXuatID);
                        int.TryParse(cboLoaiSanPham.SelectedValue?.ToString(), out loaiSanPhamID);
                        int.TryParse(cboNhaCungCap.SelectedValue?.ToString(), out nhaCungCapID);
                        decimal giaNhap = numGiaNhap.Value;

                        if (sanPham != null)
                        {
                            sanPham.SoLuongTon += item.SoLuongNhap; // cộng thêm số lượng nhập mới
                            sanPham.GiaBan = 1 * TinhGiaBan(giaNhap); // Tính giá bán mới
                            sanPham.HinhAnh = null;
                            sanPham.MoTa = txtGhiChu.Text;
                            sanPham.HangSanXuatID = hangSanXuatID;
                            sanPham.LoaiSanPhamID = loaiSanPhamID;
                            sanPham.NhaCungCapID = nhaCungCapID;
                            context.SanPham.Update(sanPham);
                        }
                    }
                    context.SaveChanges();
                }
                DialogResult result = MessageBox.Show("Lập phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    this.Close();
                    frmPhieuNhap fpn = new frmPhieuNhap();
                    fpn.Show();
                }
            }
        }

        private void btnXacNhanNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboNhaCungCap.Text) || string.IsNullOrEmpty(cboNhanVien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp và nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(cboSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (numGiaNhap.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá nhập lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue!.ToString());
                var chitiet = dsPhieuNhapChiTiet.FirstOrDefault(p => p.SanPhamID == maSanPham);

                if (chitiet != null) //cập nhật lại 
                {
                    chitiet.SoLuongNhap = Convert.ToInt32(numSoLuong.Value);
                    chitiet.DonGiaNhap = Convert.ToInt32(numGiaNhap.Value);
                    chitiet.ThanhTien = Convert.ToInt32(chitiet.SoLuongNhap * chitiet.DonGiaNhap);
                    dataGridView.Refresh();
                }
                else //thêm mới
                {
                    DS_PhieuNhap_ChiTiet dsct = new DS_PhieuNhap_ChiTiet()
                    {
                        ID = 0,
                        PhieuNhapID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongNhap = Convert.ToInt32(numSoLuong.Value),
                        DonGiaNhap = Convert.ToInt32(numGiaNhap.Value),
                        ThanhTien = Convert.ToDouble(numSoLuong.Value) * Convert.ToDouble(numGiaNhap.Value)
                    };
                    dsPhieuNhapChiTiet.Add(dsct);
                }
                MessageBox.Show("Thêm sản phẩm vào phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BatTatChucNang();
            }

        }

        private void ThemSanPhamMoi(string tenSanPham)
        {
            SanPham sp = new SanPham
            {
                TenSanPham = tenSanPham,
                GiaBan = 0,
                SoLuongTon = 0,
                NgayNhap = DateTime.Now,
                HinhAnh = null,
                MoTa = null,
                HangSanXuatID = 1,
                LoaiSanPhamID = 1,
                NhaCungCapID = 1,
                KhuyenMaiID = 1
            };
            context.SanPham.Add(sp);
            context.SaveChanges();
        }

        private void cboSanPham_Leave(object sender, EventArgs e)
        {
            string tenSanPhamNhap = cboSanPham.Text.Trim();
            if (!string.IsNullOrEmpty(tenSanPhamNhap))
            {
                // kiểm tra sản phẩm đã có chưa
                var sanPham = context.SanPham.FirstOrDefault(sp => sp.TenSanPham == tenSanPhamNhap);
                if (sanPham == null)
                {
                    var result = MessageBox.Show("Sản phẩm chưa tồn tại. Bạn có muốn thêm mới không?", "Thêm sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ThemSanPhamMoi(tenSanPhamNhap);
                        getSanPham(); // Reload lại ComboBox sản phẩm
                        sanPham = context.SanPham.FirstOrDefault(sp => sp.TenSanPham == tenSanPhamNhap);
                        if (sanPham != null)
                        {
                            cboSanPham.SelectedValue = sanPham.ID;
                        }
                        cboSanPham.Focus();
                    }
                }
            }
        }

        private void cboSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboSanPham.SelectedValue != null)
            {
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue?.ToString());
                var sanPham = context.SanPham.Find(maSanPham)!;
                decimal giaBan = sanPham.GiaBan;
                decimal giaNhap = 1 * LayGiaNhapTuGiaBan(giaBan);
                numGiaNhap.Value = giaNhap;
                cboLoaiSanPham.Text = sanPham.LoaiSanPham!.TenLoaiSanPham;
                cboHangSanXuat.Text = sanPham.HangSanXuat!.TenHangSanXuat;
                cboNhaCungCap.Text = sanPham.NhaCungCap!.TenNhaCungCap;
            }
        }

        public decimal LayGiaNhapTuGiaBan(decimal giaBan)
        {
            decimal tyLeLoiNhuan = 0.10m;

            if (giaBan >= 30000000) // >= 30 triệu
                tyLeLoiNhuan = 0.05m; // 5%
            else if (giaBan >= 15000000) // >= 15 triệu
                tyLeLoiNhuan = 0.08m; // 8%
            else
                tyLeLoiNhuan = 0.10m; // 10%

            // Tính lại giá nhập ban đầu
            decimal giaNhap = giaBan / (1 + tyLeLoiNhuan);
            return Math.Round(giaNhap, 0); // làm tròn về đơn vị
        }

        public decimal TinhGiaBan(decimal giaBan)
        {
            decimal tyLeLoiNhuan = 0.10m;

            if (giaBan >= 30000000) // >= 30 triệu
                tyLeLoiNhuan = 0.05m; // 5%
            else if (giaBan >= 15000000) // >= 15 triệu
                tyLeLoiNhuan = 0.08m; // 8%
            else
                tyLeLoiNhuan = 0.10m; // 10%

            // Tính lại giá nhập ban đầu
            decimal giaNhap = giaBan * (1 + tyLeLoiNhuan);
            return Math.Round(giaNhap, 0); // làm tròn về đơn vị
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int maSanPham = Convert.ToInt32(dataGridView.CurrentRow?.Cells["SanPhamID"].Value?.ToString());
                var chitiet = dsPhieuNhapChiTiet.FirstOrDefault(p => p.SanPhamID == maSanPham)!;
                if (chitiet != null)
                {
                    dsPhieuNhapChiTiet.Remove(chitiet);
                }
                MessageBox.Show("Xóa thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BatTatChucNang();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
