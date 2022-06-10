using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Chitiet_Doituong")]
    public class Chitiet_Doituong
    {
        [Key]
        [Required]
        [DisplayName("Mã chi tiết đối tượng")]
        public int ma_ct_dt { get; set; }

        [ForeignKey("ma_ctdt")]
        [DisplayName("Chương trình đào tạo")]
        public int ma_ctdt { get; set;}
        [ForeignKey("ma_dtts")]
        [DisplayName("Đối tượng tuyển sinh")]
        public int ma_dtts { get; set;}
        [ForeignKey("ma_ctdt")]
        public virtual Chuongtrinh_Daotao Chuongtrinh_Daotao { get; set;}
        [ForeignKey("ma_dtts")]
        public virtual Doituong_Tuyensinh Doituong_Tuyensinh { get; set;}
    }
}