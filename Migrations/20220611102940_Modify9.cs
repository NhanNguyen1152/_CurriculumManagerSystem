using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "chitietten_plo",
                table: "PLO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tenloai_plo",
                table: "PLO",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mtdt_chiso",
                table: "Muctieu_Daotao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "maso_ctdt",
                table: "Chuongtrinh_Daotao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "noidung_ctdt",
                table: "Chuongtrinh_Daotao",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "chitietten_plo",
                table: "PLO");

            migrationBuilder.DropColumn(
                name: "tenloai_plo",
                table: "PLO");

            migrationBuilder.DropColumn(
                name: "mtdt_chiso",
                table: "Muctieu_Daotao");

            migrationBuilder.DropColumn(
                name: "maso_ctdt",
                table: "Chuongtrinh_Daotao");

            migrationBuilder.DropColumn(
                name: "noidung_ctdt",
                table: "Chuongtrinh_Daotao");
        }
    }
}
