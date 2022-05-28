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

namespace _CurriculumManagerSystem.Views.Shared.Components.Edit_Chitietchuong
{
    public class Edit_Chitietchuong : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Edit_Chitietchuong(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        { 
            HttpContext.Session.SetInt32("id_edit_Chitietchuong", id);
            if (id == null)
            {                     
                return View();
            }

            var chitietchuong = await _context.Chitiet_Chuongs.FindAsync(id);
            if (chitietchuong == null)
            {
                return View();
            }
            return View(chitietchuong);
        }
    }
}