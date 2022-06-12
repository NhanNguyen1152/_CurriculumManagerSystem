using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Lichtrinhgiangday
{
    public class Pdf_Lichtrinhgiangday : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Lichtrinhgiangday(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            //sualaithanhchitietchuong
            var result =
                _context
                    .Chitiet_Chuongs
                    .Include(m => m.Chitietmonhoc)
                    .ThenInclude(z => z.DeCuongchiTiet)
                    .Where(m => m.Chitietmonhoc.mahp == id);
            return View(await result.ToListAsync());
        }
    }
}
