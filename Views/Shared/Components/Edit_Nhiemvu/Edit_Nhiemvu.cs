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
            //  var listNhiemvu = (from b in _context.NhiemvuSVs
            //               select new NhiemvuSV
            //               {
            //                   manv = b.manv,
            //                   noidung = b.noidung
            //               }).ToList();
            // ViewData.Model = listNhiemvu;

             var result = await _context.DeCuongNhiemvus.Include(m => m.DeCuongchiTiet).Include(m=> m.NhiemvuSV).Where(m => m.DeCuongchiTiet.mahp == HttpContext.Session.GetInt32("id_edit_dccht_after")).ToListAsync();
                //  ViewData.Model = result;
                return View<List<DeCuongNhiemvu>>(result);
            // var result =  _context.DeCuongNhiemvus.Include(m => m.DeCuongchiTiet).Include(m=> m.NhiemvuSV).Where(m => m.DeCuongchiTiet.mahp == HttpContext.Session.GetInt32("id_edit_dccht_after")).ToListAsync();
           
            // TempData["id_nv"] = result.mahp;

            
        }
    }
}