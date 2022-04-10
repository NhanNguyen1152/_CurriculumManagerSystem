using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Chuandaura_monhoc")]
    public class Chuandaura_monhoc
    {
        [Key]
        [Required]
        [DisplayName("Mã chuẩn đầu ra môn học")]
        public int macdmon { get; set; }
        [DisplayName("Chỉ số cio")]
        [StringLength(10)]
        public int chisocio { get; set; }
        [DisplayName("Nội dung")]
        [StringLength(100)]
        public string noidung { get; set; }
        [DisplayName("Loại")]
        [StringLength(10)]
        public string loai { get; set; }

        [ForeignKey("mahp")]
        public int mahp { get; set;}
        
        public DeCuongchiTiet DeCuongchiTiet { get; set; }
        public IList<CLPO> CPLOs { get; set; }
        public IList<CLOPhuongphapday> CLOPhuongphapdays { get; set; }
        public IList<CLOPhuongphaphoc> CLOPhuongphaphocs { get; set; }
        
    }
}