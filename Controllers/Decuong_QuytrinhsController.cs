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
    public class Decuong_QuytrinhsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Decuong_QuytrinhsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Decuong_Quytrinhs
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.Decuong_Quytrinhs.Include(d => d.Chuongtrinh_Daotao).Include(d => d.Quytrinhdaotao_Dieukientotnghiep);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: Decuong_Quytrinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuong_Quytrinh = await _context.Decuong_Quytrinhs
                .Include(d => d.Chuongtrinh_Daotao)
                .Include(d => d.Quytrinhdaotao_Dieukientotnghiep)
                .FirstOrDefaultAsync(m => m.dcht_id == id);
            if (decuong_Quytrinh == null)
            {
                return NotFound();
            }

            return View(decuong_Quytrinh);
        }

        // GET: Decuong_Quytrinhs/Create
        public IActionResult Create()
        {
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt");
            ViewData["ma_qt_dktn"] = new SelectList(_context.Quytrinhdaotao_Dieukientotnghieps, "ma_qt_dktn", "ma_qt_dktn");
            return View();
        }

        // POST: Decuong_Quytrinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("dcht_id,ma_ctdt,ma_qt_dktn")] Decuong_Quytrinh decuong_Quytrinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(decuong_Quytrinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Quytrinh.ma_ctdt);
            ViewData["ma_qt_dktn"] = new SelectList(_context.Quytrinhdaotao_Dieukientotnghieps, "ma_qt_dktn", "ma_qt_dktn", decuong_Quytrinh.ma_qt_dktn);
            return View(decuong_Quytrinh);
        }

        // GET: Decuong_Quytrinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuong_Quytrinh = await _context.Decuong_Quytrinhs.FindAsync(id);
            if (decuong_Quytrinh == null)
            {
                return NotFound();
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Quytrinh.ma_ctdt);
            ViewData["ma_qt_dktn"] = new SelectList(_context.Quytrinhdaotao_Dieukientotnghieps, "ma_qt_dktn", "ma_qt_dktn", decuong_Quytrinh.ma_qt_dktn);
            return View(decuong_Quytrinh);
        }

        // POST: Decuong_Quytrinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("dcht_id,ma_ctdt,ma_qt_dktn")] Decuong_Quytrinh decuong_Quytrinh)
        {
            if (id != decuong_Quytrinh.dcht_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(decuong_Quytrinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Decuong_QuytrinhExists(decuong_Quytrinh.dcht_id))
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
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", decuong_Quytrinh.ma_ctdt);
            ViewData["ma_qt_dktn"] = new SelectList(_context.Quytrinhdaotao_Dieukientotnghieps, "ma_qt_dktn", "ma_qt_dktn", decuong_Quytrinh.ma_qt_dktn);
            return View(decuong_Quytrinh);
        }

        // GET: Decuong_Quytrinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuong_Quytrinh = await _context.Decuong_Quytrinhs
                .Include(d => d.Chuongtrinh_Daotao)
                .Include(d => d.Quytrinhdaotao_Dieukientotnghiep)
                .FirstOrDefaultAsync(m => m.dcht_id == id);
            if (decuong_Quytrinh == null)
            {
                return NotFound();
            }

            return View(decuong_Quytrinh);
        }

        // POST: Decuong_Quytrinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var decuong_Quytrinh = await _context.Decuong_Quytrinhs.FindAsync(id);
            _context.Decuong_Quytrinhs.Remove(decuong_Quytrinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Decuong_QuytrinhExists(int id)
        {
            return _context.Decuong_Quytrinhs.Any(e => e.dcht_id == id);
        }
    }
}
