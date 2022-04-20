using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Phutrach")]
    public class Phutrach
    {
        [Key]
        [Required]
        [DisplayName("Mã phụ trách")]
        public int mapt { get; set; }
        [StringLength(50)]
        [DisplayName("Vai trò")]
        public string vaitro { get; set; }

        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set;}
        [ForeignKey("magv")]
        [DisplayName("Tên giảng viên")]
        public int magv { get; set;}
        [ForeignKey("mahp")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set; }
        [ForeignKey("magv")]
        public virtual GiangVien GiangVien { get; set; }
    }
}
