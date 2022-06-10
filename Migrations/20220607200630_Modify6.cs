using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GiangVienmagv",
                table: "Phutrach",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    makh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.makh);
                });

            migrationBuilder.CreateTable(
                name: "Bomon",
                columns: table => new
                {
                    mabm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenbm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    makh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bomon", x => x.mabm);
                    table.ForeignKey(
                        name: "FK_Bomon_Khoa_makh",
                        column: x => x.makh,
                        principalTable: "Khoa",
                        principalColumn: "makh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    magv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chucdanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hocham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hocvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diachilienhe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mabm = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.magv);
                    table.ForeignKey(
                        name: "FK_GiangVien_Bomon_mabm",
                        column: x => x.mabm,
                        principalTable: "Bomon",
                        principalColumn: "mabm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv");

            migrationBuilder.CreateIndex(
                name: "IX_Bomon_makh",
                table: "Bomon",
                column: "makh");

            migrationBuilder.CreateIndex(
                name: "IX_GiangVien_mabm",
                table: "GiangVien",
                column: "mabm");

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_GiangVien_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_GiangVien_GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "Bomon");

            migrationBuilder.DropTable(
                name: "Khoa");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropColumn(
                name: "GiangVienmagv",
                table: "Phutrach");
        }
    }
}
