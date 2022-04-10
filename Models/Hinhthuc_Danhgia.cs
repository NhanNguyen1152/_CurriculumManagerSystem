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
        [StringLength(50)]
        public string thanhphan_danhgia { get; set;}
        [DisplayName("Hình thức")]
        [StringLength(50)]
        public string hinhthuc { get; set; }
        [DisplayName("Trọng số")]
        public int trongso { get; set; }
        
        public IList<DeCuongHinhthuc> DeCuongHinhthucs { get; set; } 
    }
}