using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    [Table("DeCuongchiTiet")]
    public class DeCuongchiTiet
    {
        [Key]
        [Required]
        [DisplayName("Mã học phần")]
        public int mahp { get; set; }
        [StringLength(100)]
        [DisplayName("Tên học phần tiếng việt")]
        public string tenhp_tviet { get; set; }
        [StringLength(150)]
        [DisplayName("Tên học phần tiếng anh")]
        public string tenhp_tanh { get; set; }
        [DisplayName("Số tính chỉ lý thuyết")]
        public int sotc_lt { get; set; }
        [DisplayName("Số tính chỉ thực hành")]
        public int sotc_th { get; set; }
        [StringLength(150)]
        [DisplayName("Yêu cầu khác với học phần")]
        public string yeucaukhacvoi_hocphan { get; set; }
        [StringLength(500)]
        [DisplayName("Tóm tắt nội dung học phần")]
        public string tomtat_noidunghocphan { get; set; }

        public ICollection<Chitietmonhoc> Chitietmonhocs { get; set;}
        public ICollection<Muctieu> Muctieus { get; set; }
        public IList<DecuongTailieu> DecuongTailieus { get; set; }
        public IList<Phutrach> Phutraches { get; set; }
        public IList<DeCuongQuyDinh> DeCuongQuyDinhs { get; set; }
        public IList<DeCuongNhiemvu> DeCuongNhiemvus { get; set; }
        public IList<DeCuongHinhthuc> DeCuongHinhthucs { get; set; }
        public ICollection<Thoigianhoc> Thoigianhocs { get; set; }
        public ICollection<Chuandaura_monhoc> Chuandaura_monhocs { get; set; }
    }
}