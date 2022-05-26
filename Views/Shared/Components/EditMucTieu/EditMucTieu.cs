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

namespace _CurriculumManagerSystem.Views.Shared.Components.EditMucTieu
{
    public class EditMucTieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public EditMucTieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // [Route("DeCuongchiTiets/Create/{id:int}")]
        public async Task<IViewComponentResult> InvokeAsync(int? id)
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
            return View(muctieu);
        }
    }
}