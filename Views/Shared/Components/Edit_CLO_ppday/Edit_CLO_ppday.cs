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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_CLO_ppday
{
    public class Edit_CLO_ppday : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_CLO_ppday(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int macloppday)
        { 
            var clpo = await _context.CLOPhuongphapdays.FindAsync(macloppday);
            return View(clpo);
        }
    }
}