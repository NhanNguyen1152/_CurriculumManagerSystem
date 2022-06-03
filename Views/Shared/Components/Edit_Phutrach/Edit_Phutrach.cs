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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Phutrach
{
    public class Edit_Phutrach : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Phutrach(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            HttpContext.Session.SetInt32("id_edit_pt", id);
            if (id == null)
            {                     
                return View();
            }

            var phutrach = await _context.Phutrachs.FindAsync(id);
            if (phutrach == null)
            {
                return View();
            }
            return View(phutrach);
        }
    }
}