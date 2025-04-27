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
    public partial class frmHoaDon_ChiTiet : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        int id;
        BindingList<DanhSachHoaDon_ChiTiet> hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>();

        public frmHoaDon_ChiTiet(int maHoaDon = 0)
        {
            id = maHoaDon;
            InitializeComponent();
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
            cboSanPham.DataSource = context.SanPham.ToList();
            cboSanPham.ValueMember = "ID";
            cboSanPham.DisplayMember = "TenSanPham";
        }
        public void LayHinhThucThanhToanVaoComboBox()
        {
            cboHinhThucThanhToan.DataSource = context.HoaDon.ToList();
            cboHinhThucThanhToan.ValueMember = "ID";
            cboHinhThucThanhToan.DisplayMember = "HinhThucThanhToan";
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

            if (id != 0)
            {
                var hd = context.HoaDon.Find(id)!;
                cboNhanVien.SelectedValue = hd.NhanVienID;
                cboKhachHang.SelectedValue = hd.KhachHangID;
                //cboHinhThucThanhToan.SelectedValue = hd.HinhThucThanhToan!;
                txtGhiChuHoaDon.Text = hd.GhiChuHoaDon;
                var ct = context.HoaDon_ChiTiet.Where(r => r.HoaDonID == id).Select(r => new DanhSachHoaDon_ChiTiet
                {
                    ID = r.ID,
                    HoaDonID = r.HoaDonID,
                    SanPhamID = r.SanPhamID,
                    TenSanPham = r.SanPham.TenSanPham!,
                    SoLuongBan = r.SoLuongBan,
                    DonGiaBan = r.DonGiaBan,
                    ThanhTien = r.SoLuongBan * r.DonGiaBan
                }).ToList();

                cboSanPham.DataBindings.Clear();
                cboSanPham.DataBindings.Add("Text", ct, "TenSanPham", false, DataSourceUpdateMode.Never);

                numSoLuongBan.DataBindings.Clear();
                numSoLuongBan.DataBindings.Add("Value", ct, "SoLuongBan", false, DataSourceUpdateMode.Never);

                numDonGiaBan.DataBindings.Clear();
                numDonGiaBan.DataBindings.Add("Value", ct, "DonGiaBan", false, DataSourceUpdateMode.Never);

                hoaDonChiTiet = new BindingList<DanhSachHoaDon_ChiTiet>(ct);
            }
            dataGridView.DataSource = hoaDonChiTiet;
            BatTatChucNang();

        }

        private void btnXacNhanBan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboSanPham.Text))
                MessageBox.Show("Vui lòng chọn sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    chiTiet.SoLuongBan = Convert.ToInt16(numSoLuongBan.Value);
                    chiTiet.DonGiaBan = Convert.ToInt32(numDonGiaBan.Value);
                    chiTiet.ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value);
                    dataGridView.Refresh();
                }
                else // Nếu chưa có sản phẩm thì thêm vào
                {
                    // Nếu chưa có sản phẩm nào
                    DanhSachHoaDon_ChiTiet ct = new DanhSachHoaDon_ChiTiet
                    {
                        ID = 0,
                        HoaDonID = id,
                        SanPhamID = maSanPham,
                        TenSanPham = cboSanPham.Text,
                        SoLuongBan = Convert.ToInt16(numSoLuongBan.Value),
                        DonGiaBan = Convert.ToInt32(numDonGiaBan.Value),
                        ThanhTien = Convert.ToInt32(numSoLuongBan.Value * numDonGiaBan.Value)
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
                int maSanPham = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value!.ToString());
                var chiTiet = hoaDonChiTiet.FirstOrDefault(x => x.ID == maSanPham)!;
                if (chiTiet != null)
                {
                    hoaDonChiTiet.Remove(chiTiet);
                }
                BatTatChucNang();
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
                // Kiểm tra trước: số lượng tồn kho đủ không?
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

                        // Thêm lại chi tiết mới + trừ tồn kho
                        foreach (var item in hoaDonChiTiet)
                        {
                            HoaDon_ChiTiet ct = new HoaDon_ChiTiet
                            {
                                HoaDonID = id,
                                SanPhamID = item.SanPhamID,
                                SoLuongBan = item.SoLuongBan,
                                DonGiaBan = item.DonGiaBan
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
                            DonGiaBan = item.DonGiaBan
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
                int maSanPham = Convert.ToInt32(cboSanPham.SelectedValue?.ToString());
                var sanPham = context.SanPham.Find(maSanPham)!;
                numDonGiaBan.Value = sanPham.GiaBan;
            }
        }
    }
}
