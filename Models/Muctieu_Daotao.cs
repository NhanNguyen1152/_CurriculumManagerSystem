using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Muctieu_Daotao")]
    public class Muctieu_Daotao
    {
        [Key]
        [Required]
        [DisplayName("Mã mục tiêu đào tạo")]
        public int ma_mtdt { get; set; }
        [DisplayName("Nội dung")]
        public string noi_dung { get; set; }
        [DisplayName("Mục tiêu đào tạo chính")]
        public string mtdt_chinh { get; set; }
        [DisplayName("Mục tiêu đào tạo phụ")]
        public string mtdt_phu { get; set; }
    }
}