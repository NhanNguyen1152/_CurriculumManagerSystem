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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Thoikhoabieu
{
    public class Pdf_Thoikhoabieu : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Thoikhoabieu(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var result = await _context.Decuong_Chuongtrinhs.Where(m=> m.ma_ctdt == id).ToListAsync();
            return View<List<Decuong_Chuongtrinh>>(result);
        }
    }
}