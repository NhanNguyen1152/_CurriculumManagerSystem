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
    public class Chuandaura_monhocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Chuandaura_monhocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Chuandaura_monhocs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chuandaura_Monhocs.ToListAsync());
        }

        // GET: Chuandaura_monhocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuandaura_monhoc = await _context.Chuandaura_Monhocs
                .FirstOrDefaultAsync(m => m.macdmon == id);
            if (chuandaura_monhoc == null)
            {
                return NotFound();
            }

            return View(chuandaura_monhoc);
        }

        // GET: Chuandaura_monhocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chuandaura_monhocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("macdmon,chisocio,noidung,loai,mahp")] Chuandaura_monhoc chuandaura_monhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuandaura_monhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuandaura_monhoc);
        }

        // GET: Chuandaura_monhocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuandaura_monhoc = await _context.Chuandaura_Monhocs.FindAsync(id);
            if (chuandaura_monhoc == null)
            {
                return NotFound();
            }
            return View(chuandaura_monhoc);
        }

        // POST: Chuandaura_monhocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("macdmon,chisocio,noidung,loai,mahp")] Chuandaura_monhoc chuandaura_monhoc)
        {
            if (id != chuandaura_monhoc.macdmon)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuandaura_monhoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Chuandaura_monhocExists(chuandaura_monhoc.macdmon))
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
            return View(chuandaura_monhoc);
        }

        // GET: Chuandaura_monhocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuandaura_monhoc = await _context.Chuandaura_Monhocs
                .FirstOrDefaultAsync(m => m.macdmon == id);
            if (chuandaura_monhoc == null)
            {
                return NotFound();
            }

            return View(chuandaura_monhoc);
        }

        // POST: Chuandaura_monhocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chuandaura_monhoc = await _context.Chuandaura_Monhocs.FindAsync(id);
            _context.Chuandaura_Monhocs.Remove(chuandaura_monhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Chuandaura_monhocExists(int id)
        {
            return _context.Chuandaura_Monhocs.Any(e => e.macdmon == id);
        }
    }
}
