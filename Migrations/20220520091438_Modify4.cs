using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "kkt_tuchon",
                table: "Khoikienthuc",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mahp_decuong",
                table: "DeCuongchiTiet",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hp_tienquyet",
                table: "DeCuongchiTiet",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kkt_tuchon",
                table: "Khoikienthuc");

            migrationBuilder.DropColumn(
                name: "hp_tienquyet",
                table: "DeCuongchiTiet");

            migrationBuilder.AlterColumn<string>(
                name: "mahp_decuong",
                table: "DeCuongchiTiet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
