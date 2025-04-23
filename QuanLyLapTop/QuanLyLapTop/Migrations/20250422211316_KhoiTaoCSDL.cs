using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyLapTop.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangSanXuat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSanXuat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhuyenMai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyenHan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HangSanXuatID = table.Column<int>(type: "int", nullable: false),
                    LoaiSanPhamID = table.Column<int>(type: "int", nullable: false),
                    NhaCungCapID = table.Column<int>(type: "int", nullable: false),
                    KhuyenMaiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_HangSanXuat_HangSanXuatID",
                        column: x => x.HangSanXuatID,
                        principalTable: "HangSanXuat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_KhuyenMai_KhuyenMaiID",
                        column: x => x.KhuyenMaiID,
                        principalTable: "KhuyenMai",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSanPhamID",
                        column: x => x.LoaiSanPhamID,
                        principalTable: "LoaiSanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_NhaCungCap_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    KhachHangID = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChuHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhaCungCapID = table.Column<int>(type: "int", nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChuPhieuNhap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhaCungCap_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanPham_ChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanPhamID = table.Column<int>(type: "int", nullable: false),
                    CPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OCung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManHinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GPU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrongLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeDieuHanh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham_ChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_ChiTiet_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon_ChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonID = table.Column<int>(type: "int", nullable: false),
                    SanPhamID = table.Column<int>(type: "int", nullable: false),
                    SoLuongBan = table.Column<short>(type: "smallint", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon_ChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_ChiTiet_HoaDon_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_ChiTiet_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap_ChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhieuNhapID = table.Column<int>(type: "int", nullable: false),
                    SanPhamID = table.Column<int>(type: "int", nullable: false),
                    SoLuongNhap = table.Column<short>(type: "smallint", nullable: false),
                    DonGiaNhap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap_ChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_ChiTiet_PhieuNhap_PhieuNhapID",
                        column: x => x.PhieuNhapID,
                        principalTable: "PhieuNhap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_ChiTiet_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangID",
                table: "HoaDon",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienID",
                table: "HoaDon",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiTiet_HoaDonID",
                table: "HoaDon_ChiTiet",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiTiet_SanPhamID",
                table: "HoaDon_ChiTiet",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_NhaCungCapID",
                table: "PhieuNhap",
                column: "NhaCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_NhanVienID",
                table: "PhieuNhap",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_ChiTiet_PhieuNhapID",
                table: "PhieuNhap_ChiTiet",
                column: "PhieuNhapID");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_ChiTiet_SanPhamID",
                table: "PhieuNhap_ChiTiet",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_HangSanXuatID",
                table: "SanPham",
                column: "HangSanXuatID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_KhuyenMaiID",
                table: "SanPham",
                column: "KhuyenMaiID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamID",
                table: "SanPham",
                column: "LoaiSanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_NhaCungCapID",
                table: "SanPham",
                column: "NhaCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_ChiTiet_SanPhamID",
                table: "SanPham_ChiTiet",
                column: "SanPhamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon_ChiTiet");

            migrationBuilder.DropTable(
                name: "PhieuNhap_ChiTiet");

            migrationBuilder.DropTable(
                name: "SanPham_ChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "HangSanXuat");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "NhaCungCap");
        }
    }
}
