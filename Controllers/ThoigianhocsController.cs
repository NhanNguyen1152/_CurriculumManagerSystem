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
    public class ThoigianhocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public ThoigianhocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Thoigianhocs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Thoigianhocs.ToListAsync());
        }

        // GET: Thoigianhocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thoigianhoc = await _context.Thoigianhocs
                .FirstOrDefaultAsync(m => m.matg == id);
            if (thoigianhoc == null)
            {
                return NotFound();
            }

            return View(thoigianhoc);
        }

        // GET: Thoigianhocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Thoigianhocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thoigianhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thoigianhoc);
        }

        // GET: Thoigianhocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            if (thoigianhoc == null)
            {
                return NotFound();
            }
            return View(thoigianhoc);
        }

        // POST: Thoigianhocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
        {
            if (id != thoigianhoc.matg)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thoigianhoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThoigianhocExists(thoigianhoc.matg))
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
            return View(thoigianhoc);
        }

        // GET: Thoigianhocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thoigianhoc = await _context.Thoigianhocs
                .FirstOrDefaultAsync(m => m.matg == id);
            if (thoigianhoc == null)
            {
                return NotFound();
            }

            return View(thoigianhoc);
        }

        // POST: Thoigianhocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            _context.Thoigianhocs.Remove(thoigianhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThoigianhocExists(int id)
        {
            return _context.Thoigianhocs.Any(e => e.matg == id);
        }
    }
}
