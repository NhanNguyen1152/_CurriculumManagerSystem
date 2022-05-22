using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("CLPO")]
    public class CLPO
    {
        [Key]
        [Required]
        [DisplayName("Mã CLPO")]
        public int maclpo { get; set; }
        [DisplayName("Ngày cập nhật")]
        public DateTime ngayupdate { get; set; }

        [ForeignKey("macdmon")]
        [DisplayName("Chuẩn đầu ra môn học")]
        public int macdmon { get; set;}
        [ForeignKey("maplo")]
        [DisplayName("Chỉ số PLO")]
        public int maplo { get; set;}
        [ForeignKey("macdmon")]
        [DisplayName("Chuẩn đầu ra môn học")]
        public virtual Chuandaura_monhoc Chuandaura_monhoc { get; set;}
        [ForeignKey("maplo")]
        public virtual PLO PLO { get; set;}
    }
}