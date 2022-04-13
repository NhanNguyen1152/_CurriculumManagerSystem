using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Phuongphap_hoc")]
    public class Phuongphap_hoc
    {   
        [Key]
        [Required]
        [DisplayName("Mã phương pháp học")]
        public int mapphoc { get; set; }
        [DisplayName("Tên phương pháp học")]
        [StringLength(50)]
        public string tenpp { get; set; }

        public virtual IList<CLOPhuongphaphoc> CLOPhuongphaphocs { get; set; }
    }
}