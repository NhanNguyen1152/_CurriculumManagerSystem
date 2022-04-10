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
    public class TailieusController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public TailieusController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Tailieus
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tailieus.ToListAsync());
        }

        // GET: Tailieus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tailieu = await _context.Tailieus
                .FirstOrDefaultAsync(m => m.matl == id);
            if (tailieu == null)
            {
                return NotFound();
            }

            return View(tailieu);
        }

        // GET: Tailieus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tailieus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("matl,tacgia,tentailieu,thongtinkhac,loaitl")] Tailieu tailieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tailieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tailieu);
        }

        // GET: Tailieus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tailieu = await _context.Tailieus.FindAsync(id);
            if (tailieu == null)
            {
                return NotFound();
            }
            return View(tailieu);
        }

        // POST: Tailieus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("matl,tacgia,tentailieu,thongtinkhac,loaitl")] Tailieu tailieu)
        {
            if (id != tailieu.matl)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tailieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TailieuExists(tailieu.matl))
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
            return View(tailieu);
        }

        // GET: Tailieus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tailieu = await _context.Tailieus
                .FirstOrDefaultAsync(m => m.matl == id);
            if (tailieu == null)
            {
                return NotFound();
            }

            return View(tailieu);
        }

        // POST: Tailieus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tailieu = await _context.Tailieus.FindAsync(id);
            _context.Tailieus.Remove(tailieu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TailieuExists(int id)
        {
            return _context.Tailieus.Any(e => e.matl == id);
        }
    }
}
