using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DeCuongNhiemvu")]
    public class DeCuongNhiemvu
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương nhiệm vụ")]
        public int dcnv_id { get; set; }
    }
}