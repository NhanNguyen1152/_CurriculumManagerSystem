using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("Chuongtrinh_Daotao")]
    public class Chuongtrinh_Daotao
    {
        [Key]
        [Required]
        [DisplayName("Mã chương trình đào tạo")]
        public int ma_ctdt { get; set; }
        [DisplayName("Ngành đào tạo")]
        public string nganh_daotao { get; set; }
        [DisplayName("Trình độ đào tạo")]
        public string trinhdo_daotao { get; set; }
        [DisplayName("Loại hình đào tạo")]
        public string loaihinh_daotao { get; set; }
        [DisplayName("Thời gian đào tạo")]
        public string thoigian_daotao { get; set; }
        [DisplayName("Tên văn bằng")]
        public string tenvanbang { get; set; }
        [DisplayName("Nơi đào tạo")]
        public string noidaotao { get; set; }
        [DisplayName("Mã số")]
        public string maso_ctdt { get; set; }
        [DisplayName("Nội dung chương trình đào tạo")]
        public string noidung_ctdt { get; set; }

        public IList<Decuong_Chuongtrinh> Decuong_Chuongtrinhs { get; set; }
        public IList<CTDT_Muctieudaotao> CTDT_Muctieudaotaos { get; set; }
    }
}