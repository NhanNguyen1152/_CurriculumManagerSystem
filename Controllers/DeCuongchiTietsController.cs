using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;
using Microsoft.AspNetCore.Routing;

namespace _CurriculumManagerSystem.Controllers
{
    public class DeCuongchiTietsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public DeCuongchiTietsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: DeCuongchiTiets
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc);
            return View(await appDbContext.ToListAsync());
        }

        // GET: DeCuongchiTiets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets
                .FirstOrDefaultAsync(m => m.mahp == id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }

            return View(deCuongchiTiet);
        }

        // GET: DeCuongchiTiets/Create
        public IActionResult Create()
        {
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            return View();
        }

        // POST: DeCuongchiTiets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mahp,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt")] DeCuongchiTiet deCuongchiTiet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongchiTiet);
                await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Create", new { id = deCuongchiTiet.mahp });
                //return RedirectToAction("Index", new RouteValueDictionary( new { Controller = "Decuongchitiets", Action = "Create", id = deCuongchiTiet.mahp }));
            }
            return View(deCuongchiTiet);
        }

        // GET: DeCuongchiTiets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets.FindAsync(id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            return View(deCuongchiTiet);
        }

        // POST: DeCuongchiTiets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mahp,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt")] DeCuongchiTiet deCuongchiTiet)
        {
            if (id != deCuongchiTiet.mahp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deCuongchiTiet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeCuongchiTietExists(deCuongchiTiet.mahp))
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
            return View(deCuongchiTiet);
        }

        // GET: DeCuongchiTiets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets
                .FirstOrDefaultAsync(m => m.mahp == id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            return View(deCuongchiTiet);
        }

        // POST: DeCuongchiTiets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deCuongchiTiet = await _context.DeCuongchiTiets.FindAsync(id);
            _context.DeCuongchiTiets.Remove(deCuongchiTiet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeCuongchiTietExists(int id)
        {
            return _context.DeCuongchiTiets.Any(e => e.mahp == id);
        }

        public async Task<IActionResult> getMucTieu() 
        {
            var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc).Include(d => d.Muctieus).Include(d => d.Phutraches);
            return View(await appDbContext.ToListAsync());
        }

        public IActionResult _Partial_muctieu()
        {
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            return PartialView("_Partial_muctieu");
            // return PartialView(GetMuctieus());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> createMuctieu([Bind("mamt,noidung,mtchinh,mtphu,mahp")] Muctieu muctieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(muctieu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(muctieu);
        }
    }
}
