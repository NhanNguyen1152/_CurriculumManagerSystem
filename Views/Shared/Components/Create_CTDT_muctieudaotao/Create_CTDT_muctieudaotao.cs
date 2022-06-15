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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_CTDT_muctieudaotao
{
    public class Create_CTDT_muctieudaotao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_CTDT_muctieudaotao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            var listMT = (from b in _context.Muctieu_Daotaos
                          select new Muctieu_Daotao
                          {
                              ma_mtdt = b.ma_mtdt,
                              mtdt_chiso = b.mtdt_chiso,
                            noi_dung = b.noi_dung
                          }).ToList();
            ViewData.Model = listMT;
            return View();
        }
    }
}