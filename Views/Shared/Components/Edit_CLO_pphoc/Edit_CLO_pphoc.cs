using System.Net.WebSockets;
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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_CLO_pphoc
{
    public class Edit_CLO_pphoc : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_CLO_pphoc(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

         public async Task<IViewComponentResult> InvokeAsync(int maclopphoc)
        { 
            var clpo = await _context.CLOPhuongphaphocs.FindAsync(maclopphoc);
            return View(clpo);
        }
    }
}