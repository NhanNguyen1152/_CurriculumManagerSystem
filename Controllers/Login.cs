using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Data;  

namespace _CurriculumManagerSystem.Controllers
{
    public class Login : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Login(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HttpContext.Session.SetString("userName", "null");
            return View();
        }

        [HttpPost]
        public ActionResult verifyLogin(int magiangvien, string matkhau)
        {
            var user_Details = _context.GiangViens.Where( x => x.maso_giangvien == magiangvien && x.matkhau == matkhau).FirstOrDefault();
            if(user_Details == null)
            {
                    ViewBag.error = "Invalid Account";
                    return View("Index");
            }
            else
            {
                HttpContext.Session.SetString("userName", user_Details.hoten);
                HttpContext.Session.SetInt32("userID", user_Details.maso_giangvien);
                HttpContext.Session.SetString("role", user_Details.vaitro);
                return RedirectToAction("Index","Home");
            }
        }


        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("userName");
            HttpContext.Session.Remove("userID");
            HttpContext.Session.Remove("role");
            return RedirectToAction("Index", "Login");
        }        
    }
}