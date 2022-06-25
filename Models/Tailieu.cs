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
        [DisplayName("Tác giả")]
        public string tacgia { get; set; }
        [DisplayName("Tên tài liệu")]
        public string tentailieu { get; set; }
        [DisplayName("Thông tin khác")]
        public string thongtinkhac { get; set; }
        [DisplayName("Loại tài liệu")]
        public string loaitl { get; set; }
        [DisplayName("Người tạo")]
        public int manguoitao { get; set; }
        [DisplayName("Thời gian tạo")]
        public DateTime thoigiantao { get; set; }

        public virtual IList<DecuongTailieu> DecuongTailieus { get; set; }
    }
}
