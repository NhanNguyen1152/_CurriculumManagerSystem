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
    public class KhoahocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public KhoahocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Khoahocs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Khoahocs.ToListAsync());
        }

        // GET: Khoahocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoahoc = await _context.Khoahocs
                .FirstOrDefaultAsync(m => m.makh == id);
            if (khoahoc == null)
            {
                return NotFound();
            }

            return View(khoahoc);
        }

        // GET: Khoahocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khoahocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("makh,tenkh,nienkhoa")] Khoahoc khoahoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoahoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khoahoc);
        }

        // GET: Khoahocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoahoc = await _context.Khoahocs.FindAsync(id);
            if (khoahoc == null)
            {
                return NotFound();
            }
            return View(khoahoc);
        }

        // POST: Khoahocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("makh,tenkh,nienkhoa")] Khoahoc khoahoc)
        {
            if (id != khoahoc.makh)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoahoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoahocExists(khoahoc.makh))
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
            return View(khoahoc);
        }

        // GET: Khoahocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoahoc = await _context.Khoahocs
                .FirstOrDefaultAsync(m => m.makh == id);
            if (khoahoc == null)
            {
                return NotFound();
            }

            return View(khoahoc);
        }

        // POST: Khoahocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khoahoc = await _context.Khoahocs.FindAsync(id);
            _context.Khoahocs.Remove(khoahoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoahocExists(int id)
        {
            return _context.Khoahocs.Any(e => e.makh == id);
        }
    }
}
