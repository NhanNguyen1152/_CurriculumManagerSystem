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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_Chitietchuong
{
    //[ViewComponent]
    public class Get_Chitietchuong : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_Chitietchuong(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        {   
            var result = await _context.Chitiet_Chuongs.Include(m => m.Chitietmonhoc).Where(m => m.Chitietmonhoc.mact == m.mactchuong).ToListAsync();
            return View<List<Chitiet_Chuong>>(result);
        }
    }

}