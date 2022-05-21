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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_Phutrach
{
    //[ViewComponent]
    public class Get_Phutrach : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_Phutrach(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {   
            var result = await _context.Phutrachs.Include(m => m.DeCuongchiTiet).Where(m => m.DeCuongchiTiet.mahp == id).ToListAsync();
            return View<List<Phutrach>>(result);
        }
    }

}