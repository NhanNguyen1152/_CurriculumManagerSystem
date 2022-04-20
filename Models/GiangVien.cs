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
        [StringLength(50)]
        [DisplayName("Họ và tên")]
        public string hoten { get; set; }
        [StringLength(50)]
        [DisplayName("Chức danh")]
        public string chucdanh { get; set; }
        [StringLength(50)]
        [DisplayName("Học hàm")]
        public string hocham { get; set; }
        [StringLength(50)]
        [DisplayName("Học vị")]
        public string hocvi { get; set; }
        [StringLength(100)]
        [DisplayName("Địa chỉ liên hệ")]
        public string diachilienhe { get; set; }

        public virtual ICollection<Bomon> Bomons { get; set; }
        public virtual IList<Phutrach> Phutraches { get; set; }
    }
}