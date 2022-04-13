using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Phuongphap_Giangday")]
    public class Phuongphap_Giangday
    {
        [Key]
        [Required]
        [DisplayName("Mã phương pháp giảng dạy")]
        public int mappday { get; set; }
        [DisplayName("Tên phương pháp giảng dạy")]
        [StringLength(50)]
        public string tenpp { get; set; }
        
        public virtual IList<CLOPhuongphapday> CLOPhuongphapdays { get; set; }
    }
}