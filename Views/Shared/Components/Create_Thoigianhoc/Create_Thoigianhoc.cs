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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_Thoigianhoc
{
    public class Create_Thoigianhoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_Thoigianhoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int mathoigianhoc)
        { 
            var thoigianhoc = await _context.Thoigianhocs.FindAsync(mathoigianhoc);
            return View(thoigianhoc);
        }
    }
}