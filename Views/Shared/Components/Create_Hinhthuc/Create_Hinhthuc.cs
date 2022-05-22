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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_Hinhthuc
{
    public class Create_Hinhthuc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_Hinhthuc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        { 
            var listHinhthuc = (from b in _context.Hinhthuc_Danhgias
                          select new Hinhthuc_Danhgia
                          {
                              mahtdg = b.mahtdg,
                              thanhphan_danhgia = b.thanhphan_danhgia,
                              hinhthuc = b.hinhthuc
                          }).ToList();
            ViewData.Model = listHinhthuc;
            return View ();
        }
    }
}