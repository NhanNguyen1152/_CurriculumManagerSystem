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
    public class PLOsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public PLOsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: PLOs
        public async Task<IActionResult> Index()
        {
            return View(await _context.PLOs.ToListAsync());
        }

        // GET: PLOs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pLO = await _context.PLOs
                .FirstOrDefaultAsync(m => m.maplo == id);
            if (pLO == null)
            {
                return NotFound();
            }

            return View(pLO);
        }

        // GET: PLOs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PLOs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maplo,chisoplo,noidung")] PLO pLO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pLO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pLO);
        }

        // GET: PLOs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pLO = await _context.PLOs.FindAsync(id);
            if (pLO == null)
            {
                return NotFound();
            }
            return View(pLO);
        }

        // POST: PLOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("maplo,chisoplo,noidung")] PLO pLO)
        {
            if (id != pLO.maplo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pLO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PLOExists(pLO.maplo))
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
            return View(pLO);
        }

        // GET: PLOs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pLO = await _context.PLOs
                .FirstOrDefaultAsync(m => m.maplo == id);
            if (pLO == null)
            {
                return NotFound();
            }

            return View(pLO);
        }

        // POST: PLOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pLO = await _context.PLOs.FindAsync(id);
            _context.PLOs.Remove(pLO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PLOExists(int id)
        {
            return _context.PLOs.Any(e => e.maplo == id);
        }
    }
}
