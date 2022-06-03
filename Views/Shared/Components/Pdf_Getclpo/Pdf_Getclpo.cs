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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Getclpo
{
    //[ViewComponent]
    public class Pdf_Getclpo : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Getclpo(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var acomptec_lvthainhanContext = _context.CLPOs.Include(c => c.Chuandaura_monhoc).ThenInclude(c => c.DeCuongchiTiet).Include(c => c.PLO).Where(c=> c.Chuandaura_monhoc.mahp == id).OrderBy(c=> c.Chuandaura_monhoc.chisocio).OrderBy(c=> c.PLO.chisoplo);
             return View(await acomptec_lvthainhanContext.ToListAsync());
        }
    }

}