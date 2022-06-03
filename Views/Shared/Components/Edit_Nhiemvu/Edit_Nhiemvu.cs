using System.Net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;
using Microsoft.AspNetCore.Http;

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Nhiemvu
{
    public class Edit_Nhiemvu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Nhiemvu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
                public async Task<IViewComponentResult> InvokeAsync()
        { 
          
        //    var listNhiemvu = (from b in _context.NhiemvuSVs
        //                   select new NhiemvuSV
        //                   {
        //                       manv = b.manv,
        //                       noidung = b.noidung
        //                   });
        //     ViewData.Model = listNhiemvu


            
                // var listNhiemvu = _context.DeCuongNhiemvus
                // .Include(m => m.NhiemvuSV)
                // .Include(z=> z.DeCuongchiTiet)
                // .Select(m => new DeCuongNhiemvu { manv = m.NhiemvuSV.manv, noidung = m.NhiemvuSV.noidung })
                // .ToList();
                // ViewData.Model = listNhiemvu;
               //return View();
           
             var result = await _context.DeCuongNhiemvus.Include(m => m.DeCuongchiTiet).Include(m=> m.NhiemvuSV).ToListAsync();
             
            return View<List<DeCuongNhiemvu>>(result);
         

            
        }
    }
}