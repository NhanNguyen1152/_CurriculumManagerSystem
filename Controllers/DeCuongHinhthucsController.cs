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
    public class DeCuongHinhthucsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public DeCuongHinhthucsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: DeCuongHinhthucs
        public async Task<IActionResult> Index()
        {
            return View(await _context.DeCuongHinhthucs.ToListAsync());
        }

        // GET: DeCuongHinhthucs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongHinhthuc = await _context.DeCuongHinhthucs
                .FirstOrDefaultAsync(m => m.dcht_id == id);
            if (deCuongHinhthuc == null)
            {
                return NotFound();
            }

            return View(deCuongHinhthuc);
        }

        // GET: DeCuongHinhthucs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DeCuongHinhthucs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("dcht_id")] DeCuongHinhthuc deCuongHinhthuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongHinhthuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deCuongHinhthuc);
        }

        // GET: DeCuongHinhthucs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongHinhthuc = await _context.DeCuongHinhthucs.FindAsync(id);
            if (deCuongHinhthuc == null)
            {
                return NotFound();
            }
            return View(deCuongHinhthuc);
        }

        // POST: DeCuongHinhthucs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("dcht_id")] DeCuongHinhthuc deCuongHinhthuc)
        {
            if (id != deCuongHinhthuc.dcht_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deCuongHinhthuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeCuongHinhthucExists(deCuongHinhthuc.dcht_id))
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
            return View(deCuongHinhthuc);
        }

        // GET: DeCuongHinhthucs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongHinhthuc = await _context.DeCuongHinhthucs
                .FirstOrDefaultAsync(m => m.dcht_id == id);
            if (deCuongHinhthuc == null)
            {
                return NotFound();
            }

            return View(deCuongHinhthuc);
        }

        // POST: DeCuongHinhthucs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deCuongHinhthuc = await _context.DeCuongHinhthucs.FindAsync(id);
            _context.DeCuongHinhthucs.Remove(deCuongHinhthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeCuongHinhthucExists(int id)
        {
            return _context.DeCuongHinhthucs.Any(e => e.dcht_id == id);
        }
    }
}
