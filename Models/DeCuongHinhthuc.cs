using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DeCuongHinhthuc")]
    public class DeCuongHinhthuc
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương hình thức")]
        public int dcht_id { get; set; }

        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set;}
        [ForeignKey("mahtdg")]
        [DisplayName("Hình thức")]
        public int mahtdg { get; set;}
        [ForeignKey("mahp")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set;}
        [ForeignKey("mahtdg")]
        public virtual Hinhthuc_Danhgia Hinhthuc_Danhgia { get; set;}
    }
}