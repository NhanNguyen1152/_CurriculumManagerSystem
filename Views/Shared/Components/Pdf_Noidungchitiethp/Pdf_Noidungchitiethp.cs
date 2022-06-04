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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Noidungchitiethp
{
    //[ViewComponent]
    public class Pdf_Noidungchitiethp : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Noidungchitiethp(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            //sualaithanhchitietchuong
            var result = _context.Chitiet_Chuongs.Include(m => m.Chitietmonhoc).ThenInclude(z => z.DeCuongchiTiet).Where(m => m.Chitietmonhoc.mahp == id);
            return View(await result.ToListAsync());

        }
    }
}