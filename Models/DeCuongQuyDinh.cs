using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DeCuongQuyDinh")]
    public class DeCuongQuyDinh
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương quy định")]
        public int dcqd_id { get; set; }

        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set;}
        [ForeignKey("maqd")]
        [DisplayName("Tên quyết định và kiểm tra")]
        public int maqd { get; set;}
        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set;}
        [ForeignKey("maqd")]
        [DisplayName("Tên quyết định và kiểm tra")]
        public virtual Quydinh_Kiemtra Quydinh_Kiemtra { get; set;}
    }
}