using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;

namespace _CurriculumManagerSystem.Models
{
    public class acomptec_lvthainhanContext : DbContext
    {
        public acomptec_lvthainhanContext(DbContextOptions<acomptec_lvthainhanContext> options) : base(options)
        {
            
        }
        
        public DbSet<Bomon> Bomons { get; set;}
        public DbSet<Chitiet_Chuong> Chitiet_Chuongs { get; set;}
        public DbSet<Chitietmonhoc> Chitietmonhocs { get; set;}
        public DbSet<Chuandaura_monhoc> Chuandaura_Monhocs { get; set;}
        public DbSet<CLOPhuongphapday> CLOPhuongphapdays { get; set;}
        public DbSet<CLOPhuongphaphoc> CLOPhuongphaphocs { get; set;}
        public DbSet<CLPO> CLPOs { get; set;}
        public DbSet<DeCuongchiTiet> DeCuongchiTiets { get; set;}
        public DbSet<DeCuongHinhthuc> DeCuongHinhthucs { get; set;}
        public DbSet<DeCuongNhiemvu> DeCuongNhiemvus { get; set;}
        public DbSet<DeCuongQuyDinh> DeCuongQuyDinhs { get; set;}
        public DbSet<DecuongTailieu> DecuongTailieus { get; set;}
        public DbSet<GiangVien> GiangViens { get; set;}
        public DbSet<Hinhthuc_Danhgia> Hinhthuc_Danhgias { get; set;}
        public DbSet<Hocky> Hockys { get; set;}
        public DbSet<Khoa> Khoas { get; set;}
        public DbSet<Khoahoc> Khoahocs { get; set;}
        public DbSet<Muctieu> Muctieus { get; set;}
        public DbSet<NhiemvuSV> NhiemvuSVs { get; set;}
        public DbSet<Phuongphap_Giangday> Phuongphap_Giangdays { get; set;}
        public DbSet<Phuongphap_hoc> Phuongphap_Hocs { get; set;}
        public DbSet<Phutrach> Phutrachs { get; set;}
        public DbSet<PLO> PLOs { get; set;}
        public DbSet<Quydinh_Kiemtra> Quydinh_Kiemtras { get; set;}
        public DbSet<Tailieu> Tailieus { get; set;}
        public DbSet<Thoigianhoc> Thoigianhocs { get; set;}
        public DbSet<Khoikienthuc> Khoikienthucs { get; set; }
        public DbSet<Muctieu_Daotao> Muctieu_Daotaos { get; set; }
        public DbSet<MoiquanhePLO_Muctieudaotao> MoiquanhePLO_Muctieudaotaos { get; set; }
        public DbSet<Chuongtrinh_Daotao> Chuongtrinh_Daotaos { get; set;}
        public DbSet<Decuong_Chuongtrinh> Decuong_Chuongtrinhs { get; set;}
        public DbSet<Quytrinhdaotao_Dieukientotnghiep> Quytrinhdaotao_Dieukientotnghieps { get; set;}
        public DbSet<Doituong_Tuyensinh> Doituong_Tuyensinhs { get; set;}
        public DbSet<Decuong_Quytrinh> Decuong_Quytrinhs { get; set;}
        public DbSet<Chitiet_Doituong> Chitiet_Doituongs { get; set;}
        public DbSet<CTDT_Muctieudaotao> CTDT_Muctieudaotaos { get; set;}
    }
}