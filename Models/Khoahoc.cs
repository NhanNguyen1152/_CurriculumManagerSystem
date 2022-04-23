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
       public string tenkh {get; set;}
       
       [DisplayName("Niên khóa")]
       public string nienkhoa { get; set;} 
       
       public virtual ICollection<Thoigianhoc> Thoigianhocs { get; set; }
    }
}