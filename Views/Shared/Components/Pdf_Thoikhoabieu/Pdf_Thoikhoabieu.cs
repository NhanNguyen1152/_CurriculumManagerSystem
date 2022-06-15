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
            var dataTimetable = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).Include(t => t.Hockys).Include(t => t.Khoahocs).Where(t => t.Khoahocs.tenkh == ten).OrderBy(t => t.Hockys.tenhk);
            TempData["listData"] = dataTimetable.ToList();
            return View();
        }
    }
}
