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
    public class CLOPhuongphapdaysController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public CLOPhuongphapdaysController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: CLOPhuongphapdays
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.CLOPhuongphapdays.Include(c => c.Chuandaura_monhoc).Include(c => c.Phuongphap_Giangday);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: CLOPhuongphapdays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLOPhuongphapday = await _context.CLOPhuongphapdays
                .Include(c => c.Chuandaura_monhoc)
                .Include(c => c.Phuongphap_Giangday)
                .FirstOrDefaultAsync(m => m.maloppday == id);
            if (cLOPhuongphapday == null)
            {
                return NotFound();
            }

            return View(cLOPhuongphapday);
        }

        // GET: CLOPhuongphapdays/Create
        public IActionResult Create()
        {
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "noidung");
            ViewData["mappday"] = new SelectList(_context.Phuongphap_Giangdays, "mappday", "tenpp");
            return View();
        }

        // POST: CLOPhuongphapdays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maloppday,mucdo,mappday,macdmon")] CLOPhuongphapday cLOPhuongphapday)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cLOPhuongphapday);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLOPhuongphapday.macdmon);
            ViewData["mappday"] = new SelectList(_context.Phuongphap_Giangdays, "mappday", "mappday", cLOPhuongphapday.mappday);
            return View(cLOPhuongphapday);
        }

        // GET: CLOPhuongphapdays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLOPhuongphapday = await _context.CLOPhuongphapdays.FindAsync(id);
            if (cLOPhuongphapday == null)
            {
                return NotFound();
            }
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLOPhuongphapday.macdmon);
            ViewData["mappday"] = new SelectList(_context.Phuongphap_Giangdays, "mappday", "mappday", cLOPhuongphapday.mappday);
            return View(cLOPhuongphapday);
        }

        // POST: CLOPhuongphapdays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("maloppday,mucdo,mappday,macdmon")] CLOPhuongphapday cLOPhuongphapday)
        {
            if (id != cLOPhuongphapday.maloppday)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cLOPhuongphapday);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CLOPhuongphapdayExists(cLOPhuongphapday.maloppday))
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
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLOPhuongphapday.macdmon);
            ViewData["mappday"] = new SelectList(_context.Phuongphap_Giangdays, "mappday", "mappday", cLOPhuongphapday.mappday);
            return View(cLOPhuongphapday);
        }

        // GET: CLOPhuongphapdays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLOPhuongphapday = await _context.CLOPhuongphapdays
                .Include(c => c.Chuandaura_monhoc)
                .Include(c => c.Phuongphap_Giangday)
                .FirstOrDefaultAsync(m => m.maloppday == id);
            if (cLOPhuongphapday == null)
            {
                return NotFound();
            }

            return View(cLOPhuongphapday);
        }

        // POST: CLOPhuongphapdays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cLOPhuongphapday = await _context.CLOPhuongphapdays.FindAsync(id);
            _context.CLOPhuongphapdays.Remove(cLOPhuongphapday);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CLOPhuongphapdayExists(int id)
        {
            return _context.CLOPhuongphapdays.Any(e => e.maloppday == id);
        }
    }
}
