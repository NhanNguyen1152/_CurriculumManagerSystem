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

        public async Task<IViewComponentResult> InvokeAsync(int machuandaura)
        { 

            var chuandaura = await _context.Chuandaura_Monhocs.FindAsync(machuandaura);
     
            return View(chuandaura);
        }
    }
}