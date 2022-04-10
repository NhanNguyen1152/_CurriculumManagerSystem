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
    public class Phuongphap_hocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Phuongphap_hocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Phuongphap_hocs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Phuongphap_Hocs.ToListAsync());
        }

        // GET: Phuongphap_hocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phuongphap_hoc = await _context.Phuongphap_Hocs
                .FirstOrDefaultAsync(m => m.mapphoc == id);
            if (phuongphap_hoc == null)
            {
                return NotFound();
            }

            return View(phuongphap_hoc);
        }

        // GET: Phuongphap_hocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phuongphap_hocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mapphoc,tenpp")] Phuongphap_hoc phuongphap_hoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phuongphap_hoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phuongphap_hoc);
        }

        // GET: Phuongphap_hocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phuongphap_hoc = await _context.Phuongphap_Hocs.FindAsync(id);
            if (phuongphap_hoc == null)
            {
                return NotFound();
            }
            return View(phuongphap_hoc);
        }

        // POST: Phuongphap_hocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mapphoc,tenpp")] Phuongphap_hoc phuongphap_hoc)
        {
            if (id != phuongphap_hoc.mapphoc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phuongphap_hoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Phuongphap_hocExists(phuongphap_hoc.mapphoc))
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
            return View(phuongphap_hoc);
        }

        // GET: Phuongphap_hocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phuongphap_hoc = await _context.Phuongphap_Hocs
                .FirstOrDefaultAsync(m => m.mapphoc == id);
            if (phuongphap_hoc == null)
            {
                return NotFound();
            }

            return View(phuongphap_hoc);
        }

        // POST: Phuongphap_hocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phuongphap_hoc = await _context.Phuongphap_Hocs.FindAsync(id);
            _context.Phuongphap_Hocs.Remove(phuongphap_hoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Phuongphap_hocExists(int id)
        {
            return _context.Phuongphap_Hocs.Any(e => e.mapphoc == id);
        }
    }
}
