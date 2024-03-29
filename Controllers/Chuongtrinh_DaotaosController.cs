using System.Runtime.Intrinsics.X86;
using System.Net.Cache;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Net.Http;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace _CurriculumManagerSystem.Controllers
{
    public class Chuongtrinh_DaotaosController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Chuongtrinh_DaotaosController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Chuongtrinh_Daotaos
        public async Task<IActionResult> Index()
        {
            //HttpContext.Session.Clear();
            return View(await _context.Chuongtrinh_Daotaos.ToListAsync());
        }

        // GET: Chuongtrinh_Daotaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos
                .FirstOrDefaultAsync(m => m.ma_ctdt == id);
            if (chuongtrinh_Daotao == null)
            {
                return NotFound();
            }

            return View(chuongtrinh_Daotao);
        }

        // GET: Chuongtrinh_Daotaos/Create
        public IActionResult Create(int moiquanhe_plo_mt)
        {
            HttpContext.Session.SetInt32("Mamoiquanhe_plo_mt",moiquanhe_plo_mt);
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            ViewData["ma_mtdt"] = new SelectList(_context.CTDT_Muctieudaotaos.Include(m=> m.Muctieu_Daotao).Where(m=> m.ma_ctdt ==  HttpContext.Session.GetInt32("id_ctdt_ss_create")), "ma_mtdt", "Muctieu_Daotao.mtdt_chiso");
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "chisoplo");
            ViewData["ma_dtts"] = new SelectList(_context.Doituong_Tuyensinhs, "ma_dtts", "noi_dung_dtts");

            return View();
        }

        // POST: Chuongtrinh_Daotaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_ctdt,nganh_daotao,trinhdo_daotao,loaihinh_daotao,thoigian_daotao,tenvanbang,noidaotao,maso_ctdt,noidung_ctdt,khoahoc_apdung,manguoitao,thoigiantao")] Chuongtrinh_Daotao chuongtrinh_Daotao)
        {
            if (ModelState.IsValid)
            {
                chuongtrinh_Daotao.thoigiantao = DateTime.Today;
                _context.Add(chuongtrinh_Daotao);
                await _context.SaveChangesAsync();
                HttpContext.Session.SetInt32("id_ctdt_ss_create", chuongtrinh_Daotao.ma_ctdt);
                HttpContext.Session.SetString("Name_ctdt", chuongtrinh_Daotao.nganh_daotao);
                TempData["id_ctdt_tmp_create"] = chuongtrinh_Daotao.ma_ctdt;
                return RedirectToAction("Create"); 
            }
            return View(chuongtrinh_Daotao);
        }

        // GET: Chuongtrinh_Daotaos/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            HttpContext.Session.SetInt32("id_edit_ctdt", id );
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            ViewData["ma_mtdt"] = new SelectList(_context.CTDT_Muctieudaotaos.Include(m=> m.Muctieu_Daotao).Where(m=> m.ma_ctdt ==  HttpContext.Session.GetInt32("id_edit_ctdt_after")), "ma_mtdt", "Muctieu_Daotao.mtdt_chiso");
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "chisoplo");
            ViewData["ma_dtts"] = new SelectList(_context.Doituong_Tuyensinhs, "ma_dtts", "noi_dung_dtts");
            return View();
        }

        // POST: Chuongtrinh_Daotaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_ctdt,nganh_daotao,trinhdo_daotao,loaihinh_daotao,thoigian_daotao,tenvanbang,noidaotao,maso_ctdt,noidung_ctdt,khoahoc_apdung,manguoitao,thoigiantao")] Chuongtrinh_Daotao chuongtrinh_Daotao)
        {
            if (id != chuongtrinh_Daotao.ma_ctdt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuongtrinh_Daotao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Chuongtrinh_DaotaoExists(chuongtrinh_Daotao.ma_ctdt))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(chuongtrinh_Daotao);
        }

        // GET: Chuongtrinh_Daotaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos
                .FirstOrDefaultAsync(m => m.ma_ctdt == id);
            if (chuongtrinh_Daotao == null)
            {
                return NotFound();
            }

            return View(chuongtrinh_Daotao);
        }

        // POST: Chuongtrinh_Daotaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos.FindAsync(id);
            _context.Chuongtrinh_Daotaos.Remove(chuongtrinh_Daotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Chuongtrinh_DaotaoExists(int id)
        {
            return _context.Chuongtrinh_Daotaos.Any(e => e.ma_ctdt == id);
        }
        // //Create-decuong-chuongtrinh
        // public async Task<IActionResult> CreateDecuongChuongtrinh([Bind("ma_dc_ct,mahp,ma_ctdt")] Decuong_Chuongtrinh decuong_Chuongtrinh)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         decuong_Chuongtrinh.ma_ctdt = (int)TempData["id_ctdt_tmp_create"];
        //         _context.Add(decuong_Chuongtrinh);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction("Create");
        //     }
        //     // ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Chuongtrinh.ma_ctdt);
        //     // ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp_decuong", decuong_Chuongtrinh.mahp);
        //     return View();
        // }
        //Create-decuong-chuongtrinh
        public async Task<IActionResult> CreateDecuongChuongtrinh([Bind("ma_dc_ct,mahp,ma_ctdt")] Decuong_Chuongtrinh decuong_Chuongtrinh)
        {
            if (ModelState.IsValid)
            {
                decuong_Chuongtrinh.ma_ctdt = (int)TempData["id_ctdt_tmp_create"];
                _context.Add(decuong_Chuongtrinh);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            // ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Chuongtrinh.ma_ctdt);
            // ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp_decuong", decuong_Chuongtrinh.mahp);
            return View();
        }
        public async Task<IActionResult> EditDecuongChuongtrinh([Bind("ma_dc_ct,mahp,ma_ctdt")] Decuong_Chuongtrinh decuong_Chuongtrinh)
        {
            if (ModelState.IsValid)
            {
                decuong_Chuongtrinh.ma_ctdt = (int)TempData["id_edit_ctdt_after"];
                _context.Add(decuong_Chuongtrinh);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit");
            }
            return View();
        }
        public async Task<IActionResult> DeleteCTDT_decuong(int id)
        {
            var decuong_Chuongtrinh = await _context.Decuong_Chuongtrinhs.FindAsync(id);
            _context.Decuong_Chuongtrinhs.Remove(decuong_Chuongtrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteCTDT_decuong_edit(int id)
        {
            var decuong_Chuongtrinh = await _context.Decuong_Chuongtrinhs.FindAsync(id);
            _context.Decuong_Chuongtrinhs.Remove(decuong_Chuongtrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }
        
         public async Task<IActionResult> createListQT(int[] arrayDCQT)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCQT)
                {
                    
                    var DCQT = new Decuong_Quytrinh();
                    DCQT.ma_ctdt = (int)TempData["id_ctdt_tmp_create"];
                    DCQT.ma_qt_dktn = item; 
                    _context.Add(DCQT); 
                    await _context.SaveChangesAsync();
                }
                
                    return RedirectToAction("Create");  
            }
            return View();
        }
         public async Task<IActionResult> EditListQT(int[] arrayDCQT)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCQT)
                {
                    
                    var DCQT = new Decuong_Quytrinh();
                    DCQT.ma_ctdt = (int)TempData["id_edit_ctdt_after"];
                    DCQT.ma_qt_dktn = item; 
                    _context.Add(DCQT); 
                    await _context.SaveChangesAsync();
                }
                
                    return RedirectToAction("Edit");  
            }
            return View();
        }
        public async Task<IActionResult> DeleteCTDT_quydinh(int id)
        {
            var decuong_Quytrinh = await _context.Decuong_Quytrinhs.FindAsync(id);
            _context.Decuong_Quytrinhs.Remove(decuong_Quytrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteCTDT_quydinh_edit(int id)
        {
            var decuong_Quytrinh = await _context.Decuong_Quytrinhs.FindAsync(id);
            _context.Decuong_Quytrinhs.Remove(decuong_Quytrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }

        public async Task<IActionResult> DeleteCTDT_muctieu(int id)
        {
            var cTDT_Muctieudaotao = await _context.CTDT_Muctieudaotaos.FindAsync(id);
            _context.CTDT_Muctieudaotaos.Remove(cTDT_Muctieudaotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteCTDT_muctieu_edit(int id)
        {
            var cTDT_Muctieudaotao = await _context.CTDT_Muctieudaotaos.FindAsync(id);
            _context.CTDT_Muctieudaotaos.Remove(cTDT_Muctieudaotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }
        //CreatePLO-Muctieudaotao
        public async Task<IActionResult> CreatePLO_Muctieudaotao([Bind("ma_plo_mtdt,ngay_update,maplo,ma_mtdt")] MoiquanhePLO_Muctieudaotao moiquanhePLO_Muctieudaotao)
        {
            if (ModelState.IsValid)
            {   
                _context.Add(moiquanhePLO_Muctieudaotao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View();
        }
        public async Task<IActionResult> EditPLO_Muctieudaotao([Bind("ma_plo_mtdt,ngay_update,maplo,ma_mtdt")] MoiquanhePLO_Muctieudaotao moiquanhePLO_Muctieudaotao)
        {
            if (ModelState.IsValid)
            {   
                _context.Add(moiquanhePLO_Muctieudaotao);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit");
            }
            return View();
        }
        //delete
        public async Task<IActionResult> DeleteCTDT_moiquanhe(int id)
        {
            var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos.FindAsync(id);
            _context.MoiquanhePLO_Muctieudaotaos.Remove(moiquanhePLO_Muctieudaotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteCTDT_moiquanhe_edit(int id)
        {
            var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos.FindAsync(id);
            _context.MoiquanhePLO_Muctieudaotaos.Remove(moiquanhePLO_Muctieudaotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }
        //createListMT
         public async Task<IActionResult> createListMT(int[] arrayDCMT)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCMT)
                {
                    
                    var DCMT = new CTDT_Muctieudaotao();
                    DCMT.ma_ctdt = (int)TempData["id_ctdt_tmp_create"];
                    DCMT.ma_mtdt = item; 
                    _context.Add(DCMT); 
                    await _context.SaveChangesAsync();
                }
                
                    return RedirectToAction("Create");  
            }
            return View();
        }
        public async Task<IActionResult> EditListMT(int[] arrayDCMT)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCMT)
                {
                    
                    var DCMT = new CTDT_Muctieudaotao();
                    DCMT.ma_ctdt = (int)TempData["id_edit_ctdt_after"];
                    DCMT.ma_mtdt = item; 
                    _context.Add(DCMT); 
                    await _context.SaveChangesAsync();
                }
                
                    return RedirectToAction("Edit");  
            }
            return View();
        }
        //createdoituong
        public async Task<IActionResult> CreateListTS(int[] arrayTS)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayTS)
                {
                    
                    var TS = new Chitiet_Doituong();
                    TS.ma_ctdt = (int)TempData["id_ctdt_tmp_create"];
                    TS.ma_dtts = item; 
                    _context.Add(TS); 
                    await _context.SaveChangesAsync();
                }
                
                    return RedirectToAction("Create");  
            }
            return View();
        }
        public async Task<IActionResult> EditListTS(int[] arrayTS)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayTS)
                {
                    
                    var TS = new Chitiet_Doituong();
                    TS.ma_ctdt = (int)TempData["id_edit_ctdt_after"];
                    TS.ma_dtts = item; 
                    _context.Add(TS); 
                    await _context.SaveChangesAsync();
                }
                
                    return RedirectToAction("Edit");  
            }
            return View();
        }
        public async Task<IActionResult> DeleteCTDT_doituongtuyensinh(int id)
        {
            var doituong_Tuyensinh = await _context.Chitiet_Doituongs.FindAsync(id);
            _context.Chitiet_Doituongs.Remove(doituong_Tuyensinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteCTDT_doituongtuyensinh_edit(int id)
        {
            var doituong_Tuyensinh = await _context.Chitiet_Doituongs.FindAsync(id);
            _context.Chitiet_Doituongs.Remove(doituong_Tuyensinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }
    }
}
