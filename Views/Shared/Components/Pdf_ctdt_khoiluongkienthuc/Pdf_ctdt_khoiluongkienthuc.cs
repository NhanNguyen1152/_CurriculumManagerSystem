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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_khoiluongkienthuc
{
    public class Pdf_ctdt_khoiluongkienthuc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_khoiluongkienthuc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var listtgh = _context.Thoigianhocs.Include(t => t.Hockys).ToList();
            ViewBag.listtgh = listtgh;
            var appDbContext = _context.Decuong_Chuongtrinhs.Include(d => d.DeCuongchiTiet).ThenInclude(d => d.Khoikienthuc).Where(d => d.ma_ctdt == id);
            TempData["listData"] = appDbContext.ToList();
            return View();
        }
    }
}

// public IActionResult getNoidungCTDT()
//         {
//             var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc);
//             TempData["listData"] = appDbContext.ToList();
//             return View();
//         }