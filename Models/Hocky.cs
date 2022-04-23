using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Hocky")]
    public class Hocky
    {
        [Key]
        [Required]
        [DisplayName("Mã học kỳ")]
        public int mahk { get; set; }

        
        [DisplayName("Tên học kỳ")]
        public string tenhk { get; set; }     
        
        public virtual ICollection<Thoigianhoc> Thoigianhocs { get; set; }
    }
}