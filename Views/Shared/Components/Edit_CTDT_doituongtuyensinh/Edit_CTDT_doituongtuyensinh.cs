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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_CTDT_doituongtuyensinh
{
    public class Edit_CTDT_doituongtuyensinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_CTDT_doituongtuyensinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var listDT = (from b in _context.Doituong_Tuyensinhs
                          select new Doituong_Tuyensinh
                          {
                              ma_dtts = b.ma_dtts,
                            noi_dung_dtts = b.noi_dung_dtts
                          }).ToList();
            ViewData.Model = listDT;
            return View();
        }
    }
}