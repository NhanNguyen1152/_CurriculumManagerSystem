// using System.Net;
// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Web;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.EntityFrameworkCore;
// using _CurriculumManagerSystem.Models;
// using Microsoft.AspNetCore.Http;

// namespace _CurriculumManagerSystem.Views.Shared.Components.NhiemvuSV
// {
//     //[ViewComponent]
//     public class NhiemvuSV : ViewComponent
//     {
//         private readonly acomptec_lvthainhanContext _context;

//         public NhiemvuSV(acomptec_lvthainhanContext context)
//         {
//             _context = context;
//         }

        
//         // [HttpGet, ActionName("getmt"), Route("DeCuongchiTiets/Create/{id:int}")]
       
//         public async Task<IViewComponentResult> InvokeAsync([Bind("manv,noidung")] NhiemvuSV nhiemvuSV)
//         {   
//             if (ModelState.IsValid)
//             {
//                 _context.Add(nhiemvuSV);
//                 await _context.SaveChangesAsync();
//                 return RedirectToAction(nameof(Index));
//             }
//             return View(nhiemvuSV);
//         }
//     }

// }