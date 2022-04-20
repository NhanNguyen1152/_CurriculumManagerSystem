using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("CLOPhuongphaphoc")]
    public class CLOPhuongphaphoc
    {
        [Key]
        [Required]
        [DisplayName("Mã CLO lớp học")]
        public int maclopphoc { get; set; }
       
        [DisplayName("Mức độ")]
        [StringLength(10)]
        public string mucdo { get; set; }

        [ForeignKey("mapphoc")]
        [DisplayName("Tên phương pháp")]
        public int mapphoc { get; set;}
        [ForeignKey("macdmon")]
        [DisplayName("Chỉ số CLO")]
        public int macdmon { get; set;}
        [ForeignKey("mapphoc")]
        public virtual Phuongphap_hoc Phuongphap_hoc { get; set;}
        [ForeignKey("macdmon")]
        public virtual Chuandaura_monhoc Chuandaura_monhoc { get; set;}
    }
}