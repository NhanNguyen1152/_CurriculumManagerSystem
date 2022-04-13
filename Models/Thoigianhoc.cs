using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Thoigianhoc")]
    public class Thoigianhoc
    {
        [Key]
        [Required]
        [DisplayName("Mã thời gian học")]
        public int matg { get; set; }

        [DisplayName("Yêu cầu học phần")]
        [StringLength(50)]
        public string yeucauhocphan { get; set; }
        
        [ForeignKey("mahp")]
        [DisplayName("Mã đề cương chi tiết")]
        public int mahp { get; set; }

        [ForeignKey("makh")]
        [DisplayName("Mã khóa học")]
        public int makh { get; set; }
        [ForeignKey("mahk")]
        [DisplayName("Mã học kỳ")]
        public int mahk { get; set; }
        
        public DeCuongchiTiet DeCuongchiTiet { get; set; }  
        public Khoahoc Khoahocs { get; set; }
        public Hocky Hockys { get; set; }
    }
}