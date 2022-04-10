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
    public class Phuongphap_GiangdaysController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Phuongphap_GiangdaysController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Phuongphap_Giangdays
        public async Task<IActionResult> Index()
        {
            return View(await _context.Phuongphap_Giangdays.ToListAsync());
        }

        // GET: Phuongphap_Giangdays/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phuongphap_Giangday = await _context.Phuongphap_Giangdays
                .FirstOrDefaultAsync(m => m.mappday == id);
            if (phuongphap_Giangday == null)
            {
                return NotFound();
            }

            return View(phuongphap_Giangday);
        }

        // GET: Phuongphap_Giangdays/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phuongphap_Giangdays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mappday,tenpp")] Phuongphap_Giangday phuongphap_Giangday)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phuongphap_Giangday);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phuongphap_Giangday);
        }

        // GET: Phuongphap_Giangdays/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phuongphap_Giangday = await _context.Phuongphap_Giangdays.FindAsync(id);
            if (phuongphap_Giangday == null)
            {
                return NotFound();
            }
            return View(phuongphap_Giangday);
        }

        // POST: Phuongphap_Giangdays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mappday,tenpp")] Phuongphap_Giangday phuongphap_Giangday)
        {
            if (id != phuongphap_Giangday.mappday)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phuongphap_Giangday);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Phuongphap_GiangdayExists(phuongphap_Giangday.mappday))
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
            return View(phuongphap_Giangday);
        }

        // GET: Phuongphap_Giangdays/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var phuongphap_Giangday = await _context.Phuongphap_Giangdays
                .FirstOrDefaultAsync(m => m.mappday == id);
            if (phuongphap_Giangday == null)
            {
                return NotFound();
            }

            return View(phuongphap_Giangday);
        }

        // POST: Phuongphap_Giangdays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phuongphap_Giangday = await _context.Phuongphap_Giangdays.FindAsync(id);
            _context.Phuongphap_Giangdays.Remove(phuongphap_Giangday);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Phuongphap_GiangdayExists(int id)
        {
            return _context.Phuongphap_Giangdays.Any(e => e.mappday == id);
        }
    }
}
