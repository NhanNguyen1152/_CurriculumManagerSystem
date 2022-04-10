using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Chitietmonhoc")]
    public class Chitietmonhoc
    {
        [Key]
        [Required]
        [DisplayName("Mã chi tiết")]
        public int mact { get; set; }
        [DisplayName("Chỉ số")]
        public int chiso { get; set; }
        [StringLength(150)]
        [DisplayName("Tên chương")]
        public string tenchuong { get; set; }
        [DisplayName("Tiết lý thuyết")]
        public int tietlt { get; set; }
        [DisplayName("Tiết thực hành")]
        public int tietth { get; set; }

        [ForeignKey("mahp")]
        public int mahp { get; set; }
        public DeCuongchiTiet DeCuongchiTiet { get; set; }
        public ICollection<Chitiet_Chuong> Chitiet_Chuongs { get; set; }
    }
}