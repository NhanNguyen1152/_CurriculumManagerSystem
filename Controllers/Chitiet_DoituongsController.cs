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
    public class Chitiet_DoituongsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Chitiet_DoituongsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Chitiet_Doituongs
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.Chitiet_Doituongs.Include(c => c.Chuongtrinh_Daotao).Include(c => c.Doituong_Tuyensinh);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: Chitiet_Doituongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiet_Doituong = await _context.Chitiet_Doituongs
                .Include(c => c.Chuongtrinh_Daotao)
                .Include(c => c.Doituong_Tuyensinh)
                .FirstOrDefaultAsync(m => m.ma_ct_dt == id);
            if (chitiet_Doituong == null)
            {
                return NotFound();
            }

            return View(chitiet_Doituong);
        }

        // GET: Chitiet_Doituongs/Create
        public IActionResult Create()
        {
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt");
            ViewData["ma_dtts"] = new SelectList(_context.Doituong_Tuyensinhs, "ma_dtts", "ma_dtts");
            return View();
        }

        // POST: Chitiet_Doituongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_ct_dt,ma_ctdt,ma_dtts")] Chitiet_Doituong chitiet_Doituong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitiet_Doituong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chitiet_Doituong);
        }

        // GET: Chitiet_Doituongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiet_Doituong = await _context.Chitiet_Doituongs.FindAsync(id);
            if (chitiet_Doituong == null)
            {
                return NotFound();
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", chitiet_Doituong.ma_ctdt);
            ViewData["ma_dtts"] = new SelectList(_context.Doituong_Tuyensinhs, "ma_dtts", "ma_dtts", chitiet_Doituong.ma_dtts);
            return View(chitiet_Doituong);
        }

        // POST: Chitiet_Doituongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_ct_dt,ma_ctdt,ma_dtts")] Chitiet_Doituong chitiet_Doituong)
        {
            if (id != chitiet_Doituong.ma_ct_dt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitiet_Doituong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Chitiet_DoituongExists(chitiet_Doituong.ma_ct_dt))
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
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", chitiet_Doituong.ma_ctdt);
            ViewData["ma_dtts"] = new SelectList(_context.Doituong_Tuyensinhs, "ma_dtts", "ma_dtts", chitiet_Doituong.ma_dtts);
            return View(chitiet_Doituong);
        }

        // GET: Chitiet_Doituongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiet_Doituong = await _context.Chitiet_Doituongs
                .Include(c => c.Chuongtrinh_Daotao)
                .Include(c => c.Doituong_Tuyensinh)
                .FirstOrDefaultAsync(m => m.ma_ct_dt == id);
            if (chitiet_Doituong == null)
            {
                return NotFound();
            }

            return View(chitiet_Doituong);
        }

        // POST: Chitiet_Doituongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chitiet_Doituong = await _context.Chitiet_Doituongs.FindAsync(id);
            _context.Chitiet_Doituongs.Remove(chitiet_Doituong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Chitiet_DoituongExists(int id)
        {
            return _context.Chitiet_Doituongs.Any(e => e.ma_ct_dt == id);
        }
    }
}
