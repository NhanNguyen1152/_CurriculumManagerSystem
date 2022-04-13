using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Tailieu")]
    public class Tailieu
    {
        [Key]
        [Required]
        [DisplayName("Mã tài liệu")]
        public int matl { get; set; }
        [StringLength(100)]
        [DisplayName("Tác giả")]
        public string tacgia { get; set; }
        [StringLength(150)]
        [DisplayName("Tên tài liệu")]
        public string tentailieu { get; set; }
        [StringLength(150)]
        [DisplayName("Thông tin khác")]
        public string thongtinkhac { get; set; }
        [StringLength(50)]
        [DisplayName("Loại tài liệu")]
        public string loaitl { get; set; }

        public virtual IList<DecuongTailieu> DecuongTailieus { get; set; }
    }
}