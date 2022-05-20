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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_Quydinh
{
    //[ViewComponent]
    public class Get_Quydinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_Quydinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {   
            var result = await _context.DeCuongQuyDinhs.Include(m => m.DeCuongchiTiet).Include(m=> m.Quydinh_Kiemtra).Where(m => m.DeCuongchiTiet.mahp == m.mahp).ToListAsync();
            return View<List<DeCuongQuyDinh>>(result);
        }
    }

}