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
        public string tenpp { get; set; }
        [DisplayName("Người tạo")]
        public int manguoitao { get; set; }
        [DisplayName("Thời gian tạo")]
        public DateTime thoigiantao { get; set; }
        public virtual IList<CLOPhuongphaphoc> CLOPhuongphaphocs { get; set; }
    }
}