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
    public class Decuong_ChuongtrinhsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Decuong_ChuongtrinhsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Decuong_Chuongtrinhs
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.Decuong_Chuongtrinhs.Include(d => d.Chuongtrinh_Daotao).Include(d => d.DeCuongchiTiet);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: Decuong_Chuongtrinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuong_Chuongtrinh = await _context.Decuong_Chuongtrinhs
                .Include(d => d.Chuongtrinh_Daotao)
                .Include(d => d.DeCuongchiTiet)
                .FirstOrDefaultAsync(m => m.ma_dc_ct == id);
            if (decuong_Chuongtrinh == null)
            {
                return NotFound();
            }

            return View(decuong_Chuongtrinh);
        }

        // GET: Decuong_Chuongtrinhs/Create
        public IActionResult Create()
        {
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt");
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp_decuong");
            return View();
        }

        // POST: Decuong_Chuongtrinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_dc_ct,mahp,ma_ctdt")] Decuong_Chuongtrinh decuong_Chuongtrinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(decuong_Chuongtrinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Chuongtrinh.ma_ctdt);
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp_decuong", decuong_Chuongtrinh.mahp);
            return View(decuong_Chuongtrinh);
        }

        // GET: Decuong_Chuongtrinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuong_Chuongtrinh = await _context.Decuong_Chuongtrinhs.FindAsync(id);
            if (decuong_Chuongtrinh == null)
            {
                return NotFound();
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Chuongtrinh.ma_ctdt);
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp_decuong", decuong_Chuongtrinh.mahp);
            return View(decuong_Chuongtrinh);
        }

        // POST: Decuong_Chuongtrinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_dc_ct,mahp,ma_ctdt")] Decuong_Chuongtrinh decuong_Chuongtrinh)
        {
            if (id != decuong_Chuongtrinh.ma_dc_ct)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(decuong_Chuongtrinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Decuong_ChuongtrinhExists(decuong_Chuongtrinh.ma_dc_ct))
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
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Chuongtrinh.ma_ctdt);
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp_decuong", decuong_Chuongtrinh.mahp);
            return View(decuong_Chuongtrinh);
        }

        // GET: Decuong_Chuongtrinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuong_Chuongtrinh = await _context.Decuong_Chuongtrinhs
                .Include(d => d.Chuongtrinh_Daotao)
                .Include(d => d.DeCuongchiTiet)
                .FirstOrDefaultAsync(m => m.ma_dc_ct == id);
            if (decuong_Chuongtrinh == null)
            {
                return NotFound();
            }

            return View(decuong_Chuongtrinh);
        }

        // POST: Decuong_Chuongtrinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var decuong_Chuongtrinh = await _context.Decuong_Chuongtrinhs.FindAsync(id);
            _context.Decuong_Chuongtrinhs.Remove(decuong_Chuongtrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Decuong_ChuongtrinhExists(int id)
        {
            return _context.Decuong_Chuongtrinhs.Any(e => e.ma_dc_ct == id);
        }
    }
}
