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

namespace _CurriculumManagerSystem.Views.Shared.Components.Create_CLO_ppday
{
    public class Create_CLO_ppday : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Create_CLO_ppday(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? id)
        { 
            if (id == null)
            {                     
                return View();
            }

            var clpo = await _context.CLOPhuongphapdays.FindAsync(id);
            if (clpo == null)
            {
                return View();
            }
            return View(clpo);
        }
    }
}