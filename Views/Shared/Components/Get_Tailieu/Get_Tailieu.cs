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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_Tailieu
{
    //[ViewComponent]
    public class Get_Tailieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_Tailieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {   
            var result = await _context.DecuongTailieus.Include(m => m.DeCuongchiTiet).Include(m=> m.Tailieu).Where(m => m.DeCuongchiTiet.mahp == m.mahp).ToListAsync();
            return View<List<DecuongTailieu>>(result);
        }
    }

}