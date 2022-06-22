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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Tailieu
{
    public class Edit_Tailieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Tailieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

         public async Task<IViewComponentResult> InvokeAsync(int matailieu)
        { 
            // HttpContext.Session.SetInt32("id_create_tl", id );
            var tailieu = await _context.Tailieus.FindAsync(matailieu);
            return View(tailieu);
        }
    }
}