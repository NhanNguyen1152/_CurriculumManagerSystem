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



namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_quydinh
{
    public class Pdf_ctdt_quydinh : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_quydinh(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
       
        public IViewComponentResult Invoke()
        {   
            var result = _context.Quydinh_Kiemtras.ToList();
            return View(result);
        }
    }
}                                                                                                                              
