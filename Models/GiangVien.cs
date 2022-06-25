using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _CurriculumManagerSystem.Models
{
    [Table("GiangVien")]
    public class GiangVien
    {
        [Key]
        [Required]
        [DisplayName("Mã giảng viên")]
        public int magv { get; set; }
        [DisplayName("Họ và tên")]
        public string hoten { get; set; }
        [DisplayName("Chức danh")]
        public string chucdanh { get; set; }
        [DisplayName("Học hàm")]
        public string hocham { get; set; }
        [DisplayName("Học vị")]
        public string hocvi { get; set; }
        [DisplayName("Địa chỉ liên hệ")]
        public string diachilienhe { get; set; }
        [DisplayName("Mã số giảng viên")]
        public int maso_giangvien { get; set; }
        [DisplayName("Mật khẩu")]
        public string matkhau { get; set; }
        [DisplayName("Vai trò đối với hệ thống")]
        public string vaitro { get; set; }

        [ForeignKey("mabm")]
        [DisplayName("Mã bộ môn")]
        public int mabm { get; set; }
        [ForeignKey("mabm")]
        public virtual Bomon Bomon { get; set; }
        public virtual IList<Phutrach> Phutraches { get; set; }
    }
}