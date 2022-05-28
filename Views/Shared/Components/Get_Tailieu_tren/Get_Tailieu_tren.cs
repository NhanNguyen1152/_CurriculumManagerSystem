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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_Tailieu_tren
{
    //[ViewComponent]
    public class Get_Tailieu_tren : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_Tailieu_tren(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            // var result = await _context.Tailieus.Include(m=> m.DecuongTailieu).where(m=> m.DecuongTailieu.mahp == HttpContext.Session.GetInt32("idDecuong")).ToListAsync();
            // // var result = await _context.Tailieus.Include(m => m.DecuongTailieu).where(m => m.DecuongTailieu == HttpContext.Session.GetInt32("idDecuong")).ToListAsync();
            //  return View<List<Tailieu>>(result);
            return View(await _context.Tailieus.ToListAsync());
        }
    }

}