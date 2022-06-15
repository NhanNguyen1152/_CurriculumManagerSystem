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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_CTDT_chuongtrinhdaotao
{
    public class Edit_CTDT_chuongtrinhdaotao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_CTDT_chuongtrinhdaotao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            HttpContext.Session.SetInt32("id_edit_ctdt_after", id );
            TempData["id_edit_ctdt_after"] = id;

            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos.FindAsync(id);
            return View(chuongtrinh_Daotao);
        }
    }
}