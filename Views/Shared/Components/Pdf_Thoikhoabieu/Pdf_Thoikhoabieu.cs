using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Thoikhoabieu
{
    public class Pdf_Thoikhoabieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Thoikhoabieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(string ten)
        {
            var dataTimetable = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).Include(t => t.Hockys).Include(t => t.Khoahocs).Where(t => t.Khoahocs.tenkh == ten);
            TempData["listData"] = dataTimetable.ToList();
            return View();
        }
        
        // public async Task<IViewComponentResult> InvokeAsync(int id)
        // {
        //     var viewModels = new Ctdt_pdf_thoikhoabieu();
        //     viewModels.DeCuongchiTiets =
        //         await _context
        //             .DeCuongchiTiets
        //             .Include(d => d.Decuong_Chuongtrinhs)
        //             .Include(d => d.Thoigianhocs)
        //                 .ThenInclude(d => d.Hockys)
        //             //.Where(d => d.Decuong_Chuongtrinhs.ma_ctdt == id)
        //             .ToListAsync();
        //     return View(viewModels);
        // }
    }
}

// public IActionResult getThoikhoabieu(string khoahoc)
//         {
//             ViewBag.kk = khoahoc;
//             var dataTimetable = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).ThenInclude(t => t.Khoikienthuc).Include(t => t.Hockys).Include(t => t.Khoahocs).Where(t => t.Khoahocs.tenkh == khoahoc);
//             TempData["listData"] = dataTimetable.ToList();
//             return View();
//         }