using System.Threading;
using System.ComponentModel;
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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_CTDT_decuongquytrinh
{
    public class Edit_CTDT_decuongquytrinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_CTDT_decuongquytrinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            var listQT = (from b in _context.Quytrinhdaotao_Dieukientotnghieps
                          select new Quytrinhdaotao_Dieukientotnghiep
                          {
                              ma_qt_dktn = b.ma_qt_dktn,
                            noi_dung_quytrinhdieukien = b.noi_dung_quytrinhdieukien
                          }).ToList();
            ViewData.Model = listQT;
            return View();
        }
    }
}