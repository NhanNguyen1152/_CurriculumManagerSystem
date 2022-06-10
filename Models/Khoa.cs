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
        [DisplayName("Tên khoa")]
        public string tenkh { get; set; }
        public virtual ICollection<Bomon> Bomons { get; set; }


    }
}
