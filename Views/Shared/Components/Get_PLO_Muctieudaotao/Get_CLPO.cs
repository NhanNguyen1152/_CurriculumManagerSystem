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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_PLO_Muctieudaotao
{
    //[ViewComponent]
    public class Get_PLO_Muctieudaotao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_PLO_Muctieudaotao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                var result = await _context.MoiquanhePLO_Muctieudaotaos.Include(c => c.PLO).Include(c=> c.Muctieu_Daotao).ToListAsync();
                    return View<List<MoiquanhePLO_Muctieudaotao>>(result);
            }
            else
            {
                var result = await _context.MoiquanhePLO_Muctieudaotaos.Include(c => c.PLO).Include(c=> c.Muctieu_Daotao).ToListAsync();
                    return View<List<MoiquanhePLO_Muctieudaotao>>(result);
            }
            return View();
            
        }
    }

}