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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_CTDT_plo_muctieudaotao
{
    public class Create_CTDT_plo_muctieudaotao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_CTDT_plo_muctieudaotao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int moiquanhe_plo_mt)
        { 
              var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos.FindAsync(moiquanhe_plo_mt);
            return View(moiquanhePLO_Muctieudaotao);
        }
    }
}