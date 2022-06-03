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
            HttpContext.Session.SetInt32("id_pdf", id);
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets
            .FirstOrDefaultAsync(m => m.mahp == id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }

            return View(deCuongchiTiet);
        }
    }
}