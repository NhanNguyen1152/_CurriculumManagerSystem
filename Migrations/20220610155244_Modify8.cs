using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateIndex(
            //     name: "IX_Phutrach_magv",
            //     table: "Phutrach",
            //     column: "magv");

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_GiangVien_magv",
                table: "Phutrach",
                column: "magv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_GiangVien_magv",
                table: "Phutrach");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_magv",
                table: "Phutrach");
        }
    }
}
