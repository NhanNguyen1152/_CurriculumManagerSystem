using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DeCuongQuyDinh")]
    public class DeCuongQuyDinh
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương quy định")]
        public int dcqd_id { get; set; }
    }
}