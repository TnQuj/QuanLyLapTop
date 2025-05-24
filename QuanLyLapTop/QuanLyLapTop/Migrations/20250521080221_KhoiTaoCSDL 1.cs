using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyLapTop.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDL1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TenSanPham",
                table: "HoaDon_ChiTiet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenSanPham",
                table: "HoaDon_ChiTiet");
        }
    }
}
