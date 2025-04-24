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
        BindingList <DS_PhieuNhap_ChiTiet> dsPhieuNhapChiTiet = new BindingList<DS_PhieuNhap_ChiTiet>();
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

        public void BatTatChucNang()
        {
            if(id == 0 && dataGridView.Rows.Count == 0)
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

            if(id != 0)
            {
                var phieunhap = context.PhieuNhap.Find(id)!;
                cboNhaCungCap.SelectedValue = phieunhap.NhaCungCapID;
                cboNhanVien.SelectedValue = phieunhap.NhanVienID;
                txtGhiChu.Text = phieunhap.GhiChuPhieuNhap;

                var chitiet = context.PhieuNhap_ChiTiet.Where(p =>  p.PhieuNhapID == id).Select(p => new DS_PhieuNhap_ChiTiet()
                {
                    ID = p.ID,
                    PhieuNhapID = p.PhieuNhapID,
                    SanPhamID = p.SanPhamID,
                    TenSanPham = p.SanPham.TenSanPham,
                    SoLuongNhap = p.SoLuongNhap,
                    DonGiaNhap = p.DonGiaNhap,
                    ThanhTien = (double)p.SoLuongNhap * (double)p.DonGiaNhap
                }).ToList();
            } 
            dataGridView.DataSource = dsPhieuNhapChiTiet;
            frmPhieuNhap_ChiTiet_Load(sender, e);
        }
    }
}
