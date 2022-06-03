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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Chuandauramonhoc
{
    public class Edit_Chuandauramonhoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Chuandauramonhoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            HttpContext.Session.SetInt32("id_edit_cdrmh", id );
            if (id == null)
            {                     
                return View();
            }

            var muctieu = await _context.Chuandaura_Monhocs.FindAsync(id);
            if (muctieu == null)
            {
                return View();
            }
            return View(muctieu);
        }
    }
}