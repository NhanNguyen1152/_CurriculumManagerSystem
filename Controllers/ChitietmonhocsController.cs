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
    public class ChitietmonhocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public ChitietmonhocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Chitietmonhocs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chitietmonhocs.ToListAsync());
        }

        // GET: Chitietmonhocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietmonhoc = await _context.Chitietmonhocs
                .FirstOrDefaultAsync(m => m.mact == id);
            if (chitietmonhoc == null)
            {
                return NotFound();
            }

            return View(chitietmonhoc);
        }

        // GET: Chitietmonhocs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chitietmonhocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mact,chiso,tenchuong,tietlt,tietth,mahp")] Chitietmonhoc chitietmonhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitietmonhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chitietmonhoc);
        }

        // GET: Chitietmonhocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietmonhoc = await _context.Chitietmonhocs.FindAsync(id);
            if (chitietmonhoc == null)
            {
                return NotFound();
            }
            return View(chitietmonhoc);
        }

        // POST: Chitietmonhocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mact,chiso,tenchuong,tietlt,tietth,mahp")] Chitietmonhoc chitietmonhoc)
        {
            if (id != chitietmonhoc.mact)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitietmonhoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChitietmonhocExists(chitietmonhoc.mact))
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
            return View(chitietmonhoc);
        }

        // GET: Chitietmonhocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitietmonhoc = await _context.Chitietmonhocs
                .FirstOrDefaultAsync(m => m.mact == id);
            if (chitietmonhoc == null)
            {
                return NotFound();
            }

            return View(chitietmonhoc);
        }

        // POST: Chitietmonhocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chitietmonhoc = await _context.Chitietmonhocs.FindAsync(id);
            _context.Chitietmonhocs.Remove(chitietmonhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChitietmonhocExists(int id)
        {
            return _context.Chitietmonhocs.Any(e => e.mact == id);
        }
    }
}
