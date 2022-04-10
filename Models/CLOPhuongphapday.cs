using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("CLOPhuongphapday")]
    public class CLOPhuongphapday
    {
        [Key]
        [Required]
        [DisplayName("Mã CLO phương pháp dạy")]
        public int maloppday { get; set; }
        [DisplayName("Mức độ")]
        [StringLength(10)]
        public string mucdo { get; set; }        
    }
}