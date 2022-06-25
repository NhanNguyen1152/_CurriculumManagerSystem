using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Hinhthuc_Danhgia")]
    public class Hinhthuc_Danhgia
    {
        [Key]
        [Required]
        [DisplayName("Mã hình thức đánh giá")]
        public int mahtdg { get; set; }
        [DisplayName("Thành phần đánh giá")]
        public string thanhphan_danhgia { get; set;}
        [DisplayName("Hình thức đánh giá")]
        public string hinhthuc { get; set; }
        [DisplayName("Trọng số")]
        public int trongso { get; set; }
        [DisplayName("Người tạo")]
        public int manguoitao { get; set; }
        [DisplayName("Thời gian tạo")]
        public DateTime thoigiantao { get; set; }
        
        public virtual IList<DeCuongHinhthuc> DeCuongHinhthucs { get; set; } 
    }
}