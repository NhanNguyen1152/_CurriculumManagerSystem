using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Muctieu")]
    public partial class Muctieu
    {
        [Key]
        [Required]  
        [DisplayName("Mã mục tiêu")]
        public int mamt { get; set; }
        [DisplayName("Nội dung")]
        public string noidung { get; set; }
        [DisplayName("Mục tiêu chính")]
        public string mtchinh { get; set; }
        [DisplayName("Mục tiêu phụ")]
        public string mtphu { get; set; }

        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set; }
        [ForeignKey("mahp")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set; }
    }
}