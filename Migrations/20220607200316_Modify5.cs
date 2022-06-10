using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Phutrach_GiangVien_magv",
            //     table: "Phutrach");

            // migrationBuilder.DropTable(
            //     name: "Khoa");

            // migrationBuilder.DropTable(
            //     name: "Bomon");

            // migrationBuilder.DropTable(
            //     name: "GiangVien");

            // migrationBuilder.DropIndex(
            //     name: "IX_Phutrach_magv",
            //     table: "Phutrach");

            migrationBuilder.CreateTable(
                name: "Chuongtrinh_Daotao",
                columns: table => new
                {
                    ma_ctdt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nganh_daotao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trinhdo_daotao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loaihinh_daotao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thoigian_daotao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenvanbang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noidaotao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuongtrinh_Daotao", x => x.ma_ctdt);
                });

            migrationBuilder.CreateTable(
                name: "Doituong_Tuyensinh",
                columns: table => new
                {
                    ma_dtts = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noi_dung_dtts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doituong_Tuyensinh", x => x.ma_dtts);
                });

            migrationBuilder.CreateTable(
                name: "Muctieu_Daotao",
                columns: table => new
                {
                    ma_mtdt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noi_dung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mtdt_chinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mtdt_phu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muctieu_Daotao", x => x.ma_mtdt);
                });

            migrationBuilder.CreateTable(
                name: "Quytrinhdaotao_Dieukientotnghiep",
                columns: table => new
                {
                    ma_qt_dktn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noi_dung_quytrinhdieukien = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quytrinhdaotao_Dieukientotnghiep", x => x.ma_qt_dktn);
                });

            migrationBuilder.CreateTable(
                name: "Decuong_Chuongtrinh",
                columns: table => new
                {
                    ma_dc_ct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    ma_ctdt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decuong_Chuongtrinh", x => x.ma_dc_ct);
                    table.ForeignKey(
                        name: "FK_Decuong_Chuongtrinh_Chuongtrinh_Daotao_ma_ctdt",
                        column: x => x.ma_ctdt,
                        principalTable: "Chuongtrinh_Daotao",
                        principalColumn: "ma_ctdt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decuong_Chuongtrinh_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chitiet_Doituong",
                columns: table => new
                {
                    ma_ct_dt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_ctdt = table.Column<int>(type: "int", nullable: false),
                    ma_dtts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiet_Doituong", x => x.ma_ct_dt);
                    table.ForeignKey(
                        name: "FK_Chitiet_Doituong_Chuongtrinh_Daotao_ma_ctdt",
                        column: x => x.ma_ctdt,
                        principalTable: "Chuongtrinh_Daotao",
                        principalColumn: "ma_ctdt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chitiet_Doituong_Doituong_Tuyensinh_ma_dtts",
                        column: x => x.ma_dtts,
                        principalTable: "Doituong_Tuyensinh",
                        principalColumn: "ma_dtts",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoiquanhePLO_Muctieudaotao",
                columns: table => new
                {
                    ma_plo_mtdt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngay_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    maplo = table.Column<int>(type: "int", nullable: false),
                    ma_mtdt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoiquanhePLO_Muctieudaotao", x => x.ma_plo_mtdt);
                    table.ForeignKey(
                        name: "FK_MoiquanhePLO_Muctieudaotao_Muctieu_Daotao_ma_mtdt",
                        column: x => x.ma_mtdt,
                        principalTable: "Muctieu_Daotao",
                        principalColumn: "ma_mtdt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoiquanhePLO_Muctieudaotao_PLO_maplo",
                        column: x => x.maplo,
                        principalTable: "PLO",
                        principalColumn: "maplo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Decuong_Quytrinh",
                columns: table => new
                {
                    dcht_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma_ctdt = table.Column<int>(type: "int", nullable: false),
                    ma_qt_dktn = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decuong_Quytrinh", x => x.dcht_id);
                    table.ForeignKey(
                        name: "FK_Decuong_Quytrinh_Chuongtrinh_Daotao_ma_ctdt",
                        column: x => x.ma_ctdt,
                        principalTable: "Chuongtrinh_Daotao",
                        principalColumn: "ma_ctdt",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Decuong_Quytrinh_Quytrinhdaotao_Dieukientotnghiep_ma_qt_dktn",
                        column: x => x.ma_qt_dktn,
                        principalTable: "Quytrinhdaotao_Dieukientotnghiep",
                        principalColumn: "ma_qt_dktn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chitiet_Doituong_ma_ctdt",
                table: "Chitiet_Doituong",
                column: "ma_ctdt");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiet_Doituong_ma_dtts",
                table: "Chitiet_Doituong",
                column: "ma_dtts");

            migrationBuilder.CreateIndex(
                name: "IX_Decuong_Chuongtrinh_ma_ctdt",
                table: "Decuong_Chuongtrinh",
                column: "ma_ctdt");

            migrationBuilder.CreateIndex(
                name: "IX_Decuong_Chuongtrinh_mahp",
                table: "Decuong_Chuongtrinh",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Decuong_Quytrinh_ma_ctdt",
                table: "Decuong_Quytrinh",
                column: "ma_ctdt");

            migrationBuilder.CreateIndex(
                name: "IX_Decuong_Quytrinh_ma_qt_dktn",
                table: "Decuong_Quytrinh",
                column: "ma_qt_dktn");

            migrationBuilder.CreateIndex(
                name: "IX_MoiquanhePLO_Muctieudaotao_ma_mtdt",
                table: "MoiquanhePLO_Muctieudaotao",
                column: "ma_mtdt");

            migrationBuilder.CreateIndex(
                name: "IX_MoiquanhePLO_Muctieudaotao_maplo",
                table: "MoiquanhePLO_Muctieudaotao",
                column: "maplo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitiet_Doituong");

            migrationBuilder.DropTable(
                name: "Decuong_Chuongtrinh");

            migrationBuilder.DropTable(
                name: "Decuong_Quytrinh");

            migrationBuilder.DropTable(
                name: "MoiquanhePLO_Muctieudaotao");

            migrationBuilder.DropTable(
                name: "Doituong_Tuyensinh");

            migrationBuilder.DropTable(
                name: "Chuongtrinh_Daotao");

            migrationBuilder.DropTable(
                name: "Quytrinhdaotao_Dieukientotnghiep");

            migrationBuilder.DropTable(
                name: "Muctieu_Daotao");

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    magv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chucdanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diachilienhe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hocham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hocvi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hoten = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.magv);
                });

            migrationBuilder.CreateTable(
                name: "Bomon",
                columns: table => new
                {
                    mabm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    magv = table.Column<int>(type: "int", nullable: false),
                    tenbm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bomon", x => x.mabm);
                    table.ForeignKey(
                        name: "FK_Bomon_GiangVien_magv",
                        column: x => x.magv,
                        principalTable: "GiangVien",
                        principalColumn: "magv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    makh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mabm = table.Column<int>(type: "int", nullable: false),
                    tenkh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.makh);
                    table.ForeignKey(
                        name: "FK_Khoa_Bomon_mabm",
                        column: x => x.mabm,
                        principalTable: "Bomon",
                        principalColumn: "mabm",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_magv",
                table: "Phutrach",
                column: "magv");

            migrationBuilder.CreateIndex(
                name: "IX_Bomon_magv",
                table: "Bomon",
                column: "magv");

            migrationBuilder.CreateIndex(
                name: "IX_Khoa_mabm",
                table: "Khoa",
                column: "mabm");

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_GiangVien_magv",
                table: "Phutrach",
                column: "magv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
