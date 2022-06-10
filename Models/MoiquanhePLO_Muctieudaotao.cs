using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("MoiquanhePLO_Muctieudaotao")]
    public class MoiquanhePLO_Muctieudaotao
    {
        [Key]
        [Required]
        [DisplayName("Mã PLO_Mục tiêu đào tạo")]
        public int ma_plo_mtdt { get; set; }
        [DisplayName("Ngày cập nhật")]
        public DateTime ngay_update { get; set; }

        [ForeignKey("maplo")]
        [DisplayName("Chỉ số PLO")]
        public int maplo { get; set;}
        [ForeignKey("ma_mtdt")]
        [DisplayName("Mã mục tiêu đào tạo")]
        public int ma_mtdt { get; set;}
        
        [ForeignKey("maplo")]
        public virtual PLO PLO { get; set;}
        [ForeignKey("ma_mtdt")]
        public virtual Muctieu_Daotao Muctieu_Daotao { get; set;}
    }
}