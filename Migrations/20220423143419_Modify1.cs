using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    diachilienhe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangVien", x => x.magv);
                });

            migrationBuilder.CreateTable(
                name: "Hinhthuc_Danhgia",
                columns: table => new
                {
                    mahtdg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thanhphan_danhgia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hinhthuc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trongso = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hinhthuc_Danhgia", x => x.mahtdg);
                });

            migrationBuilder.CreateTable(
                name: "Hocky",
                columns: table => new
                {
                    mahk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenhk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hocky", x => x.mahk);
                });

            migrationBuilder.CreateTable(
                name: "Khoahoc",
                columns: table => new
                {
                    makh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nienkhoa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoahoc", x => x.makh);
                });

            migrationBuilder.CreateTable(
                name: "Khoikienthuc",
                columns: table => new
                {
                    makkt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kkt_ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kkt_mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoikienthuc", x => x.makkt);
                });

            migrationBuilder.CreateTable(
                name: "NhiemvuSV",
                columns: table => new
                {
                    manv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noidung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhiemvuSV", x => x.manv);
                });

            migrationBuilder.CreateTable(
                name: "Phuongphap_Giangday",
                columns: table => new
                {
                    mappday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenpp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phuongphap_Giangday", x => x.mappday);
                });

            migrationBuilder.CreateTable(
                name: "Phuongphap_hoc",
                columns: table => new
                {
                    mapphoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenpp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phuongphap_hoc", x => x.mapphoc);
                });

            migrationBuilder.CreateTable(
                name: "PLO",
                columns: table => new
                {
                    maplo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chisoplo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noidung = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLO", x => x.maplo);
                });

            migrationBuilder.CreateTable(
                name: "Quydinh_Kiemtra",
                columns: table => new
                {
                    maqd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenqd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quydinh_Kiemtra", x => x.maqd);
                });

            migrationBuilder.CreateTable(
                name: "Tailieu",
                columns: table => new
                {
                    matl = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tacgia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tentailieu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thongtinkhac = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loaitl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tailieu", x => x.matl);
                });

            migrationBuilder.CreateTable(
                name: "Bomon",
                columns: table => new
                {
                    mabm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenbm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    magv = table.Column<int>(type: "int", nullable: false)
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
                name: "DeCuongchiTiet",
                columns: table => new
                {
                    mahp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenhp_tviet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenhp_tanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sotc_lt = table.Column<int>(type: "int", nullable: false),
                    sotc_th = table.Column<int>(type: "int", nullable: false),
                    yeucaukhacvoi_hocphan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tomtat_noidunghocphan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    makkt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongchiTiet", x => x.mahp);
                    table.ForeignKey(
                        name: "FK_DeCuongchiTiet_Khoikienthuc_makkt",
                        column: x => x.makkt,
                        principalTable: "Khoikienthuc",
                        principalColumn: "makkt",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    makh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mabm = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Chitietmonhoc",
                columns: table => new
                {
                    mact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chiso = table.Column<int>(type: "int", nullable: false),
                    tenchuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tietlt = table.Column<int>(type: "int", nullable: false),
                    tietth = table.Column<int>(type: "int", nullable: false),
                    mahp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietmonhoc", x => x.mact);
                    table.ForeignKey(
                        name: "FK_Chitietmonhoc_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chuandaura_monhoc",
                columns: table => new
                {
                    macdmon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chisocio = table.Column<int>(type: "int", nullable: false),
                    noidung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuandaura_monhoc", x => x.macdmon);
                    table.ForeignKey(
                        name: "FK_Chuandaura_monhoc_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeCuongHinhthuc",
                columns: table => new
                {
                    dcht_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    mahtdg = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongHinhthuc", x => x.dcht_id);
                    table.ForeignKey(
                        name: "FK_DeCuongHinhthuc_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeCuongHinhthuc_Hinhthuc_Danhgia_mahtdg",
                        column: x => x.mahtdg,
                        principalTable: "Hinhthuc_Danhgia",
                        principalColumn: "mahtdg",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeCuongNhiemvu",
                columns: table => new
                {
                    dcnv_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    manv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongNhiemvu", x => x.dcnv_id);
                    table.ForeignKey(
                        name: "FK_DeCuongNhiemvu_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeCuongNhiemvu_NhiemvuSV_manv",
                        column: x => x.manv,
                        principalTable: "NhiemvuSV",
                        principalColumn: "manv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeCuongQuyDinh",
                columns: table => new
                {
                    dcqd_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    maqd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongQuyDinh", x => x.dcqd_id);
                    table.ForeignKey(
                        name: "FK_DeCuongQuyDinh_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeCuongQuyDinh_Quydinh_Kiemtra_maqd",
                        column: x => x.maqd,
                        principalTable: "Quydinh_Kiemtra",
                        principalColumn: "maqd",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DecuongTailieu",
                columns: table => new
                {
                    dctl_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    matl = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecuongTailieu", x => x.dctl_id);
                    table.ForeignKey(
                        name: "FK_DecuongTailieu_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DecuongTailieu_Tailieu_matl",
                        column: x => x.matl,
                        principalTable: "Tailieu",
                        principalColumn: "matl",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Muctieu",
                columns: table => new
                {
                    mamt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noidung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mtchinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mtphu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muctieu", x => x.mamt);
                    table.ForeignKey(
                        name: "FK_Muctieu_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phutrach",
                columns: table => new
                {
                    mapt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vaitro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    magv = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phutrach", x => x.mapt);
                    table.ForeignKey(
                        name: "FK_Phutrach_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phutrach_GiangVien_magv",
                        column: x => x.magv,
                        principalTable: "GiangVien",
                        principalColumn: "magv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thoigianhoc",
                columns: table => new
                {
                    matg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yeucauhocphan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    makh = table.Column<int>(type: "int", nullable: false),
                    mahk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thoigianhoc", x => x.matg);
                    table.ForeignKey(
                        name: "FK_Thoigianhoc_DeCuongchiTiet_mahp",
                        column: x => x.mahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Thoigianhoc_Hocky_mahk",
                        column: x => x.mahk,
                        principalTable: "Hocky",
                        principalColumn: "mahk",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Thoigianhoc_Khoahoc_makh",
                        column: x => x.makh,
                        principalTable: "Khoahoc",
                        principalColumn: "makh",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chitiet_Chuong",
                columns: table => new
                {
                    mactchuong = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chiso = table.Column<int>(type: "int", nullable: false),
                    tentieumuc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tuanhoc = table.Column<int>(type: "int", nullable: false),
                    thoiluonghoc = table.Column<double>(type: "float", nullable: false),
                    mact = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiet_Chuong", x => x.mactchuong);
                    table.ForeignKey(
                        name: "FK_Chitiet_Chuong_Chitietmonhoc_mact",
                        column: x => x.mact,
                        principalTable: "Chitietmonhoc",
                        principalColumn: "mact",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLOPhuongphapday",
                columns: table => new
                {
                    maloppday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mucdo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mappday = table.Column<int>(type: "int", nullable: false),
                    macdmon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLOPhuongphapday", x => x.maloppday);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphapday_Chuandaura_monhoc_macdmon",
                        column: x => x.macdmon,
                        principalTable: "Chuandaura_monhoc",
                        principalColumn: "macdmon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphapday_Phuongphap_Giangday_mappday",
                        column: x => x.mappday,
                        principalTable: "Phuongphap_Giangday",
                        principalColumn: "mappday",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLOPhuongphaphoc",
                columns: table => new
                {
                    maclopphoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mucdo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mapphoc = table.Column<int>(type: "int", nullable: false),
                    macdmon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLOPhuongphaphoc", x => x.maclopphoc);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphaphoc_Chuandaura_monhoc_macdmon",
                        column: x => x.macdmon,
                        principalTable: "Chuandaura_monhoc",
                        principalColumn: "macdmon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphaphoc_Phuongphap_hoc_mapphoc",
                        column: x => x.mapphoc,
                        principalTable: "Phuongphap_hoc",
                        principalColumn: "mapphoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLPO",
                columns: table => new
                {
                    maclpo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngayupdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    macdmon = table.Column<int>(type: "int", nullable: false),
                    maplo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLPO", x => x.maclpo);
                    table.ForeignKey(
                        name: "FK_CLPO_Chuandaura_monhoc_macdmon",
                        column: x => x.macdmon,
                        principalTable: "Chuandaura_monhoc",
                        principalColumn: "macdmon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLPO_PLO_maplo",
                        column: x => x.maplo,
                        principalTable: "PLO",
                        principalColumn: "maplo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bomon_magv",
                table: "Bomon",
                column: "magv");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiet_Chuong_mact",
                table: "Chitiet_Chuong",
                column: "mact");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietmonhoc_mahp",
                table: "Chitietmonhoc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Chuandaura_monhoc_mahp",
                table: "Chuandaura_monhoc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_macdmon",
                table: "CLOPhuongphapday",
                column: "macdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_mappday",
                table: "CLOPhuongphapday",
                column: "mappday");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_macdmon",
                table: "CLOPhuongphaphoc",
                column: "macdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_mapphoc",
                table: "CLOPhuongphaphoc",
                column: "mapphoc");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_macdmon",
                table: "CLPO",
                column: "macdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_maplo",
                table: "CLPO",
                column: "maplo");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongchiTiet_makkt",
                table: "DeCuongchiTiet",
                column: "makkt");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_mahp",
                table: "DeCuongHinhthuc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_mahtdg",
                table: "DeCuongHinhthuc",
                column: "mahtdg");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_mahp",
                table: "DeCuongNhiemvu",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_manv",
                table: "DeCuongNhiemvu",
                column: "manv");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_mahp",
                table: "DeCuongQuyDinh",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_maqd",
                table: "DeCuongQuyDinh",
                column: "maqd");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_mahp",
                table: "DecuongTailieu",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_matl",
                table: "DecuongTailieu",
                column: "matl");

            migrationBuilder.CreateIndex(
                name: "IX_Khoa_mabm",
                table: "Khoa",
                column: "mabm");

            migrationBuilder.CreateIndex(
                name: "IX_Muctieu_mahp",
                table: "Muctieu",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_magv",
                table: "Phutrach",
                column: "magv");

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_mahp",
                table: "Phutrach",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Thoigianhoc_mahk",
                table: "Thoigianhoc",
                column: "mahk");

            migrationBuilder.CreateIndex(
                name: "IX_Thoigianhoc_mahp",
                table: "Thoigianhoc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Thoigianhoc_makh",
                table: "Thoigianhoc",
                column: "makh");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chitiet_Chuong");

            migrationBuilder.DropTable(
                name: "CLOPhuongphapday");

            migrationBuilder.DropTable(
                name: "CLOPhuongphaphoc");

            migrationBuilder.DropTable(
                name: "CLPO");

            migrationBuilder.DropTable(
                name: "DeCuongHinhthuc");

            migrationBuilder.DropTable(
                name: "DeCuongNhiemvu");

            migrationBuilder.DropTable(
                name: "DeCuongQuyDinh");

            migrationBuilder.DropTable(
                name: "DecuongTailieu");

            migrationBuilder.DropTable(
                name: "Khoa");

            migrationBuilder.DropTable(
                name: "Muctieu");

            migrationBuilder.DropTable(
                name: "Phutrach");

            migrationBuilder.DropTable(
                name: "Thoigianhoc");

            migrationBuilder.DropTable(
                name: "Chitietmonhoc");

            migrationBuilder.DropTable(
                name: "Phuongphap_Giangday");

            migrationBuilder.DropTable(
                name: "Phuongphap_hoc");

            migrationBuilder.DropTable(
                name: "Chuandaura_monhoc");

            migrationBuilder.DropTable(
                name: "PLO");

            migrationBuilder.DropTable(
                name: "Hinhthuc_Danhgia");

            migrationBuilder.DropTable(
                name: "NhiemvuSV");

            migrationBuilder.DropTable(
                name: "Quydinh_Kiemtra");

            migrationBuilder.DropTable(
                name: "Tailieu");

            migrationBuilder.DropTable(
                name: "Bomon");

            migrationBuilder.DropTable(
                name: "Hocky");

            migrationBuilder.DropTable(
                name: "Khoahoc");

            migrationBuilder.DropTable(
                name: "DeCuongchiTiet");

            migrationBuilder.DropTable(
                name: "GiangVien");

            migrationBuilder.DropTable(
                name: "Khoikienthuc");
        }
    }
}
