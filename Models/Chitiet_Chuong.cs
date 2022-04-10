using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Chitiet_Chuong")]
    public class Chitiet_Chuong
    {
        [Key]
        [Required]
        [DisplayName("Mã chi tiết chương")]
        public int mactchuong { get; set; }
        [DisplayName("Chỉ số")]
        public int chiso { get; set; }
        [StringLength(100)]
        [DisplayName("Tên tiểu mục")]
        public string tentieumuc { get; set; }
        [DisplayName("Tuần học")]
        public int tuanhoc { get; set; }
        [DisplayName("Thời lượng")]
        public double thoiluonghoc { get; set; }

        [ForeignKey("mact")]
        public int mact { get; set; }
        public Chitietmonhoc Chitietmonhoc { get; set; }
    }
}