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

namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_cachthucdanhgia
{
    public class Pdf_ctdt_cachthucdanhgia : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_cachthucdanhgia(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {   
            return View();
        }
    }
}