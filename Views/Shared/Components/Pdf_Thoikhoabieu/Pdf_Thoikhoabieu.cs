using System.Text.RegularExpressions;
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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Thoikhoabieu
{
    public class Pdf_Thoikhoabieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Thoikhoabieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var result = await _context.Decuong_Chuongtrinhs.Include(d => d.DeCuongchiTiet).ThenInclude(d => d.Thoigianhocs).ThenInclude(d => d.Hockys).Where(d=> d.ma_ctdt == id).ToListAsync();
            // var dataTimetable = await _context.Decuong_Chuongtrinhs.Include(d => d.DeCuongchiTiet).ThenInclude(d => d.Thoigianhocs).ThenInclude(d => d.Hockys).Where(d=> d.ma_ctdt == id).ToListAsync();
            // TempData["listData"] = dataTimetable.ToList();
            // return View();
            return View<List<Decuong_Chuongtrinh>>(result);
        }
    }
}

// public IActionResult getThoikhoabieu(string khoahoc)
//         {
//             ViewBag.kk = khoahoc;
//             var dataTimetable = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).ThenInclude(t => t.Khoikienthuc).Include(t => t.Hockys).Include(t => t.Khoahocs).Where(t => t.Khoahocs.tenkh == khoahoc);
//             TempData["listData"] = dataTimetable.ToList();
//             return View();
//         }

//         ViewBag.kk = khoahoc;
//             var dataTimetable = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).ThenInclude(t => t.Khoikienthuc).Include(t => t.Hockys).Include(t => t.Khoahocs).Where(t => t.Khoahocs.tenkh == khoahoc);
//             TempData["listDatas"] = dataTimetable.ToList();
 