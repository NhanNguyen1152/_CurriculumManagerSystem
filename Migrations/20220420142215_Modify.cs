using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bomon_GiangVien_GiangVienmagv",
                table: "Bomon");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitiet_Chuong_Chitietmonhoc_Chitietmonhocmact",
                table: "Chitiet_Chuong");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitietmonhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Chitietmonhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Chuandaura_monhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Chuandaura_monhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphapday_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphapday_Phuongphap_Giangday_Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphaphoc_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphaphoc_Phuongphap_hoc_Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropForeignKey(
                name: "FK_CLPO_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                table: "CLPO");

            migrationBuilder.DropForeignKey(
                name: "FK_CLPO_PLO_PLOmaplo",
                table: "CLPO");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongHinhthuc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongHinhthuc_Hinhthuc_Danhgia_Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongNhiemvu_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongNhiemvu_NhiemvuSV_NhiemvuSVmanv",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongQuyDinh_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongQuyDinh_Quydinh_Kiemtra_Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropForeignKey(
                name: "FK_DecuongTailieu_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DecuongTailieu");

            migrationBuilder.DropForeignKey(
                name: "FK_DecuongTailieu_Tailieu_Tailieumatl",
                table: "DecuongTailieu");

            migrationBuilder.DropForeignKey(
                name: "FK_Khoa_Bomon_Bomonmabm",
                table: "Khoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Muctieu_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Muctieu");

            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Phutrach");

            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_GiangVien_GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropForeignKey(
                name: "FK_Thoigianhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Thoigianhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thoigianhoc_Hocky_Hockysmahk",
                table: "Thoigianhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thoigianhoc_Khoahoc_Khoahocsmakh",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Thoigianhoc_DeCuongchiTietmahp",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Thoigianhoc_Hockysmahk",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Thoigianhoc_Khoahocsmakh",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_DeCuongchiTietmahp",
                table: "Phutrach");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropIndex(
                name: "IX_Muctieu_DeCuongchiTietmahp",
                table: "Muctieu");

            migrationBuilder.DropIndex(
                name: "IX_Khoa_Bomonmabm",
                table: "Khoa");

            migrationBuilder.DropIndex(
                name: "IX_DecuongTailieu_DeCuongchiTietmahp",
                table: "DecuongTailieu");

            migrationBuilder.DropIndex(
                name: "IX_DecuongTailieu_Tailieumatl",
                table: "DecuongTailieu");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongQuyDinh_DeCuongchiTietmahp",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongQuyDinh_Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongNhiemvu_DeCuongchiTietmahp",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongNhiemvu_NhiemvuSVmanv",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongHinhthuc_DeCuongchiTietmahp",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongHinhthuc_Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropIndex(
                name: "IX_CLPO_Chuandaura_monhocmacdmon",
                table: "CLPO");

            migrationBuilder.DropIndex(
                name: "IX_CLPO_PLOmaplo",
                table: "CLPO");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphaphoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphaphoc_Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphapday_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphapday_Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday");

            migrationBuilder.DropIndex(
                name: "IX_Chuandaura_monhoc_DeCuongchiTietmahp",
                table: "Chuandaura_monhoc");

            migrationBuilder.DropIndex(
                name: "IX_Chitietmonhoc_DeCuongchiTietmahp",
                table: "Chitietmonhoc");

            migrationBuilder.DropIndex(
                name: "IX_Chitiet_Chuong_Chitietmonhocmact",
                table: "Chitiet_Chuong");

            migrationBuilder.DropIndex(
                name: "IX_Bomon_GiangVienmagv",
                table: "Bomon");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "Thoigianhoc");

            migrationBuilder.DropColumn(
                name: "Hockysmahk",
                table: "Thoigianhoc");

            migrationBuilder.DropColumn(
                name: "Khoahocsmakh",
                table: "Thoigianhoc");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "Phutrach");

            migrationBuilder.DropColumn(
                name: "GiangVienmagv",
                table: "Phutrach");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "Muctieu");

            migrationBuilder.DropColumn(
                name: "Bomonmabm",
                table: "Khoa");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "DecuongTailieu");

            migrationBuilder.DropColumn(
                name: "Tailieumatl",
                table: "DecuongTailieu");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropColumn(
                name: "Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropColumn(
                name: "NhiemvuSVmanv",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropColumn(
                name: "Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropColumn(
                name: "Chuandaura_monhocmacdmon",
                table: "CLPO");

            migrationBuilder.DropColumn(
                name: "PLOmaplo",
                table: "CLPO");

            migrationBuilder.DropColumn(
                name: "Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropColumn(
                name: "Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropColumn(
                name: "Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday");

            migrationBuilder.DropColumn(
                name: "Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "Chuandaura_monhoc");

            migrationBuilder.DropColumn(
                name: "DeCuongchiTietmahp",
                table: "Chitietmonhoc");

            migrationBuilder.DropColumn(
                name: "Chitietmonhocmact",
                table: "Chitiet_Chuong");

            migrationBuilder.DropColumn(
                name: "GiangVienmagv",
                table: "Bomon");

            migrationBuilder.AddColumn<int>(
                name: "magv",
                table: "Phutrach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mahp",
                table: "Phutrach",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mahp",
                table: "DecuongTailieu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "matl",
                table: "DecuongTailieu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mahp",
                table: "DeCuongQuyDinh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "maqd",
                table: "DeCuongQuyDinh",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mahp",
                table: "DeCuongNhiemvu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "manv",
                table: "DeCuongNhiemvu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mahp",
                table: "DeCuongHinhthuc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mahtdg",
                table: "DeCuongHinhthuc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "macdmon",
                table: "CLPO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "maplo",
                table: "CLPO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "macdmon",
                table: "CLOPhuongphaphoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mapphoc",
                table: "CLOPhuongphaphoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "macdmon",
                table: "CLOPhuongphapday",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "mappday",
                table: "CLOPhuongphapday",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_magv",
                table: "Phutrach",
                column: "magv");

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_mahp",
                table: "Phutrach",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Muctieu_mahp",
                table: "Muctieu",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Khoa_mabm",
                table: "Khoa",
                column: "mabm");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_mahp",
                table: "DecuongTailieu",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_matl",
                table: "DecuongTailieu",
                column: "matl");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_mahp",
                table: "DeCuongQuyDinh",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_maqd",
                table: "DeCuongQuyDinh",
                column: "maqd");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_mahp",
                table: "DeCuongNhiemvu",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_manv",
                table: "DeCuongNhiemvu",
                column: "manv");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_mahp",
                table: "DeCuongHinhthuc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_mahtdg",
                table: "DeCuongHinhthuc",
                column: "mahtdg");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_macdmon",
                table: "CLPO",
                column: "macdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_maplo",
                table: "CLPO",
                column: "maplo");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_macdmon",
                table: "CLOPhuongphaphoc",
                column: "macdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_mapphoc",
                table: "CLOPhuongphaphoc",
                column: "mapphoc");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_macdmon",
                table: "CLOPhuongphapday",
                column: "macdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_mappday",
                table: "CLOPhuongphapday",
                column: "mappday");

            migrationBuilder.CreateIndex(
                name: "IX_Chuandaura_monhoc_mahp",
                table: "Chuandaura_monhoc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietmonhoc_mahp",
                table: "Chitietmonhoc",
                column: "mahp");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiet_Chuong_mact",
                table: "Chitiet_Chuong",
                column: "mact");

            migrationBuilder.CreateIndex(
                name: "IX_Bomon_magv",
                table: "Bomon",
                column: "magv");

            migrationBuilder.AddForeignKey(
                name: "FK_Bomon_GiangVien_magv",
                table: "Bomon",
                column: "magv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitiet_Chuong_Chitietmonhoc_mact",
                table: "Chitiet_Chuong",
                column: "mact",
                principalTable: "Chitietmonhoc",
                principalColumn: "mact",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietmonhoc_DeCuongchiTiet_mahp",
                table: "Chitietmonhoc",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chuandaura_monhoc_DeCuongchiTiet_mahp",
                table: "Chuandaura_monhoc",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphapday_Chuandaura_monhoc_macdmon",
                table: "CLOPhuongphapday",
                column: "macdmon",
                principalTable: "Chuandaura_monhoc",
                principalColumn: "macdmon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphapday_Phuongphap_Giangday_mappday",
                table: "CLOPhuongphapday",
                column: "mappday",
                principalTable: "Phuongphap_Giangday",
                principalColumn: "mappday",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphaphoc_Chuandaura_monhoc_macdmon",
                table: "CLOPhuongphaphoc",
                column: "macdmon",
                principalTable: "Chuandaura_monhoc",
                principalColumn: "macdmon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphaphoc_Phuongphap_hoc_mapphoc",
                table: "CLOPhuongphaphoc",
                column: "mapphoc",
                principalTable: "Phuongphap_hoc",
                principalColumn: "mapphoc",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLPO_Chuandaura_monhoc_macdmon",
                table: "CLPO",
                column: "macdmon",
                principalTable: "Chuandaura_monhoc",
                principalColumn: "macdmon",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CLPO_PLO_maplo",
                table: "CLPO",
                column: "maplo",
                principalTable: "PLO",
                principalColumn: "maplo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongHinhthuc_DeCuongchiTiet_mahp",
                table: "DeCuongHinhthuc",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongHinhthuc_Hinhthuc_Danhgia_mahtdg",
                table: "DeCuongHinhthuc",
                column: "mahtdg",
                principalTable: "Hinhthuc_Danhgia",
                principalColumn: "mahtdg",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongNhiemvu_DeCuongchiTiet_mahp",
                table: "DeCuongNhiemvu",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongNhiemvu_NhiemvuSV_manv",
                table: "DeCuongNhiemvu",
                column: "manv",
                principalTable: "NhiemvuSV",
                principalColumn: "manv",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongQuyDinh_DeCuongchiTiet_mahp",
                table: "DeCuongQuyDinh",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongQuyDinh_Quydinh_Kiemtra_maqd",
                table: "DeCuongQuyDinh",
                column: "maqd",
                principalTable: "Quydinh_Kiemtra",
                principalColumn: "maqd",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DecuongTailieu_DeCuongchiTiet_mahp",
                table: "DecuongTailieu",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DecuongTailieu_Tailieu_matl",
                table: "DecuongTailieu",
                column: "matl",
                principalTable: "Tailieu",
                principalColumn: "matl",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Khoa_Bomon_mabm",
                table: "Khoa",
                column: "mabm",
                principalTable: "Bomon",
                principalColumn: "mabm",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Muctieu_DeCuongchiTiet_mahp",
                table: "Muctieu",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_DeCuongchiTiet_mahp",
                table: "Phutrach",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_GiangVien_magv",
                table: "Phutrach",
                column: "magv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thoigianhoc_DeCuongchiTiet_mahp",
                table: "Thoigianhoc",
                column: "mahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thoigianhoc_Hocky_mahk",
                table: "Thoigianhoc",
                column: "mahk",
                principalTable: "Hocky",
                principalColumn: "mahk",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Thoigianhoc_Khoahoc_makh",
                table: "Thoigianhoc",
                column: "makh",
                principalTable: "Khoahoc",
                principalColumn: "makh",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bomon_GiangVien_magv",
                table: "Bomon");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitiet_Chuong_Chitietmonhoc_mact",
                table: "Chitiet_Chuong");

            migrationBuilder.DropForeignKey(
                name: "FK_Chitietmonhoc_DeCuongchiTiet_mahp",
                table: "Chitietmonhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Chuandaura_monhoc_DeCuongchiTiet_mahp",
                table: "Chuandaura_monhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphapday_Chuandaura_monhoc_macdmon",
                table: "CLOPhuongphapday");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphapday_Phuongphap_Giangday_mappday",
                table: "CLOPhuongphapday");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphaphoc_Chuandaura_monhoc_macdmon",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropForeignKey(
                name: "FK_CLOPhuongphaphoc_Phuongphap_hoc_mapphoc",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropForeignKey(
                name: "FK_CLPO_Chuandaura_monhoc_macdmon",
                table: "CLPO");

            migrationBuilder.DropForeignKey(
                name: "FK_CLPO_PLO_maplo",
                table: "CLPO");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongHinhthuc_DeCuongchiTiet_mahp",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongHinhthuc_Hinhthuc_Danhgia_mahtdg",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongNhiemvu_DeCuongchiTiet_mahp",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongNhiemvu_NhiemvuSV_manv",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongQuyDinh_DeCuongchiTiet_mahp",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropForeignKey(
                name: "FK_DeCuongQuyDinh_Quydinh_Kiemtra_maqd",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropForeignKey(
                name: "FK_DecuongTailieu_DeCuongchiTiet_mahp",
                table: "DecuongTailieu");

            migrationBuilder.DropForeignKey(
                name: "FK_DecuongTailieu_Tailieu_matl",
                table: "DecuongTailieu");

            migrationBuilder.DropForeignKey(
                name: "FK_Khoa_Bomon_mabm",
                table: "Khoa");

            migrationBuilder.DropForeignKey(
                name: "FK_Muctieu_DeCuongchiTiet_mahp",
                table: "Muctieu");

            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_DeCuongchiTiet_mahp",
                table: "Phutrach");

            migrationBuilder.DropForeignKey(
                name: "FK_Phutrach_GiangVien_magv",
                table: "Phutrach");

            migrationBuilder.DropForeignKey(
                name: "FK_Thoigianhoc_DeCuongchiTiet_mahp",
                table: "Thoigianhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thoigianhoc_Hocky_mahk",
                table: "Thoigianhoc");

            migrationBuilder.DropForeignKey(
                name: "FK_Thoigianhoc_Khoahoc_makh",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Thoigianhoc_mahk",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Thoigianhoc_mahp",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Thoigianhoc_makh",
                table: "Thoigianhoc");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_magv",
                table: "Phutrach");

            migrationBuilder.DropIndex(
                name: "IX_Phutrach_mahp",
                table: "Phutrach");

            migrationBuilder.DropIndex(
                name: "IX_Muctieu_mahp",
                table: "Muctieu");

            migrationBuilder.DropIndex(
                name: "IX_Khoa_mabm",
                table: "Khoa");

            migrationBuilder.DropIndex(
                name: "IX_DecuongTailieu_mahp",
                table: "DecuongTailieu");

            migrationBuilder.DropIndex(
                name: "IX_DecuongTailieu_matl",
                table: "DecuongTailieu");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongQuyDinh_mahp",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongQuyDinh_maqd",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongNhiemvu_mahp",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongNhiemvu_manv",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongHinhthuc_mahp",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropIndex(
                name: "IX_DeCuongHinhthuc_mahtdg",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropIndex(
                name: "IX_CLPO_macdmon",
                table: "CLPO");

            migrationBuilder.DropIndex(
                name: "IX_CLPO_maplo",
                table: "CLPO");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphaphoc_macdmon",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphaphoc_mapphoc",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphapday_macdmon",
                table: "CLOPhuongphapday");

            migrationBuilder.DropIndex(
                name: "IX_CLOPhuongphapday_mappday",
                table: "CLOPhuongphapday");

            migrationBuilder.DropIndex(
                name: "IX_Chuandaura_monhoc_mahp",
                table: "Chuandaura_monhoc");

            migrationBuilder.DropIndex(
                name: "IX_Chitietmonhoc_mahp",
                table: "Chitietmonhoc");

            migrationBuilder.DropIndex(
                name: "IX_Chitiet_Chuong_mact",
                table: "Chitiet_Chuong");

            migrationBuilder.DropIndex(
                name: "IX_Bomon_magv",
                table: "Bomon");

            migrationBuilder.DropColumn(
                name: "magv",
                table: "Phutrach");

            migrationBuilder.DropColumn(
                name: "mahp",
                table: "Phutrach");

            migrationBuilder.DropColumn(
                name: "mahp",
                table: "DecuongTailieu");

            migrationBuilder.DropColumn(
                name: "matl",
                table: "DecuongTailieu");

            migrationBuilder.DropColumn(
                name: "mahp",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropColumn(
                name: "maqd",
                table: "DeCuongQuyDinh");

            migrationBuilder.DropColumn(
                name: "mahp",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropColumn(
                name: "manv",
                table: "DeCuongNhiemvu");

            migrationBuilder.DropColumn(
                name: "mahp",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropColumn(
                name: "mahtdg",
                table: "DeCuongHinhthuc");

            migrationBuilder.DropColumn(
                name: "macdmon",
                table: "CLPO");

            migrationBuilder.DropColumn(
                name: "maplo",
                table: "CLPO");

            migrationBuilder.DropColumn(
                name: "macdmon",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropColumn(
                name: "mapphoc",
                table: "CLOPhuongphaphoc");

            migrationBuilder.DropColumn(
                name: "macdmon",
                table: "CLOPhuongphapday");

            migrationBuilder.DropColumn(
                name: "mappday",
                table: "CLOPhuongphapday");

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "Thoigianhoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Hockysmahk",
                table: "Thoigianhoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Khoahocsmakh",
                table: "Thoigianhoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "Phutrach",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GiangVienmagv",
                table: "Phutrach",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "Muctieu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bomonmabm",
                table: "Khoa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "DecuongTailieu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tailieumatl",
                table: "DecuongTailieu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "DeCuongQuyDinh",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "DeCuongNhiemvu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NhiemvuSVmanv",
                table: "DeCuongNhiemvu",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "DeCuongHinhthuc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Chuandaura_monhocmacdmon",
                table: "CLPO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PLOmaplo",
                table: "CLPO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "Chuandaura_monhoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeCuongchiTietmahp",
                table: "Chitietmonhoc",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Chitietmonhocmact",
                table: "Chitiet_Chuong",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GiangVienmagv",
                table: "Bomon",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_DeCuongchiTietmahp",
                table: "Phutrach",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Phutrach_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv");

            migrationBuilder.CreateIndex(
                name: "IX_Muctieu_DeCuongchiTietmahp",
                table: "Muctieu",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Khoa_Bomonmabm",
                table: "Khoa",
                column: "Bomonmabm");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_DeCuongchiTietmahp",
                table: "DecuongTailieu",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DecuongTailieu_Tailieumatl",
                table: "DecuongTailieu",
                column: "Tailieumatl");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_DeCuongchiTietmahp",
                table: "DeCuongQuyDinh",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongQuyDinh_Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh",
                column: "Quydinh_Kiemtramaqd");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_DeCuongchiTietmahp",
                table: "DeCuongNhiemvu",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongNhiemvu_NhiemvuSVmanv",
                table: "DeCuongNhiemvu",
                column: "NhiemvuSVmanv");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_DeCuongchiTietmahp",
                table: "DeCuongHinhthuc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_DeCuongHinhthuc_Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc",
                column: "Hinhthuc_Danhgiamahtdg");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_Chuandaura_monhocmacdmon",
                table: "CLPO",
                column: "Chuandaura_monhocmacdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLPO_PLOmaplo",
                table: "CLPO",
                column: "PLOmaplo");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc",
                column: "Chuandaura_monhocmacdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphaphoc_Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc",
                column: "Phuongphap_hocmapphoc");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday",
                column: "Chuandaura_monhocmacdmon");

            migrationBuilder.CreateIndex(
                name: "IX_CLOPhuongphapday_Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday",
                column: "Phuongphap_Giangdaymappday");

            migrationBuilder.CreateIndex(
                name: "IX_Chuandaura_monhoc_DeCuongchiTietmahp",
                table: "Chuandaura_monhoc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Chitietmonhoc_DeCuongchiTietmahp",
                table: "Chitietmonhoc",
                column: "DeCuongchiTietmahp");

            migrationBuilder.CreateIndex(
                name: "IX_Chitiet_Chuong_Chitietmonhocmact",
                table: "Chitiet_Chuong",
                column: "Chitietmonhocmact");

            migrationBuilder.CreateIndex(
                name: "IX_Bomon_GiangVienmagv",
                table: "Bomon",
                column: "GiangVienmagv");

            migrationBuilder.AddForeignKey(
                name: "FK_Bomon_GiangVien_GiangVienmagv",
                table: "Bomon",
                column: "GiangVienmagv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitiet_Chuong_Chitietmonhoc_Chitietmonhocmact",
                table: "Chitiet_Chuong",
                column: "Chitietmonhocmact",
                principalTable: "Chitietmonhoc",
                principalColumn: "mact",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chitietmonhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Chitietmonhoc",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Chuandaura_monhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Chuandaura_monhoc",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphapday_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphapday",
                column: "Chuandaura_monhocmacdmon",
                principalTable: "Chuandaura_monhoc",
                principalColumn: "macdmon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphapday_Phuongphap_Giangday_Phuongphap_Giangdaymappday",
                table: "CLOPhuongphapday",
                column: "Phuongphap_Giangdaymappday",
                principalTable: "Phuongphap_Giangday",
                principalColumn: "mappday",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphaphoc_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                table: "CLOPhuongphaphoc",
                column: "Chuandaura_monhocmacdmon",
                principalTable: "Chuandaura_monhoc",
                principalColumn: "macdmon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLOPhuongphaphoc_Phuongphap_hoc_Phuongphap_hocmapphoc",
                table: "CLOPhuongphaphoc",
                column: "Phuongphap_hocmapphoc",
                principalTable: "Phuongphap_hoc",
                principalColumn: "mapphoc",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLPO_Chuandaura_monhoc_Chuandaura_monhocmacdmon",
                table: "CLPO",
                column: "Chuandaura_monhocmacdmon",
                principalTable: "Chuandaura_monhoc",
                principalColumn: "macdmon",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CLPO_PLO_PLOmaplo",
                table: "CLPO",
                column: "PLOmaplo",
                principalTable: "PLO",
                principalColumn: "maplo",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongHinhthuc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DeCuongHinhthuc",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongHinhthuc_Hinhthuc_Danhgia_Hinhthuc_Danhgiamahtdg",
                table: "DeCuongHinhthuc",
                column: "Hinhthuc_Danhgiamahtdg",
                principalTable: "Hinhthuc_Danhgia",
                principalColumn: "mahtdg",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongNhiemvu_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DeCuongNhiemvu",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongNhiemvu_NhiemvuSV_NhiemvuSVmanv",
                table: "DeCuongNhiemvu",
                column: "NhiemvuSVmanv",
                principalTable: "NhiemvuSV",
                principalColumn: "manv",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongQuyDinh_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DeCuongQuyDinh",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DeCuongQuyDinh_Quydinh_Kiemtra_Quydinh_Kiemtramaqd",
                table: "DeCuongQuyDinh",
                column: "Quydinh_Kiemtramaqd",
                principalTable: "Quydinh_Kiemtra",
                principalColumn: "maqd",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DecuongTailieu_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "DecuongTailieu",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DecuongTailieu_Tailieu_Tailieumatl",
                table: "DecuongTailieu",
                column: "Tailieumatl",
                principalTable: "Tailieu",
                principalColumn: "matl",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Khoa_Bomon_Bomonmabm",
                table: "Khoa",
                column: "Bomonmabm",
                principalTable: "Bomon",
                principalColumn: "mabm",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Muctieu_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Muctieu",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Phutrach",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phutrach_GiangVien_GiangVienmagv",
                table: "Phutrach",
                column: "GiangVienmagv",
                principalTable: "GiangVien",
                principalColumn: "magv",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thoigianhoc_DeCuongchiTiet_DeCuongchiTietmahp",
                table: "Thoigianhoc",
                column: "DeCuongchiTietmahp",
                principalTable: "DeCuongchiTiet",
                principalColumn: "mahp",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thoigianhoc_Hocky_Hockysmahk",
                table: "Thoigianhoc",
                column: "Hockysmahk",
                principalTable: "Hocky",
                principalColumn: "mahk",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Thoigianhoc_Khoahoc_Khoahocsmakh",
                table: "Thoigianhoc",
                column: "Khoahocsmakh",
                principalTable: "Khoahoc",
                principalColumn: "makh",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
