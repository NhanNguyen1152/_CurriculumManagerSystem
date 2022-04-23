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
    public class KhoikienthucsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public KhoikienthucsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Khoikienthucs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Khoikienthucs.ToListAsync());
        }

        // GET: Khoikienthucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoikienthuc = await _context.Khoikienthucs
                .FirstOrDefaultAsync(m => m.makkt == id);
            if (khoikienthuc == null)
            {
                return NotFound();
            }

            return View(khoikienthuc);
        }

        // GET: Khoikienthucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Khoikienthucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("makkt,kkt_ten,kkt_mota")] Khoikienthuc khoikienthuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoikienthuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(khoikienthuc);
        }

        // GET: Khoikienthucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoikienthuc = await _context.Khoikienthucs.FindAsync(id);
            if (khoikienthuc == null)
            {
                return NotFound();
            }
            return View(khoikienthuc);
        }

        // POST: Khoikienthucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("makkt,kkt_ten,kkt_mota")] Khoikienthuc khoikienthuc)
        {
            if (id != khoikienthuc.makkt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoikienthuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoikienthucExists(khoikienthuc.makkt))
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
            return View(khoikienthuc);
        }

        // GET: Khoikienthucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoikienthuc = await _context.Khoikienthucs
                .FirstOrDefaultAsync(m => m.makkt == id);
            if (khoikienthuc == null)
            {
                return NotFound();
            }

            return View(khoikienthuc);
        }

        // POST: Khoikienthucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var khoikienthuc = await _context.Khoikienthucs.FindAsync(id);
            _context.Khoikienthucs.Remove(khoikienthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoikienthucExists(int id)
        {
            return _context.Khoikienthucs.Any(e => e.makkt == id);
        }
    }
}
