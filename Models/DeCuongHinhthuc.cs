using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DeCuongHinhthuc")]
    public class DeCuongHinhthuc
    {
        [Key]
        [Required]
        [DisplayName("Mã đề cương hình thức")]
        public int dcht_id { get; set; }
    }
}