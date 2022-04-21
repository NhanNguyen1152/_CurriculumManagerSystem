using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DecuongTailieu")]
    public class DecuongTailieu
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương tài liệu")]
        public int dctl_id { get; set;}
        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set;}
        [ForeignKey("matl")]
        [DisplayName("Tên tài liệu")]
        public int matl { get; set;}
        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set;}
        [ForeignKey("matl")]
        [DisplayName("Tên tài liệu")]
        public virtual Tailieu Tailieu { get; set;}

    }
}