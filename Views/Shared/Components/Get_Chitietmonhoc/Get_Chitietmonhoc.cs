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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_Chitietmonhoc
{
    //[ViewComponent]
    public class Get_Chitietmonhoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_Chitietmonhoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                 var result = await _context.Chitietmonhocs.Include(m => m.DeCuongchiTiet).Where(m => m.DeCuongchiTiet.mahp == HttpContext.Session.GetInt32("idDecuong")).ToListAsync();
                 return View<List<Chitietmonhoc>>(result);
               
            }
            else
            {
                 var result = await _context.Chitietmonhocs.Include(m => m.DeCuongchiTiet).Where(m => m.DeCuongchiTiet.mahp == HttpContext.Session.GetInt32("id_edit_dccht_after")).ToListAsync();
                 return View<List<Chitietmonhoc>>(result);
            }
        }
    }

}