using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Khoahoc")]
    public class Khoahoc
    {
       [Key]
       [Required]
       [DisplayName("Mã khóa học")]
       public int makh { get; set; }
       [DisplayName("Tên khóa học")]
       [StringLength(50)]
       public string tenkh {get; set;}
       [DisplayName("Niên khóa")]
       [StringLength(10)]
       public string nienkhoa { get; set;} 
       
       public virtual ICollection<Thoigianhoc> Thoigianhocs { get; set; }
    }
}