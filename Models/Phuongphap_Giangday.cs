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
        public string tenpp { get; set; }
        [DisplayName("Người tạo")]
        public int manguoitao { get; set; }
        [DisplayName("Thời gian tạo")]
        public DateTime thoigiantao { get; set; }
        
        public virtual IList<CLOPhuongphapday> CLOPhuongphapdays { get; set; }
    }
}