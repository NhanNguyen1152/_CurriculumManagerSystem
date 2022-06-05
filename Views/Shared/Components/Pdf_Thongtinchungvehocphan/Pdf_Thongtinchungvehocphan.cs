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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_Thongtinchungvehocphan
{
    //[ViewComponent]
    public class Pdf_Thongtinchungvehocphan : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_Thongtinchungvehocphan(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var result = await _context.DeCuongchiTiets.Include(m => m.Thoigianhocs).ThenInclude(m => m.Hockys).Include(m => m.Khoikienthuc).Where(m=> m.mahp == id).ToListAsync();
            return View<List<DeCuongchiTiet>>(result);
        }
    }

}