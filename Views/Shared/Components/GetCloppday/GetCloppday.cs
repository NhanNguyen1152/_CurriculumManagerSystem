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

namespace _CurriculumManagerSystem.Views.Shared.Components.GetCloppday
{
    //[ViewComponent]
    public class GetCloppday : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public GetCloppday(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                 var result = await _context.CLOPhuongphapdays.Include(c => c.Chuandaura_monhoc).Include(c => c.Phuongphap_Giangday).Where(m => m.Chuandaura_monhoc.mahp == HttpContext.Session.GetInt32("idDecuong")).ToListAsync();
                 return View<List<CLOPhuongphapday>>(result);
               
            }
            else
            {
                var result = await _context.CLOPhuongphapdays.Include(c => c.Chuandaura_monhoc).Include(c => c.Phuongphap_Giangday).Where(m => m.Chuandaura_monhoc.mahp == HttpContext.Session.GetInt32("id_edit_dccht_after")).ToListAsync();
                 return View<List<CLOPhuongphapday>>(result);
            }
            
            return View();
        }
    }

}