using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _CurriculumManagerSystem.Models
{
    public class Ctdt_pdf_thoikhoabieu
    {
        public IEnumerable<DeCuongchiTiet> DeCuongchiTiets { get; set; }
        public IEnumerable<Decuong_Chuongtrinh> Decuong_Chuongtrinhs { get; set; }
        public IEnumerable<Thoigianhoc> Thoigianhocs { get; set; }
        public IEnumerable<Hocky> Hockys { get; set; }
    }
}