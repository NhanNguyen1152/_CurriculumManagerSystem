using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Quydinh_Kiemtra")]
    public class Quydinh_Kiemtra
    {
        [Key]
        [Required]
        [DisplayName("Mã quy định")]
        public int maqd { get; set; }
        [StringLength(80)]
        [DisplayName("Tên quy định và kiểm tra")]
        public string tenqd { get; set; }

        public virtual IList<DeCuongQuyDinh> DeCuongQuyDinhs { get; set; }
    }
}