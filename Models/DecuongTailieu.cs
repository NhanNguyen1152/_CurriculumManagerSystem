using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DecuongTailieu")]
    public class DecuongTailieu
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương tài liệu")]
        public int dctl_id { get; set;}
    }
}