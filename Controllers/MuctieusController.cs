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
    public class MuctieusController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public MuctieusController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Muctieus
        public async Task<IActionResult> Index(int id)
        {
            ViewBag.param = id;
            var appDbContext = _context.Muctieus.Include(m => m.DeCuongchiTiet);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Muctieus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muctieu = await _context.Muctieus
                .FirstOrDefaultAsync(m => m.mamt == id);
            if (muctieu == null)
            {
                return NotFound();
            }
            
            return View(muctieu);
        }

        // GET: Muctieus/Create
        public IActionResult Create()
        {
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            return View();
        }

        // POST: Muctieus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mamt,noidung,mtchinh,mtphu,mahp")] Muctieu muctieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(muctieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(muctieu);
        }

        // GET: Muctieus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muctieu = await _context.Muctieus.FindAsync(id);
            if (muctieu == null)
            {
                return NotFound();
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            return View(muctieu);
        }

        // POST: Muctieus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mamt,noidung,mtchinh,mtphu,mahp")] Muctieu muctieu)
        {
            if (id != muctieu.mamt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(muctieu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MuctieuExists(muctieu.mamt))
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
            return View(muctieu);
        }

        // GET: Muctieus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muctieu = await _context.Muctieus
                .FirstOrDefaultAsync(m => m.mamt == id);
            if (muctieu == null)
            {
                return NotFound();
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            return View(muctieu);
        }

        // POST: Muctieus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var muctieu = await _context.Muctieus.FindAsync(id);
            _context.Muctieus.Remove(muctieu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MuctieuExists(int id)
        {
            return _context.Muctieus.Any(e => e.mamt == id);
        }
    }
}
