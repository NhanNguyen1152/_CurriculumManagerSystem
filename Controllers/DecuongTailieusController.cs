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
    public class DecuongTailieusController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public DecuongTailieusController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: DecuongTailieus
        public async Task<IActionResult> Index()
        {
            return View(await _context.DecuongTailieus.ToListAsync());
        }

        // GET: DecuongTailieus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuongTailieu = await _context.DecuongTailieus
                .FirstOrDefaultAsync(m => m.dctl_id == id);
            if (decuongTailieu == null)
            {
                return NotFound();
            }

            return View(decuongTailieu);
        }

        // GET: DecuongTailieus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DecuongTailieus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("dctl_id")] DecuongTailieu decuongTailieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(decuongTailieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(decuongTailieu);
        }

        // GET: DecuongTailieus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuongTailieu = await _context.DecuongTailieus.FindAsync(id);
            if (decuongTailieu == null)
            {
                return NotFound();
            }
            return View(decuongTailieu);
        }

        // POST: DecuongTailieus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("dctl_id")] DecuongTailieu decuongTailieu)
        {
            if (id != decuongTailieu.dctl_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(decuongTailieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DecuongTailieuExists(decuongTailieu.dctl_id))
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
            return View(decuongTailieu);
        }

        // GET: DecuongTailieus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var decuongTailieu = await _context.DecuongTailieus
                .FirstOrDefaultAsync(m => m.dctl_id == id);
            if (decuongTailieu == null)
            {
                return NotFound();
            }

            return View(decuongTailieu);
        }

        // POST: DecuongTailieus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var decuongTailieu = await _context.DecuongTailieus.FindAsync(id);
            _context.DecuongTailieus.Remove(decuongTailieu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DecuongTailieuExists(int id)
        {
            return _context.DecuongTailieus.Any(e => e.dctl_id == id);
        }
    }
}
