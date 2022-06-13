using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("CTDT_Muctieudaotao")]
    public class CTDT_Muctieudaotao
    {
        [Key]
        [Required]
        [DisplayName("Mã CTDT_MTDT")]
        public int ma_ctdt_mtdt { get; set;}

        [ForeignKey("ma_ctdt")]
        [DisplayName("Chương trình đào tạo")]
        public int ma_ctdt { get; set;}
        [ForeignKey("ma_mtdt")]
        [DisplayName("Mục tiêu đào tạo")]
        public int ma_mtdt { get; set;}
        [ForeignKey("ma_ctdt")]
        public virtual Chuongtrinh_Daotao Chuongtrinh_Daotao { get; set;}
        [ForeignKey("ma_mtdt")]
        public virtual Muctieu_Daotao Muctieu_Daotao { get; set;}
    }
}