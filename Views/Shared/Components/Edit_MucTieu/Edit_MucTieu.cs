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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_MucTieu
{
    public class Edit_MucTieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_MucTieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // [Route("DeCuongchiTiets/Create/{id:int}")]
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
           
            HttpContext.Session.SetInt32("id_edit_mt", id );
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