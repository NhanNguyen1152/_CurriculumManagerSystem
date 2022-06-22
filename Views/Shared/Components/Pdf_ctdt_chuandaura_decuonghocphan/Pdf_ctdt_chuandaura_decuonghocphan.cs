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


namespace _CurriculumManagerSystem.Views.Shared.Components.Pdf_ctdt_chuandaura_decuonghocphan
{
    public class Pdf_ctdt_chuandaura_decuonghocphan : ViewComponent
    {
        private readonly acomptec_lvthainhanContext _context;

        public Pdf_ctdt_chuandaura_decuonghocphan(acomptec_lvthainhanContext context)
        {
            _context = context;
        }
       
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {   
            var listplo = _context.PLOs;
            ViewBag.listplo = listplo.ToList();
            
            var listClpo = _context.CLPOs.Include(c => c.Chuandaura_monhoc).ThenInclude(c => c.DeCuongchiTiet).Include(c => c.PLO);
             ViewBag.listClpo = listClpo.ToList();

             var listmuctieudaotao = _context.Muctieu_Daotaos;
            ViewBag.listmuctieudaotao = listmuctieudaotao.ToList();

            var listchuandaura = _context.Chuandaura_Monhocs.Include(c => c.DeCuongchiTiet);
             ViewBag.listchuandaura = listchuandaura.ToList();

            // var listClpo = _context.CLPOs.Include(c => c.Chuandaura_monhoc).ThenInclude(c => c.DeCuongchiTiet).Include(c => c.PLO).ToListAsync();
            // ViewBag.listClpo = listClpo.ToList();

            var result = await _context.Decuong_Chuongtrinhs.Include(m => m.DeCuongchiTiet).Include(m=> m.Chuongtrinh_Daotao).Where(m => m.Chuongtrinh_Daotao.ma_ctdt ==id).ToListAsync();
            return View<List<Decuong_Chuongtrinh>>(result);
        }
    }
}