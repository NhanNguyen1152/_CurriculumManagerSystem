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
    }
}