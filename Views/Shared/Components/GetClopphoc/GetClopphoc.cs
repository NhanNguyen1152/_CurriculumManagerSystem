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

namespace _CurriculumManagerSystem.Views.Shared.Components.GetClopphoc
{
    //[ViewComponent]
    public class GetClopphoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public GetClopphoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                 var result = await _context.CLOPhuongphaphocs.Include(c => c.Chuandaura_monhoc).Include(c => c.Phuongphap_hoc).Where(m => m.Chuandaura_monhoc.mahp == HttpContext.Session.GetInt32("idDecuong")).ToListAsync();
                 return View<List<CLOPhuongphaphoc>>(result);
               
            }
            else
            {
                var result = await _context.CLOPhuongphaphocs.Include(c => c.Chuandaura_monhoc).Include(c => c.Phuongphap_hoc).Where(m => m.Chuandaura_monhoc.mahp == HttpContext.Session.GetInt32("id_edit_dccht_after")).ToListAsync();
                 return View<List<CLOPhuongphaphoc>>(result);
            }
            
            return View();
        }
    }

}