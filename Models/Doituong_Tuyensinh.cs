using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Doituong_Tuyensinh")]
    public class Doituong_Tuyensinh
    {
        [Key]
        [Required]
        [DisplayName("Mã đối tượng tuyển sinh")]
        public int ma_dtts { get; set; }
        [DisplayName("Nội dung")]
        public string noi_dung_dtts { get; set; }
    }
}