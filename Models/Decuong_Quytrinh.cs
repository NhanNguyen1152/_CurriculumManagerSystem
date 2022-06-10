using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Decuong_Quytrinh")]
    public class Decuong_Quytrinh
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương quy trình")]
        public int dcht_id { get; set; }

        [ForeignKey("ma_ctdt")]
        [DisplayName("Chương trình đào tạo")]
        public int ma_ctdt { get; set;}
        [ForeignKey("ma_qt_dktn")]
        [DisplayName("Quy trình đào tạo và điều kiện tốt nghiệp")]
        public int ma_qt_dktn { get; set;}
        [ForeignKey("ma_ctdt")]
        public virtual Chuongtrinh_Daotao Chuongtrinh_Daotao { get; set;}
        [ForeignKey("ma_qt_dktn")]
        public virtual Quytrinhdaotao_Dieukientotnghiep Quytrinhdaotao_Dieukientotnghiep { get; set;}
    }
}