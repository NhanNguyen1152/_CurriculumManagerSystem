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

        public virtual ICollection<Bomon> Bomons { get; set; }
        public virtual IList<Phutrach> Phutraches { get; set; }
    }
}