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
        public string yeucauhocphan { get; set; }
        
        [ForeignKey("mahp")]
        [DisplayName("Đề cương chi tiết")]
        public int mahp { get; set; }

        [ForeignKey("makh")]
        [DisplayName("Khóa học")]
        public int makh { get; set; }
        [ForeignKey("mahk")]
        [DisplayName("Học kỳ")]
        public int mahk { get; set; }
        
        [ForeignKey("mahp")]
        public virtual DeCuongchiTiet DeCuongchiTiet { get; set; }  
        [ForeignKey("makh")]
        public virtual Khoahoc Khoahocs { get; set; }
        [ForeignKey("mahk")]
        public virtual Hocky Hockys { get; set; }
    }
}