using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("NhiemvuSV")]
    public class NhiemvuSV
    {
        [Key]
        [Required]
        [DisplayName("Mã nhiệm vụ")]
        public int manv { get; set; }
        [StringLength(500)]
        [DisplayName("Nội dung")]
        public string noidung { get; set; }

        public virtual IList<DeCuongNhiemvu> DeCuongNhiemvus { get; set; } 
    }
}