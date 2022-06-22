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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_CTDT_PLO_Muctieudaotao
{
    //[ViewComponent]
    public class Get_CTDT_PLO_Muctieudaotao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_CTDT_PLO_Muctieudaotao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                
                var listMuctieu_ct = _context.CTDT_Muctieudaotaos.Include(m => m.Chuongtrinh_Daotao).Include(m => m.Muctieu_Daotao).Where(m=> m.ma_ctdt == HttpContext.Session.GetInt32("id_ctdt_ss_create")).ToList();
                     ViewBag.listMuctieu_ct = listMuctieu_ct.ToList();
                var result = await _context.MoiquanhePLO_Muctieudaotaos.Include(m=> m.PLO).Include(m=> m.Muctieu_Daotao).OrderBy(m=> m.PLO.chisoplo).ToListAsync();
            return View(result);
            
               
            }
            else
            {
                  var listMuctieu_ct = _context.CTDT_Muctieudaotaos.Include(m => m.Chuongtrinh_Daotao).Include(m => m.Muctieu_Daotao).Where(m=> m.ma_ctdt == HttpContext.Session.GetInt32("id_edit_ctdt_after")).ToList();
                    ViewBag.listMuctieu_ct = listMuctieu_ct.ToList();
                 var result = await _context.MoiquanhePLO_Muctieudaotaos.Include(m=> m.PLO).Include(m=> m.Muctieu_Daotao).OrderBy(m=> m.PLO.chisoplo).ToListAsync();
            return View(result);
            }
            
            return View();
            
        }
    }

}