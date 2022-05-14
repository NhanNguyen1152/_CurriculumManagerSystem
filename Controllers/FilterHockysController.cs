using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;

namespace _CurriculumManagerSystem.Controllers
{
    public class FilterHockysController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public FilterHockysController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var get_Hocky = _context.Hockys;
            return View(await get_Hocky.ToListAsync());
        }
        
        public async Task<IActionResult> Filter()
        {
            var get_Hocky_Decuongchitiet = _context.DeCuongchiTiets.Join(_context.Thoigianhocs, d => d.mahp, t => t.mahp, (d,t) => new {DeCuongchiTiet = d, Thoigianhoc = t}).Join(_context.Hockys, t => t.Thoigianhoc.mahk, h => h.mahk, (t, h) => new {Thoigianhoc = t, Hocky = h});
            ViewData["getdata"] = new SelectList(get_Hocky_Decuongchitiet, "getdata", "getdata");
            return View(await get_Hocky_Decuongchitiet.ToListAsync());
        }
    }
}