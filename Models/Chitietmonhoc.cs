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
        [DisplayName("Số tiết lý thuyết")]
        public int tietlt { get; set; }
        [DisplayName("Số tiết thực hành")]
        public int tietth { get; set; }

        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set; }
        [ForeignKey("mahp")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set; }
        public virtual ICollection<Chitiet_Chuong> Chitiet_Chuongs { get; set; }
    }
}