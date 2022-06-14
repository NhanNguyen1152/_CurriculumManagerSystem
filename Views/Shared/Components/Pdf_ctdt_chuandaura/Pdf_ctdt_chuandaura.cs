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


namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_chuandaura
{
    public class Pdf_ctdt_chuandaura : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_chuandaura(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
       
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            
            // var listMuctieudaotao = _context.CTDT_Muctieudaotaos.Include(m => m.Chuongtrinh_Daotao).Include(m => m.Muctieu_Daotao).Where(m=> m.ma_ctdt == id).ToList();
            // ViewBag.listMuctieudaotao = listMuctieudaotao.ToList();
            var result = await _context.MoiquanhePLO_Muctieudaotaos.Include(m=> m.PLO).Include(m=> m.Muctieu_Daotao).OrderBy(m=> m.PLO.chisoplo).ToListAsync();
            
            return View(result);
        }
    }
}