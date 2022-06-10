using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Quytrinhdaotao_Dieukientotnghiep")]
    public class Quytrinhdaotao_Dieukientotnghiep
    {
        [Key]
        [Required]
        [DisplayName("Mã quy trình đào tạo và điều kiện tốt nghiệp")]
        public int ma_qt_dktn { get; set; }
        [DisplayName("Nội dung")]
        public string noi_dung_quytrinhdieukien { get; set; }
    }
}