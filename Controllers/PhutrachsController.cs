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
    public class PhutrachsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public PhutrachsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Phutrachs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Phutrachs.ToListAsync());
        }

        // GET: Phutrachs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phutrach = await _context.Phutrachs
                .FirstOrDefaultAsync(m => m.mapt == id);
            if (phutrach == null)
            {
                return NotFound();
            }

            return View(phutrach);
        }

        // GET: Phutrachs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phutrachs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mapt,vaitro")] Phutrach phutrach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phutrach);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phutrach);
        }

        // GET: Phutrachs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phutrach = await _context.Phutrachs.FindAsync(id);
            if (phutrach == null)
            {
                return NotFound();
            }
            return View(phutrach);
        }

        // POST: Phutrachs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mapt,vaitro")] Phutrach phutrach)
        {
            if (id != phutrach.mapt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phutrach);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhutrachExists(phutrach.mapt))
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
            return View(phutrach);
        }

        // GET: Phutrachs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phutrach = await _context.Phutrachs
                .FirstOrDefaultAsync(m => m.mapt == id);
            if (phutrach == null)
            {
                return NotFound();
            }

            return View(phutrach);
        }

        // POST: Phutrachs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phutrach = await _context.Phutrachs.FindAsync(id);
            _context.Phutrachs.Remove(phutrach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhutrachExists(int id)
        {
            return _context.Phutrachs.Any(e => e.mapt == id);
        }
    }
}
