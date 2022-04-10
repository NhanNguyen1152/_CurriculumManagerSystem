using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Khoa")]
    public class Khoa
    {
        [Key]
        [Required]
        [DisplayName("Mã khoa")]
        public int makh { get; set; }
        [StringLength(50)]
        [DisplayName("Tên khoa")]
        public string tenkh { get; set; }

        [ForeignKey("mabm")]
        public int mabm { get; set; }
        public Bomon Bomon { get; set; }
    }
}
