using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Khoikienthuc")]
    public class Khoikienthuc
    {
        [Key]
        [Required]
        [DisplayName("Mã khối kiến thức")]
        public int makkt { get; set; }
        [DisplayName("Tên khối kiến thức")]
        public string kkt_ten { get; set; }
        [DisplayName("Mô tả")]
        public string kkt_mota { get; set; }
        public ICollection<DeCuongchiTiet> DeCuongchiTiets { get; set;}
    }
}