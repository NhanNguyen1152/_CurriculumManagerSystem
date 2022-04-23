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
        public string mucdo { get; set; }       

        [ForeignKey("mappday")]
        [DisplayName("Tên phương pháp")]
        public int mappday { get; set;}
        [ForeignKey("macdmon")]
        [DisplayName("Chỉ số CLO")]
        public int macdmon { get; set;}
        [ForeignKey("mappday")]

        [DisplayName("Phương pháp giảng dạy")]
        public virtual Phuongphap_Giangday Phuongphap_Giangday { get; set;}

        [DisplayName("Chuẩn đầu ra môn học")]
        [ForeignKey("macdmon")]
        public virtual Chuandaura_monhoc Chuandaura_monhoc { get; set;} 
    }
}