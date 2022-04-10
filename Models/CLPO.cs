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
        [DisplayName("Ngày update")]
        public DateTime ngayupdate { get; set; }
    }
}