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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_Nhiemvu
{
    public class Create_Nhiemvu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_Nhiemvu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(int? id)
        { 
             var listNhiemvu = (from b in _context.NhiemvuSVs
                          select new NhiemvuSV
                          {
                              manv = b.manv,
                              noidung = b.noidung
                          }).ToList();
            ViewData.Model = listNhiemvu;

            
            return View();
        }
    }
}