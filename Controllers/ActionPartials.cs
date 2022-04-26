using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;

namespace _CurriculumManagerSystem.Controllers
{
    public class ActionPartials : Controller
    {
        public  IActionResult Index()
        {
            return View();
        }
        
        public ActionResult _Partial_decuongchitiet()
        {
            return PartialView("_Partial_decuongchitiet");
        }

        public ActionResult _Partial_muctieu()
        {
            return PartialView("_Partial_muctieu");
        }
    }
}