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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Decuongchitiet
{
    public class Edit_Decuongchitiet : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Decuongchitiet(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            HttpContext.Session.SetInt32("id_edit_dccht_after", id );
            TempData["id_dc_after"] = id;
            
            if (id == null)
            {
                return View();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets.FindAsync(id);
            if (deCuongchiTiet == null)
            {
                 return View();
            }
            return View(deCuongchiTiet);
        }
    }
}