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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_DcTailieu
{
    public class Edit_DcTailieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_DcTailieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }


     public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            if (id == null)
            {                     
                return View();
            }

            var muctieu = await _context.Muctieus.FindAsync(id);
            if (muctieu == null)
            {
                return View();
            }
            return View();
        }
    }
}