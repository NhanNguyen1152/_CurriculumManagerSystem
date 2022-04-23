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
        public int chisocio { get; set; }
        [DisplayName("Nội dung")]
        public string noidung { get; set; }
        [DisplayName("Loại")]
        public string loai { get; set; }

        [DisplayName("Mã học phần")]
        [ForeignKey("mahp")]
        public int mahp { get; set;}
        [ForeignKey("mahp")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set; }
        public virtual IList<CLPO> CPLOs { get; set; }
        public virtual IList<CLOPhuongphapday> CLOPhuongphapdays { get; set; }
        public virtual IList<CLOPhuongphaphoc> CLOPhuongphaphocs { get; set; }
        
    }
}