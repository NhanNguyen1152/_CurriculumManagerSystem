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

namespace _CurriculumManagerSystem.Views.Shared.Components.Get_CTDT_decuongquydinh
{
    //[ViewComponent]
    public class Get_CTDT_decuongquydinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Get_CTDT_decuongquydinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        
        // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
        public async Task<IViewComponentResult> InvokeAsync()
        {   
            if(ViewData["Title"] == "Create")
            {
                 var result = await _context.Decuong_Quytrinhs.Include(m=> m.Quytrinhdaotao_Dieukientotnghiep).Where(m => m.Chuongtrinh_Daotao.ma_ctdt == HttpContext.Session.GetInt32("id_ctdt_ss_create")).ToListAsync();
                 return View(result);
               
            }
            else
            {
                 var result = await _context.Decuong_Quytrinhs.Include(m => m.Quytrinhdaotao_Dieukientotnghiep).Where(m => m.Chuongtrinh_Daotao.ma_ctdt == HttpContext.Session.GetInt32("id_edit_ctdt_after")).ToListAsync();
                 return View(result);
            }
            
            return View();
        }
    }

}