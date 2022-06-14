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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_doituongtuyensinh
{
    public class Pdf_ctdt_doituongtuyensinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_doituongtuyensinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
       
        // public async Task<IViewComponentResult> InvokeAsync(int id)
        // {   
            
        //     var listplo = _context.PLOs;
        //     ViewBag.listplo = listplo.ToList();
        //     var listmuctieudaotao = _context.Muctieu_Daotaos;
        //     ViewBag.listmuctieudaotao = listmuctieudaotao.ToList();
        //     // var listMuctieudaotao = _context.CTDT_Muctieudaotaos.Include(m => m.Chuongtrinh_Daotao).Include(m => m.Muctieu_Daotao).Where(m=> m.ma_ctdt == id).ToList();
        //     // ViewBag.listMuctieudaotao = listMuctieudaotao.ToList();
        //     var result = await _context.MoiquanhePLO_Muctieudaotaos.Include(m=> m.PLO).Include(m=> m.Muctieu_Daotao).OrderBy(m=> m.PLO.chisoplo).ToListAsync();
            
        //     return View(result);
        // }

        public IViewComponentResult Invoke()
        {   
            return View();
        }
    }
}