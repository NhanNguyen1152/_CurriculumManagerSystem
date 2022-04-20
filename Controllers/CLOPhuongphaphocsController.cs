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
    public class CLOPhuongphaphocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public CLOPhuongphaphocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: CLOPhuongphaphocs
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.CLOPhuongphaphocs.Include(c => c.Chuandaura_monhoc).Include(c => c.Phuongphap_hoc);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: CLOPhuongphaphocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLOPhuongphaphoc = await _context.CLOPhuongphaphocs
                .Include(c => c.Chuandaura_monhoc)
                .Include(c => c.Phuongphap_hoc)
                .FirstOrDefaultAsync(m => m.maclopphoc == id);
            if (cLOPhuongphaphoc == null)
            {
                return NotFound();
            }

            return View(cLOPhuongphaphoc);
        }

        // GET: CLOPhuongphaphocs/Create
        public IActionResult Create()
        {
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon");
            ViewData["mapphoc"] = new SelectList(_context.Phuongphap_Hocs, "mapphoc", "mapphoc");
            return View();
        }

        // POST: CLOPhuongphaphocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maclopphoc,mucdo,mapphoc,macdmon")] CLOPhuongphaphoc cLOPhuongphaphoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cLOPhuongphaphoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLOPhuongphaphoc.macdmon);
            ViewData["mapphoc"] = new SelectList(_context.Phuongphap_Hocs, "mapphoc", "mapphoc", cLOPhuongphaphoc.mapphoc);
            return View(cLOPhuongphaphoc);
        }

        // GET: CLOPhuongphaphocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLOPhuongphaphoc = await _context.CLOPhuongphaphocs.FindAsync(id);
            if (cLOPhuongphaphoc == null)
            {
                return NotFound();
            }
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLOPhuongphaphoc.macdmon);
            ViewData["mapphoc"] = new SelectList(_context.Phuongphap_Hocs, "mapphoc", "mapphoc", cLOPhuongphaphoc.mapphoc);
            return View(cLOPhuongphaphoc);
        }

        // POST: CLOPhuongphaphocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("maclopphoc,mucdo,mapphoc,macdmon")] CLOPhuongphaphoc cLOPhuongphaphoc)
        {
            if (id != cLOPhuongphaphoc.maclopphoc)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cLOPhuongphaphoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CLOPhuongphaphocExists(cLOPhuongphaphoc.maclopphoc))
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
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLOPhuongphaphoc.macdmon);
            ViewData["mapphoc"] = new SelectList(_context.Phuongphap_Hocs, "mapphoc", "mapphoc", cLOPhuongphaphoc.mapphoc);
            return View(cLOPhuongphaphoc);
        }

        // GET: CLOPhuongphaphocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLOPhuongphaphoc = await _context.CLOPhuongphaphocs
                .Include(c => c.Chuandaura_monhoc)
                .Include(c => c.Phuongphap_hoc)
                .FirstOrDefaultAsync(m => m.maclopphoc == id);
            if (cLOPhuongphaphoc == null)
            {
                return NotFound();
            }

            return View(cLOPhuongphaphoc);
        }

        // POST: CLOPhuongphaphocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cLOPhuongphaphoc = await _context.CLOPhuongphaphocs.FindAsync(id);
            _context.CLOPhuongphaphocs.Remove(cLOPhuongphaphoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CLOPhuongphaphocExists(int id)
        {
            return _context.CLOPhuongphaphocs.Any(e => e.maclopphoc == id);
        }
    }
}
