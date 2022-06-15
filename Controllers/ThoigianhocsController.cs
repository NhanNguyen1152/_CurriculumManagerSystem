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
    public class ThoigianhocsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public ThoigianhocsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Thoigianhocs
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).Include(t => t.Khoahocs).Include(t => t.Hockys);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Thoigianhocs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thoigianhoc = await _context.Thoigianhocs
                .FirstOrDefaultAsync(m => m.matg == id);
            if (thoigianhoc == null)
            {
                return NotFound();
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            ViewData["makh"] = new SelectList(_context.Khoahocs, "makh", "tenkh");
            ViewData["mahk"] = new SelectList(_context.Hockys, "mahk", "tenhk");
            return View(thoigianhoc);
        }

        // GET: Thoigianhocs/Create
        public IActionResult Create()
        {
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            ViewData["makh"] = new SelectList(_context.Khoahocs, "makh", "tenkh");
            ViewData["mahk"] = new SelectList(_context.Hockys, "mahk", "tenhk");
            return View();
        }

        // POST: Thoigianhocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thoigianhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thoigianhoc);
        }

        // GET: Thoigianhocs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            if (thoigianhoc == null)
            {
                return NotFound();
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet", thoigianhoc.mahp.ToString());
            ViewData["makh"] = new SelectList(_context.Khoahocs, "makh", "tenkh", thoigianhoc.makh.ToString());
            ViewData["mahk"] = new SelectList(_context.Hockys, "mahk", "tenhk", thoigianhoc.mahk.ToString());
            return View(thoigianhoc);
        }

        // POST: Thoigianhocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
        {
            if (id != thoigianhoc.matg)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thoigianhoc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ThoigianhocExists(thoigianhoc.matg))
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
            return View(thoigianhoc);
        }

        // GET: Thoigianhocs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thoigianhoc = await _context.Thoigianhocs
                .FirstOrDefaultAsync(m => m.matg == id);
            if (thoigianhoc == null)
            {
                return NotFound();
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet", thoigianhoc.mahp.ToString());
            ViewData["makh"] = new SelectList(_context.Khoahocs, "makh", "tenkh", thoigianhoc.makh.ToString());
            ViewData["mahk"] = new SelectList(_context.Hockys, "mahk", "tenhk", thoigianhoc.mahk.ToString());
            return View(thoigianhoc);
        }

        // POST: Thoigianhocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            _context.Thoigianhocs.Remove(thoigianhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThoigianhocExists(int id)
        {
            return _context.Thoigianhocs.Any(e => e.matg == id);
        }

        public IActionResult getThoikhoabieu(string khoahoc)
        {
            ViewBag.kk = khoahoc;
            var dataTimetable = _context.Thoigianhocs.Include(t => t.DeCuongchiTiet).ThenInclude(t => t.Khoikienthuc).Include(t => t.Hockys).Include(t => t.Khoahocs).Where(t => t.Khoahocs.tenkh == khoahoc).OrderBy(t => t.Hockys.tenhk);
            TempData["listData"] = dataTimetable.ToList();
            return View();
        }
    }
}
