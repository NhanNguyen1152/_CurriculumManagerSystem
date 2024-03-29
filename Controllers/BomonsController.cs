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
    public class BomonsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public BomonsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Bomons
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.Bomons.Include(b => b.Khoa);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: Bomons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bomon = await _context.Bomons
                .Include(b => b.Khoa)
                .FirstOrDefaultAsync(m => m.mabm == id);
            if (bomon == null)
            {
                return NotFound();
            }

            return View(bomon);
        }

        // GET: Bomons/Create
        public IActionResult Create()
        {
            ViewData["makh"] = new SelectList(_context.Khoas, "makh", "tenkh");
            return View();
        }

        // POST: Bomons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mabm,tenbm,makh")] Bomon bomon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bomon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["makh"] = new SelectList(_context.Khoas, "makh", "makh", bomon.makh);
            return View(bomon);
        }

        // GET: Bomons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bomon = await _context.Bomons.FindAsync(id);
            if (bomon == null)
            {
                return NotFound();
            }
            ViewData["makh"] = new SelectList(_context.Khoas, "makh", "makh", bomon.makh);
            return View(bomon);
        }

        // POST: Bomons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mabm,tenbm,makh")] Bomon bomon)
        {
            if (id != bomon.mabm)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bomon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BomonExists(bomon.mabm))
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
            ViewData["makh"] = new SelectList(_context.Khoas, "makh", "makh", bomon.makh);
            return View(bomon);
        }

        // GET: Bomons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bomon = await _context.Bomons
                .Include(b => b.Khoa)
                .FirstOrDefaultAsync(m => m.mabm == id);
            if (bomon == null)
            {
                return NotFound();
            }

            return View(bomon);
        }

        // POST: Bomons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bomon = await _context.Bomons.FindAsync(id);
            _context.Bomons.Remove(bomon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BomonExists(int id)
        {
            return _context.Bomons.Any(e => e.mabm == id);
        }
    }
}
