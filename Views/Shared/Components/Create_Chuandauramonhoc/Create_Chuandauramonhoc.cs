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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_Chuandauramonhoc
{
    public class Create_Chuandauramonhoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_Chuandauramonhoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? id)
        { 
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