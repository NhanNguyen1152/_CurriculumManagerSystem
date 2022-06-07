using System.Text.RegularExpressions;
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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Tailieuthamkhao
{
    //[ViewComponent]
    public class Pdf_Tailieuthamkhao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Tailieuthamkhao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {      
           var result = await _context.DecuongTailieus.Include(m => m.DeCuongchiTiet).Include(m=> m.Tailieu).Where(m => m.DeCuongchiTiet.mahp == id).ToListAsync();
                 
                     return View<List<DecuongTailieu>>(result);

        }
    }
}