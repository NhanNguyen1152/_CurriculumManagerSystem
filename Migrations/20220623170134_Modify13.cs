using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _CurriculumManagerSystem.Migrations
{
    public partial class Modify13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "Tailieu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "Tailieu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "Phuongphap_hoc",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "Phuongphap_hoc",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "Phuongphap_Giangday",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "Phuongphap_Giangday",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "NhiemvuSV",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "NhiemvuSV",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "Hinhthuc_Danhgia",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "Hinhthuc_Danhgia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "maso_giangvien",
                table: "GiangVien",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "matkhau",
                table: "GiangVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vaitro",
                table: "GiangVien",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "DeCuongchiTiet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "DeCuongchiTiet",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "khoahoc_apdung",
                table: "Chuongtrinh_Daotao",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "manguoitao",
                table: "Chuongtrinh_Daotao",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "thoigiantao",
                table: "Chuongtrinh_Daotao",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "Tailieu");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "Tailieu");

            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "Phuongphap_hoc");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "Phuongphap_hoc");

            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "Phuongphap_Giangday");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "Phuongphap_Giangday");

            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "NhiemvuSV");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "NhiemvuSV");

            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "Hinhthuc_Danhgia");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "Hinhthuc_Danhgia");

            migrationBuilder.DropColumn(
                name: "maso_giangvien",
                table: "GiangVien");

            migrationBuilder.DropColumn(
                name: "matkhau",
                table: "GiangVien");

            migrationBuilder.DropColumn(
                name: "vaitro",
                table: "GiangVien");

            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "DeCuongchiTiet");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "DeCuongchiTiet");

            migrationBuilder.DropColumn(
                name: "khoahoc_apdung",
                table: "Chuongtrinh_Daotao");

            migrationBuilder.DropColumn(
                name: "manguoitao",
                table: "Chuongtrinh_Daotao");

            migrationBuilder.DropColumn(
                name: "thoigiantao",
                table: "Chuongtrinh_Daotao");
        }
    }
}
