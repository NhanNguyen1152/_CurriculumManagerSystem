using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Decuong_Chuongtrinh")]
    public class Decuong_Chuongtrinh
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương chương trình")]
        public int ma_dc_ct { get; set; }

        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set;}
        [ForeignKey("ma_ctdt")]
        [DisplayName("Mã chương trình đào tạo")]
        public int ma_ctdt { get; set;}
        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set;}
        [ForeignKey("ma_ctdt")]
        [DisplayName("Chương trình đào tạo")]
        public virtual Chuongtrinh_Daotao Chuongtrinh_Daotao { get; set;}
    }
}