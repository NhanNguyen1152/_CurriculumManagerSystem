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

            var listtgh = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).Include(t => t.Khoahocs).Include(t => t.Hockys).Where(t=> t.DeCuongchiTiet.mahp == id).ToList();
            ViewBag.listtgh = listtgh;

             var listpt = _context.Phutrachs.Include(m => m.DeCuongchiTiet).Include(m=> m.GiangVien).Where(m => m.DeCuongchiTiet.mahp == id).Where(m=> m.vaitro=="Người phụ trách").ToList();
             ViewBag.listpt = listpt;

            var listptc = _context.Phutrachs.Include(m => m.DeCuongchiTiet).Include(m=> m.GiangVien).Where(m => m.DeCuongchiTiet.mahp == id).Where(m=> m.vaitro =="Giảng viên tham gia giảng dạy cùng").ToList();
             ViewBag.listptc = listptc;

             var listgv = _context.Phutrachs.Include(m => m.DeCuongchiTiet).Include(m=> m.GiangVien).Where(m => m.DeCuongchiTiet.mahp == id).Select(m=> m.GiangVien.magv).ToList();
             ViewBag.listgv = listgv;

            var listkhoa = _context.GiangViens.Include(b => b.Bomon).ThenInclude(m=> m.Khoa).ToList();
             ViewBag.listkhoa = listkhoa;

            //cdr
             var listPpday_cdr = _context.Chuandaura_Monhocs.Where(c=> c.mahp == id).OrderBy(c=> c.chisocio);
            ViewBag.listPpday_cdr = listPpday_cdr.ToList();

            HttpContext.Session.SetInt32("id_pdf", id);
            return View();
        }
       
        
    }
}