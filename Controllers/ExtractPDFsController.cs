using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Runtime.Intrinsics.X86;
using System.Net.Cache;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Net.Http;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace _CurriculumManagerSystem.Controllers
{
    public class ExtractPDFsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public ExtractPDFsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Extract(int id)
        {
            
            var listPlo = _context.PLOs.OrderBy(m=> m.maplo).ToList();
            ViewBag.listPlo = listPlo;

            var leftOuterJoin = from e in _context.PLOs  
            join d in _context.CLPOs on e.maplo equals d.maplo into pl  
            from plnew in pl.DefaultIfEmpty()  
            select new PLO {maplo = e.maplo}; 
            ViewBag.leftouterjoin = leftOuterJoin.ToList();
            // var query =
            // from CLPO in _context.CLPOs
            // join PLO in _context.PLOs on PLO.maplo equals CLPO.maplo into gj
            // from subpet in gj.DefaultIfEmpty()
            // select new
            // {
            //     PLO.maplo
                
            // }.ToList();

            // var leftouterjoin = ( from clpo in _context.CLPOs
                
            //     join plo in _context.PLOs on clpo.maplo equals plo.maplo into ot

            //     from otnew in ot.DefaultIfEmpty()

            //     select new (plo = c , c.maplo).ToList()
            // );
          

            //  var plos = _context.CLPOs.Include(c => c.Chuandaura_monhoc).Include(c => c.PLO).Where(c=> c.Chuandaura_monhoc.mahp == id).OrderBy(c=> c.Chuandaura_monhoc.chisocio);
            // {
            //     foreach (var item in plos)
            //     {
            //         foreach (var items in listplo)
            //         {
            //             if(@item.macdmon == @item.Chuandaura_monhoc.macdmon && @item.maplo == @items.maplo)

            //             plos.Add();
            //         }
            //     }
            // }
            // ViewBag.plos = plos;
            //  var lPlo = _context.PLOs;
            // TempData["lPlo"] = lPlo.ToList();
            
            // var listPlos = _context.CLPOs.Select(m=> m.maplo).ToList();
            // ViewBag.listPlos = listPlos;

            HttpContext.Session.SetInt32("id_pdf", id);
            return View();
        }
       
        
    }
}