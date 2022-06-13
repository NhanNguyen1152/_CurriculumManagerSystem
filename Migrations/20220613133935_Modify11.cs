using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CTDT_Muctieudaotao",
                columns: table => new
                {
                    ma_ctdt_mtdt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_ctdt = table.Column<int>(type: "int", nullable: false),
                    ma_mtdt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CTDT_Muctieudaotao", x => x.ma_ctdt_mtdt);
                    table.ForeignKey(
                        name: "FK_CTDT_Muctieudaotao_Chuongtrinh_Daotao_ma_ctdt",
                        column: x => x.ma_ctdt,
                        principalTable: "Chuongtrinh_Daotao",
                        principalColumn: "ma_ctdt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CTDT_Muctieudaotao_Muctieu_Daotao_ma_mtdt",
                        column: x => x.ma_mtdt,
                        principalTable: "Muctieu_Daotao",
                        principalColumn: "ma_mtdt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CTDT_Muctieudaotao_ma_ctdt",
                table: "CTDT_Muctieudaotao",
                column: "ma_ctdt");

            migrationBuilder.CreateIndex(
                name: "IX_CTDT_Muctieudaotao_ma_mtdt",
                table: "CTDT_Muctieudaotao",
                column: "ma_mtdt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CTDT_Muctieudaotao");
        }
    }
}
