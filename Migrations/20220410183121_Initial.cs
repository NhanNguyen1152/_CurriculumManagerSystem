using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeCuongchiTiet",
                columns: table => new
                {
                    mahp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenhp_tviet = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tenhp_tanh = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    sotc_lt = table.Column<int>(type: "int", nullable: false),
                    sotc_th = table.Column<int>(type: "int", nullable: false),
                    yeucaukhacvoi_hocphan = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    tomtat_noidunghocphan = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongchiTiet", x => x.mahp);
                });

            migrationBuilder.CreateTable(
                name: "GiangVien",
                columns: table => new
                {
                    magv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hoten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    chucdanh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    hocham = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    hocvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    diachilienhe = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
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
                    thanhphan_danhgia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    hinhthuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    tenhk = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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
                    tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    nienkhoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoahoc", x => x.makh);
                });

            migrationBuilder.CreateTable(
                name: "NhiemvuSV",
                columns: table => new
                {
                    manv = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noidung = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
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
                    tenpp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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
                    tenpp = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
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
                    chisoplo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    noidung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
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
                    tenqd = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true)
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
                    tacgia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tentailieu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    thongtinkhac = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    loaitl = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tailieu", x => x.matl);
                });

            migrationBuilder.CreateTable(
                name: "Chitietmonhoc",
                columns: table => new
                {
                    mact = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chiso = table.Column<int>(type: "int", nullable: false),
                    tenchuong = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    tietlt = table.Column<int>(type: "int", nullable: false),
                    tietth = table.Column<int>(type: "int", nullable: false),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitietmonhoc", x => x.mact);
                    table.ForeignKey(
                        name: "FK_Chitietmonhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chuandaura_monhoc",
                columns: table => new
                {
                    macdmon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    chisocio = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    noidung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    loai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chuandaura_monhoc", x => x.macdmon);
                    table.ForeignKey(
                        name: "FK_Chuandaura_monhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Muctieu",
                columns: table => new
                {
                    mamt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    noidung = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    mtchinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mtphu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Muctieu", x => x.mamt);
                    table.ForeignKey(
                        name: "FK_Muctieu_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bomon",
                columns: table => new
                {
                    mabm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenbm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    magv = table.Column<int>(type: "int", nullable: false),
                    GiangVienmagv = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bomon", x => x.mabm);
                    table.ForeignKey(
                        name: "FK_Bomon_GiangVien_GiangVienmagv",
                        column: x => x.GiangVienmagv,
                        principalTable: "GiangVien",
                        principalColumn: "magv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phutrach",
                columns: table => new
                {
                    mapt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vaitro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true),
                    GiangVienmagv = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phutrach", x => x.mapt);
                    table.ForeignKey(
                        name: "FK_Phutrach_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phutrach_GiangVien_GiangVienmagv",
                        column: x => x.GiangVienmagv,
                        principalTable: "GiangVien",
                        principalColumn: "magv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeCuongHinhthuc",
                columns: table => new
                {
                    dcht_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true),
                    Hinhthuc_Danhgiamahtdg = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongHinhthuc", x => x.dcht_id);
                    table.ForeignKey(
                        name: "FK_DeCuongHinhthuc_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeCuongHinhthuc_Hinhthuc_Danhgia_Hinhthuc_Danhgiamahtdg",
                        column: x => x.Hinhthuc_Danhgiamahtdg,
                        principalTable: "Hinhthuc_Danhgia",
                        principalColumn: "mahtdg",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Thoigianhoc",
                columns: table => new
                {
                    matg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    yeucauhocphan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mahp = table.Column<int>(type: "int", nullable: false),
                    makh = table.Column<int>(type: "int", nullable: false),
                    mahk = table.Column<int>(type: "int", nullable: false),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true),
                    Khoahocsmakh = table.Column<int>(type: "int", nullable: true),
                    Hockysmahk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thoigianhoc", x => x.matg);
                    table.ForeignKey(
                        name: "FK_Thoigianhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Thoigianhoc_Hocky_Hockysmahk",
                        column: x => x.Hockysmahk,
                        principalTable: "Hocky",
                        principalColumn: "mahk",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Thoigianhoc_Khoahoc_Khoahocsmakh",
                        column: x => x.Khoahocsmakh,
                        principalTable: "Khoahoc",
                        principalColumn: "makh",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeCuongNhiemvu",
                columns: table => new
                {
                    dcnv_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true),
                    NhiemvuSVmanv = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongNhiemvu", x => x.dcnv_id);
                    table.ForeignKey(
                        name: "FK_DeCuongNhiemvu_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeCuongNhiemvu_NhiemvuSV_NhiemvuSVmanv",
                        column: x => x.NhiemvuSVmanv,
                        principalTable: "NhiemvuSV",
                        principalColumn: "manv",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DeCuongQuyDinh",
                columns: table => new
                {
                    dcqd_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true),
                    Quydinh_Kiemtramaqd = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeCuongQuyDinh", x => x.dcqd_id);
                    table.ForeignKey(
                        name: "FK_DeCuongQuyDinh_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DeCuongQuyDinh_Quydinh_Kiemtra_Quydinh_Kiemtramaqd",
                        column: x => x.Quydinh_Kiemtramaqd,
                        principalTable: "Quydinh_Kiemtra",
                        principalColumn: "maqd",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DecuongTailieu",
                columns: table => new
                {
                    dctl_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeCuongchiTietmahp = table.Column<int>(type: "int", nullable: true),
                    Tailieumatl = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecuongTailieu", x => x.dctl_id);
                    table.ForeignKey(
                        name: "FK_DecuongTailieu_DeCuongchiTiet_DeCuongchiTietmahp",
                        column: x => x.DeCuongchiTietmahp,
                        principalTable: "DeCuongchiTiet",
                        principalColumn: "mahp",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DecuongTailieu_Tailieu_Tailieumatl",
                        column: x => x.Tailieumatl,
                        principalTable: "Tailieu",
                        principalColumn: "matl",
                        onDelete: ReferentialAction.Restrict);
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
                    mact = table.Column<int>(type: "int", nullable: false),
                    Chitietmonhocmact = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chitiet_Chuong", x => x.mactchuong);
                    table.ForeignKey(
                        name: "FK_Chitiet_Chuong_Chitietmonhoc_Chitietmonhocmact",
                        column: x => x.Chitietmonhocmact,
                        principalTable: "Chitietmonhoc",
                        principalColumn: "mact",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CLOPhuongphapday",
                columns: table => new
                {
                    maloppday = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mucdo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Chuandaura_monhocmacdmon = table.Column<int>(type: "int", nullable: true),
                    Phuongphap_Giangdaymappday = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLOPhuongphapday", x => x.maloppday);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphapday_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                        column: x => x.Chuandaura_monhocmacdmon,
                        principalTable: "Chuandaura_monhoc",
                        principalColumn: "macdmon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphapday_Phuongphap_Giangday_Phuongphap_Giangdaymappday",
                        column: x => x.Phuongphap_Giangdaymappday,
                        principalTable: "Phuongphap_Giangday",
                        principalColumn: "mappday",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CLOPhuongphaphoc",
                columns: table => new
                {
                    maclopphoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mucdo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Chuandaura_monhocmacdmon = table.Column<int>(type: "int", nullable: true),
                    Phuongphap_hocmapphoc = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLOPhuongphaphoc", x => x.maclopphoc);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphaphoc_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                        column: x => x.Chuandaura_monhocmacdmon,
                        principalTable: "Chuandaura_monhoc",
                        principalColumn: "macdmon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLOPhuongphaphoc_Phuongphap_hoc_Phuongphap_hocmapphoc",
                        column: x => x.Phuongphap_hocmapphoc,
                        principalTable: "Phuongphap_hoc",
                        principalColumn: "mapphoc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CLPO",
                columns: table => new
                {
                    maclpo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ngayupdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Chuandaura_monhocmacdmon = table.Column<int>(type: "int", nullable: true),
                    PLOmaplo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLPO", x => x.maclpo);
                    table.ForeignKey(
                        name: "FK_CLPO_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                        column: x => x.Chuandaura_monhocmacdmon,
                        principalTable: "Chuandaura_monhoc",
                        principalColumn: "macdmon",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CLPO_PLO_PLOmaplo",
                        column: x => x.PLOmaplo,
                        principalTable: "PLO",
                        principalColumn: "maplo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Khoa",
                columns: table => new
                {
                    makh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenkh = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    mabm = table.Column<int>(type: "int", nullable: false),
                    Bomonmabm = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoa", x => x.makh);
                    table.ForeignKey(
                        name: "FK_Khoa_Bomon_Bomonmabm",
                        column: x => x.Bomonmabm,
                        principalTable: "Bomon",
                        principalColumn: "mabm",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bomon_GiangVienmagv",
                table: "Bomon",
                column: "GiangVienmagv");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiet_Chuong_Chitietmonhocmact",
                table: "Chitiet_Chuong",
                column: "Chitietmonhocmact");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietmonhoc_DeCuongchiTietmahp",
                table: "Chitietmonhoc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Chuandaura_monhoc_DeCuongchiTietmahp",
                table: "Chuandaura_monhoc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday",
                column: "Chuandaura_monhocmacdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday",
                column: "Phuongphap_Giangdaymappday");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc",
                column: "Chuandaura_monhocmacdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc",
                column: "Phuongphap_hocmapphoc");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_Chuandaura_monhocmacdmon",
                table: "CLPO",
                column: "Chuandaura_monhocmacdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_PLOmaplo",
                table: "CLPO",
                column: "PLOmaplo");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_DeCuongchiTietmahp",
                table: "DeCuongHinhthuc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc",
                column: "Hinhthuc_Danhgiamahtdg");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_DeCuongchiTietmahp",
                table: "DeCuongNhiemvu",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_NhiemvuSVmanv",
                table: "DeCuongNhiemvu",
                column: "NhiemvuSVmanv");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_DeCuongchiTietmahp",
                table: "DeCuongQuyDinh",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh",
                column: "Quydinh_Kiemtramaqd");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_DeCuongchiTietmahp",
                table: "DecuongTailieu",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_Tailieumatl",
                table: "DecuongTailieu",
                column: "Tailieumatl");

            migrationBuilder.CreateIndex(
                name: "IX_Khoa_Bomonmabm",
                table: "Khoa",
                column: "Bomonmabm");

            migrationBuilder.CreateIndex(
                name: "IX_Muctieu_DeCuongchiTietmahp",
                table: "Muctieu",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_DeCuongchiTietmahp",
                table: "Phutrach",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv");

            migrationBuilder.CreateIndex(
                name: "IX_Thoigianhoc_DeCuongchiTietmahp",
                table: "Thoigianhoc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Thoigianhoc_Hockysmahk",
                table: "Thoigianhoc",
                column: "Hockysmahk");

            migrationBuilder.CreateIndex(
                name: "IX_Thoigianhoc_Khoahocsmakh",
                table: "Thoigianhoc",
                column: "Khoahocsmakh");
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
        }
    }
}
