using System.Xml.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Cloppday
{
    //[ViewComponent]
    public class Pdf_Cloppday : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Cloppday(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

         public async Task<IViewComponentResult> InvokeAsync(int id)
        {  
            var listPpday = _context.Phuongphap_Giangdays;
            ViewBag.listPpday = listPpday.ToList();
              var listPpday_cdr = _context.Chuandaura_Monhocs.Where(c=> c.mahp == id).OrderBy(c=> c.chisocio);
            ViewBag.listPpday_cdr = listPpday_cdr.ToList();
             var acomptec_lvthainhanContext = _context.CLOPhuongphapdays.Include(c => c.Phuongphap_Giangday).Include(c => c.Chuandaura_monhoc).Where(c=> c.Chuandaura_monhoc.mahp == id).OrderBy(c=> c.Chuandaura_monhoc.chisocio);
            return View(await acomptec_lvthainhanContext.ToListAsync());
            
        }
        
    }

}
// var acomptec_lvthainhanContext = await _context.CLPOs.Include(c => c.Chuandaura_monhoc).ThenInclude(c => c.DeCuongchiTiet).Include(c => c.PLO).Where(c=> c.Chuandaura_monhoc.mahp == id).OrderBy(c=> c.Chuandaura_monhoc.chisocio).OrderBy(c=> c.PLO.chisoplo).ToListAsync();
//             return View();
//    var plos = _context.PLOs;
        //     {
                // //lay tat ca bang PLO
                // foreach (PLO d in plos)
                // {
                //     //lay du lieu theo PLCO co id cua PLO
                //     foreach (CLPO c in d.PLOS)
                //     {
                //         PLOSList.Add();
                //     }
                // }
                // var listCLPO = _context.PLOS.Include(c => c.PLO);
                // return View(listCLPO.ToList());
                // var viewModel = new CLPOsIndexdata();
                // viewModel.PLOs = _context.PLOS.Include(c => c.Chuandaura_monhoc)
                // .ThenInclude(c => c.DeCuongchiTiet)
                // .Include(c => c.PLO)
                // .Where(c=> c.Chuandaura_monhoc.mahp == id)
                // .OrderBy(c=> c.Chuandaura_monhoc.chisocio)
                // .OrderBy(c=> c.PLO.chisoplo);
                // return View(viewModel);
            // }
            // public List<PLO> GetPLO()
        // {
        //      List<PLO> listPLO = new List<PLO>();
        //         var mylistPLO = _context.PLOs;
        //             foreach (var itemPLO in mylistPLO)
        //                 {
        //                     listPLO.Add(itemPLO);
        //                 }
        //                     return listPLO.ToList();
        // }