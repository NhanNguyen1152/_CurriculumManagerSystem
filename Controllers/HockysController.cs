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
    public class HockysController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public HockysController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Hockys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hockys.ToListAsync());
        }

        // GET: Hockys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocky = await _context.Hockys
                .FirstOrDefaultAsync(m => m.mahk == id);
            if (hocky == null)
            {
                return NotFound();
            }

            return View(hocky);
        }

        // GET: Hockys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hockys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mahk,tenhk")] Hocky hocky)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hocky);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hocky);
        }

        // GET: Hockys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocky = await _context.Hockys.FindAsync(id);
            if (hocky == null)
            {
                return NotFound();
            }
            return View(hocky);
        }

        // POST: Hockys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mahk,tenhk")] Hocky hocky)
        {
            if (id != hocky.mahk)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hocky);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HockyExists(hocky.mahk))
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
            return View(hocky);
        }

        // GET: Hockys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hocky = await _context.Hockys
                .FirstOrDefaultAsync(m => m.mahk == id);
            if (hocky == null)
            {
                return NotFound();
            }

            return View(hocky);
        }

        // POST: Hockys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hocky = await _context.Hockys.FindAsync(id);
            _context.Hockys.Remove(hocky);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HockyExists(int id)
        {
            return _context.Hockys.Any(e => e.mahk == id);
        }
    }
}
