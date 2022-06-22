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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_CLPO
{
    public class Edit_CLPO : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_CLPO(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

       
        public async Task<IViewComponentResult> InvokeAsync(int maclpo)
        { 
            var clpo = await _context.CLPOs.FindAsync(maclpo);
            return View(clpo);
        }
    }
}