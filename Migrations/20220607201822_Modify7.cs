using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_GiangVien_GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropColumn(
                name: "GiangVienmagv",
                table: "Phutrach");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GiangVienmagv",
                table: "Phutrach",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv");

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_GiangVien_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
