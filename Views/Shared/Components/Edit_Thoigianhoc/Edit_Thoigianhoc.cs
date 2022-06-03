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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Thoigianhoc
{
    public class Edit_Thoigianhoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Thoigianhoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            HttpContext.Session.SetInt32("id_edit_Thoigianhoc", id);
            if (id == null)
            {                     
                return View();
            }

            var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            if (thoigianhoc == null)
            {
                return View();
            }
            return View(thoigianhoc);
        }
    }
}