using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _CurriculumManagerSystem.Models
{
    [Table("Bomon")]
    public class Bomon
    {
        [Key]
        [Required]
        [DisplayName("Mã bộ môn")]
        public int mabm { get; set; }
        [StringLength(100)]
        [DisplayName("Tên bộ môn")]
        public string tenbm { get; set; }

        [ForeignKey("makh")]
        [DisplayName("Mã khoa")]
        public int makh { get; set; }
        [ForeignKey("makh")]
        public virtual Khoa Khoa { get; set; }

        public virtual ICollection<GiangVien> Giangviens { get; set; }
    }
}