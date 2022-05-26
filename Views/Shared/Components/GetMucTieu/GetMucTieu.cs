using System.Net.WebSockets;
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

namespace _CurriculumManagerSystem.Views.Shared.Components.GetMucTieu
{
    //[ViewComponent]
    public class GetMucTieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public GetMucTieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                 var result = await _context.Muctieus.Include(m => m.DeCuongchiTiet).Where(m => m.DeCuongchiTiet.mahp == HttpContext.Session.GetInt32("idDecuong")).ToListAsync();
                 return View<List<Muctieu>>(result);
               
            }
            else
            {
                 var result = await _context.Muctieus.Include(m => m.DeCuongchiTiet).Where(m => m.DeCuongchiTiet.mahp == HttpContext.Session.GetInt32("id_edit_dccht_after")).ToListAsync();
                 return View<List<Muctieu>>(result);
            }
            
            return View();
        }
    }

}