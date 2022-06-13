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


namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_muctieudaotao
{
    public class Pdf_ctdt_muctieudaotao : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_muctieudaotao(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
       
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var result = await _context.CTDT_Muctieudaotaos.Include(m => m.Chuongtrinh_Daotao).Include(m => m.Muctieu_Daotao).Where(m=> m.ma_ctdt == id).ToListAsync();
            return View<List<CTDT_Muctieudaotao>>(result);
        }
    }
}