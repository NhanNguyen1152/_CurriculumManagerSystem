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
    public class DeCuongNhiemvusController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public DeCuongNhiemvusController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: DeCuongNhiemvus
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeCuongNhiemvus.ToListAsync());
        }

        // GET: DeCuongNhiemvus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongNhiemvu = await _context.DeCuongNhiemvus
                .FirstOrDefaultAsync(m => m.dcnv_id == id);
            if (deCuongNhiemvu == null)
            {
                return NotFound();
            }

            return View(deCuongNhiemvu);
        }

        // GET: DeCuongNhiemvus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeCuongNhiemvus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("dcnv_id")] DeCuongNhiemvu deCuongNhiemvu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongNhiemvu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deCuongNhiemvu);
        }

        // GET: DeCuongNhiemvus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongNhiemvu = await _context.DeCuongNhiemvus.FindAsync(id);
            if (deCuongNhiemvu == null)
            {
                return NotFound();
            }
            return View(deCuongNhiemvu);
        }

        // POST: DeCuongNhiemvus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("dcnv_id")] DeCuongNhiemvu deCuongNhiemvu)
        {
            if (id != deCuongNhiemvu.dcnv_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deCuongNhiemvu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeCuongNhiemvuExists(deCuongNhiemvu.dcnv_id))
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
            return View(deCuongNhiemvu);
        }

        // GET: DeCuongNhiemvus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongNhiemvu = await _context.DeCuongNhiemvus
                .FirstOrDefaultAsync(m => m.dcnv_id == id);
            if (deCuongNhiemvu == null)
            {
                return NotFound();
            }

            return View(deCuongNhiemvu);
        }

        // POST: DeCuongNhiemvus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deCuongNhiemvu = await _context.DeCuongNhiemvus.FindAsync(id);
            _context.DeCuongNhiemvus.Remove(deCuongNhiemvu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeCuongNhiemvuExists(int id)
        {
            return _context.DeCuongNhiemvus.Any(e => e.dcnv_id == id);
        }
    }
}
