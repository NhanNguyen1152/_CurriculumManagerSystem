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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Quydinh
{
    public class Edit_Quydinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Quydinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int? id)
        { 
            var listQuyDinh = (from b in _context.Quydinh_Kiemtras
                          select new Quydinh_Kiemtra
                          {
                              maqd = b.maqd,
                              tenqd = b.tenqd
                          }).ToList();
            ViewData.Model = listQuyDinh;
            return View ();
        }
    }
}