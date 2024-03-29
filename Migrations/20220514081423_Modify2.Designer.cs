﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _CurriculumManagerSystem.Models;

namespace _CurriculumManagerSystem.Migrations
{
    [DbContext(typeof(acomptec_lvthainhanContext))]
    [Migration("20220514081423_Modify2")]
    partial class Modify2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Bomon", b =>
                {
                    b.Property<int>("mabm")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("magv")
                        .HasColumnType("int");

                    b.Property<string>("tenbm")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("mabm");

                    b.HasIndex("magv");

                    b.ToTable("Bomon");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.CLOPhuongphapday", b =>
                {
                    b.Property<int>("maloppday")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("macdmon")
                        .HasColumnType("int");

                    b.Property<int>("mappday")
                        .HasColumnType("int");

                    b.Property<string>("mucdo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maloppday");

                    b.HasIndex("macdmon");

                    b.HasIndex("mappday");

                    b.ToTable("CLOPhuongphapday");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.CLOPhuongphaphoc", b =>
                {
                    b.Property<int>("maclopphoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("macdmon")
                        .HasColumnType("int");

                    b.Property<int>("mapphoc")
                        .HasColumnType("int");

                    b.Property<string>("mucdo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maclopphoc");

                    b.HasIndex("macdmon");

                    b.HasIndex("mapphoc");

                    b.ToTable("CLOPhuongphaphoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.CLPO", b =>
                {
                    b.Property<int>("maclpo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("macdmon")
                        .HasColumnType("int");

                    b.Property<int>("maplo")
                        .HasColumnType("int");

                    b.Property<DateTime>("ngayupdate")
                        .HasColumnType("datetime2");

                    b.HasKey("maclpo");

                    b.HasIndex("macdmon");

                    b.HasIndex("maplo");

                    b.ToTable("CLPO");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chitiet_Chuong", b =>
                {
                    b.Property<int>("mactchuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("chiso")
                        .HasColumnType("int");

                    b.Property<int>("mact")
                        .HasColumnType("int");

                    b.Property<string>("tentieumuc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("thoiluonghoc")
                        .HasColumnType("float");

                    b.Property<int>("tuanhoc")
                        .HasColumnType("int");

                    b.HasKey("mactchuong");

                    b.HasIndex("mact");

                    b.ToTable("Chitiet_Chuong");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chitietmonhoc", b =>
                {
                    b.Property<int>("mact")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("chiso")
                        .HasColumnType("int");

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<string>("tenchuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tietlt")
                        .HasColumnType("int");

                    b.Property<int>("tietth")
                        .HasColumnType("int");

                    b.HasKey("mact");

                    b.HasIndex("mahp");

                    b.ToTable("Chitietmonhoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chuandaura_monhoc", b =>
                {
                    b.Property<int>("macdmon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("chisocio")
                        .HasColumnType("int");

                    b.Property<string>("loai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<string>("noidung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("macdmon");

                    b.HasIndex("mahp");

                    b.ToTable("Chuandaura_monhoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongHinhthuc", b =>
                {
                    b.Property<int>("dcht_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<int>("mahtdg")
                        .HasColumnType("int");

                    b.HasKey("dcht_id");

                    b.HasIndex("mahp");

                    b.HasIndex("mahtdg");

                    b.ToTable("DeCuongHinhthuc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongNhiemvu", b =>
                {
                    b.Property<int>("dcnv_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<int>("manv")
                        .HasColumnType("int");

                    b.HasKey("dcnv_id");

                    b.HasIndex("mahp");

                    b.HasIndex("manv");

                    b.ToTable("DeCuongNhiemvu");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongQuyDinh", b =>
                {
                    b.Property<int>("dcqd_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<int>("maqd")
                        .HasColumnType("int");

                    b.HasKey("dcqd_id");

                    b.HasIndex("mahp");

                    b.HasIndex("maqd");

                    b.ToTable("DeCuongQuyDinh");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongchiTiet", b =>
                {
                    b.Property<int>("mahp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("mahp_decuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("makkt")
                        .HasColumnType("int");

                    b.Property<int>("sotc_lt")
                        .HasColumnType("int");

                    b.Property<int>("sotc_th")
                        .HasColumnType("int");

                    b.Property<string>("tenhp_tanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenhp_tviet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tomtat_noidunghocphan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("yeucaukhacvoi_hocphan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mahp");

                    b.HasIndex("makkt");

                    b.ToTable("DeCuongchiTiet");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DecuongTailieu", b =>
                {
                    b.Property<int>("dctl_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<int>("matl")
                        .HasColumnType("int");

                    b.HasKey("dctl_id");

                    b.HasIndex("mahp");

                    b.HasIndex("matl");

                    b.ToTable("DecuongTailieu");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.GiangVien", b =>
                {
                    b.Property<int>("magv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chucdanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diachilienhe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hocham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hocvi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("magv");

                    b.ToTable("GiangVien");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Hinhthuc_Danhgia", b =>
                {
                    b.Property<int>("mahtdg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("hinhthuc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thanhphan_danhgia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trongso")
                        .HasColumnType("int");

                    b.HasKey("mahtdg");

                    b.ToTable("Hinhthuc_Danhgia");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Hocky", b =>
                {
                    b.Property<int>("mahk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenhk")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mahk");

                    b.ToTable("Hocky");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Khoa", b =>
                {
                    b.Property<int>("makh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mabm")
                        .HasColumnType("int");

                    b.Property<string>("tenkh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("makh");

                    b.HasIndex("mabm");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Khoahoc", b =>
                {
                    b.Property<int>("makh")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nienkhoa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenkh")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("makh");

                    b.ToTable("Khoahoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Khoikienthuc", b =>
                {
                    b.Property<int>("makkt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("kkt_mota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("kkt_ten")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("makkt");

                    b.ToTable("Khoikienthuc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Muctieu", b =>
                {
                    b.Property<int>("mamt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<string>("mtchinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mtphu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noidung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mamt");

                    b.HasIndex("mahp");

                    b.ToTable("Muctieu");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.NhiemvuSV", b =>
                {
                    b.Property<int>("manv")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("noidung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("manv");

                    b.ToTable("NhiemvuSV");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.PLO", b =>
                {
                    b.Property<int>("maplo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("chisoplo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("noidung")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maplo");

                    b.ToTable("PLO");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Phuongphap_Giangday", b =>
                {
                    b.Property<int>("mappday")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenpp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mappday");

                    b.ToTable("Phuongphap_Giangday");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Phuongphap_hoc", b =>
                {
                    b.Property<int>("mapphoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenpp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mapphoc");

                    b.ToTable("Phuongphap_hoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Phutrach", b =>
                {
                    b.Property<int>("mapt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("magv")
                        .HasColumnType("int");

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<string>("vaitro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mapt");

                    b.HasIndex("magv");

                    b.HasIndex("mahp");

                    b.ToTable("Phutrach");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Quydinh_Kiemtra", b =>
                {
                    b.Property<int>("maqd")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tenqd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("maqd");

                    b.ToTable("Quydinh_Kiemtra");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Tailieu", b =>
                {
                    b.Property<int>("matl")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("loaitl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tacgia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tentailieu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thongtinkhac")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("matl");

                    b.ToTable("Tailieu");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Thoigianhoc", b =>
                {
                    b.Property<int>("matg")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("mahk")
                        .HasColumnType("int");

                    b.Property<int>("mahp")
                        .HasColumnType("int");

                    b.Property<int>("makh")
                        .HasColumnType("int");

                    b.Property<string>("yeucauhocphan")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("matg");

                    b.HasIndex("mahk");

                    b.HasIndex("mahp");

                    b.HasIndex("makh");

                    b.ToTable("Thoigianhoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Bomon", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.GiangVien", "GiangVien")
                        .WithMany("Bomons")
                        .HasForeignKey("magv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GiangVien");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.CLOPhuongphapday", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Chuandaura_monhoc", "Chuandaura_monhoc")
                        .WithMany("CLOPhuongphapdays")
                        .HasForeignKey("macdmon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.Phuongphap_Giangday", "Phuongphap_Giangday")
                        .WithMany("CLOPhuongphapdays")
                        .HasForeignKey("mappday")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chuandaura_monhoc");

                    b.Navigation("Phuongphap_Giangday");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.CLOPhuongphaphoc", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Chuandaura_monhoc", "Chuandaura_monhoc")
                        .WithMany("CLOPhuongphaphocs")
                        .HasForeignKey("macdmon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.Phuongphap_hoc", "Phuongphap_hoc")
                        .WithMany("CLOPhuongphaphocs")
                        .HasForeignKey("mapphoc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chuandaura_monhoc");

                    b.Navigation("Phuongphap_hoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.CLPO", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Chuandaura_monhoc", "Chuandaura_monhoc")
                        .WithMany("CPLOs")
                        .HasForeignKey("macdmon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.PLO", "PLO")
                        .WithMany("CLPOs")
                        .HasForeignKey("maplo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chuandaura_monhoc");

                    b.Navigation("PLO");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chitiet_Chuong", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Chitietmonhoc", "Chitietmonhoc")
                        .WithMany("Chitiet_Chuongs")
                        .HasForeignKey("mact")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chitietmonhoc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chitietmonhoc", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("Chitietmonhocs")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chuandaura_monhoc", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("Chuandaura_monhocs")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongHinhthuc", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("DeCuongHinhthucs")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.Hinhthuc_Danhgia", "Hinhthuc_Danhgia")
                        .WithMany("DeCuongHinhthucs")
                        .HasForeignKey("mahtdg")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");

                    b.Navigation("Hinhthuc_Danhgia");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongNhiemvu", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("DeCuongNhiemvus")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.NhiemvuSV", "NhiemvuSV")
                        .WithMany("DeCuongNhiemvus")
                        .HasForeignKey("manv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");

                    b.Navigation("NhiemvuSV");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongQuyDinh", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("DeCuongQuyDinhs")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.Quydinh_Kiemtra", "Quydinh_Kiemtra")
                        .WithMany("DeCuongQuyDinhs")
                        .HasForeignKey("maqd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");

                    b.Navigation("Quydinh_Kiemtra");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongchiTiet", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Khoikienthuc", "Khoikienthuc")
                        .WithMany("DeCuongchiTiets")
                        .HasForeignKey("makkt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoikienthuc");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DecuongTailieu", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("DecuongTailieus")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.Tailieu", "Tailieu")
                        .WithMany("DecuongTailieus")
                        .HasForeignKey("matl")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");

                    b.Navigation("Tailieu");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Khoa", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Bomon", "Bomon")
                        .WithMany("Khoas")
                        .HasForeignKey("mabm")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bomon");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Muctieu", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("Muctieus")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Phutrach", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.GiangVien", "GiangVien")
                        .WithMany("Phutraches")
                        .HasForeignKey("magv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("Phutraches")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");

                    b.Navigation("GiangVien");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Thoigianhoc", b =>
                {
                    b.HasOne("_CurriculumManagerSystem.Models.Hocky", "Hockys")
                        .WithMany("Thoigianhocs")
                        .HasForeignKey("mahk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.DeCuongchiTiet", "DeCuongchiTiet")
                        .WithMany("Thoigianhocs")
                        .HasForeignKey("mahp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_CurriculumManagerSystem.Models.Khoahoc", "Khoahocs")
                        .WithMany("Thoigianhocs")
                        .HasForeignKey("makh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeCuongchiTiet");

                    b.Navigation("Hockys");

                    b.Navigation("Khoahocs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Bomon", b =>
                {
                    b.Navigation("Khoas");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chitietmonhoc", b =>
                {
                    b.Navigation("Chitiet_Chuongs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Chuandaura_monhoc", b =>
                {
                    b.Navigation("CLOPhuongphapdays");

                    b.Navigation("CLOPhuongphaphocs");

                    b.Navigation("CPLOs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.DeCuongchiTiet", b =>
                {
                    b.Navigation("Chitietmonhocs");

                    b.Navigation("Chuandaura_monhocs");

                    b.Navigation("DeCuongHinhthucs");

                    b.Navigation("DeCuongNhiemvus");

                    b.Navigation("DeCuongQuyDinhs");

                    b.Navigation("DecuongTailieus");

                    b.Navigation("Muctieus");

                    b.Navigation("Phutraches");

                    b.Navigation("Thoigianhocs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.GiangVien", b =>
                {
                    b.Navigation("Bomons");

                    b.Navigation("Phutraches");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Hinhthuc_Danhgia", b =>
                {
                    b.Navigation("DeCuongHinhthucs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Hocky", b =>
                {
                    b.Navigation("Thoigianhocs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Khoahoc", b =>
                {
                    b.Navigation("Thoigianhocs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Khoikienthuc", b =>
                {
                    b.Navigation("DeCuongchiTiets");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.NhiemvuSV", b =>
                {
                    b.Navigation("DeCuongNhiemvus");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.PLO", b =>
                {
                    b.Navigation("CLPOs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Phuongphap_Giangday", b =>
                {
                    b.Navigation("CLOPhuongphapdays");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Phuongphap_hoc", b =>
                {
                    b.Navigation("CLOPhuongphaphocs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Quydinh_Kiemtra", b =>
                {
                    b.Navigation("DeCuongQuyDinhs");
                });

            modelBuilder.Entity("_CurriculumManagerSystem.Models.Tailieu", b =>
                {
                    b.Navigation("DecuongTailieus");
                });
#pragma warning restore 612, 618
        }
    }
}
