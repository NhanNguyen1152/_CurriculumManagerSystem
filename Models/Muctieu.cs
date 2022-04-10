using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Muctieu")]
    public class Muctieu
    {
        [Key]
        [Required]
        [DisplayName("Mã mục tiêu")]
        public int mamt { get; set; }
        [StringLength(200)]
        [DisplayName("Nội dung")]
        public string noidung { get; set; }
        [DisplayName("Mục tiêu chính")]
        public string mtchinh { get; set; }
        [DisplayName("Mục tiêu phụ")]
        public string mtphu { get; set; }

        [ForeignKey("mahp")]
        public int mahp { get; set; }
        public DeCuongchiTiet DeCuongchiTiet { get; set; }
    }
}