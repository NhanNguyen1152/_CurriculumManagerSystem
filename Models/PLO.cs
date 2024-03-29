using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("PLO")]
    public class PLO
    {
        [Key]
        [Required]
        [DisplayName("Mã PLO")]
        public int maplo { get; set; }
        [DisplayName("Chỉ số PLO")]
        public string chisoplo { get; set; }
        [DisplayName("Nội dung")]
        public string noidung { get; set; }
        [DisplayName("Tên loại PLO")]
        public string tenloai_plo { get; set; }
        [DisplayName("Chi tiết tên")]
        public string chitietten_plo { get; set; }

        public virtual IList<CLPO> CLPOs { get; set; }
    }
}