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
    public class CLPOsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public CLPOsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: CLPOs
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.CLPOs.Include(c => c.Chuandaura_monhoc).Include(c => c.PLO);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: CLPOs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLPO = await _context.CLPOs
                .Include(c => c.Chuandaura_monhoc)
                .Include(c => c.PLO)
                .FirstOrDefaultAsync(m => m.maclpo == id);
            if (cLPO == null)
            {
                return NotFound();
            }

            return View(cLPO);
        }

        // GET: CLPOs/Create
        public IActionResult Create()
        {
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon");
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo");
            return View();
        }

        // POST: CLPOs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maclpo,ngayupdate,macdmon,maplo")] CLPO cLPO)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cLPO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLPO.macdmon);
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo", cLPO.maplo);
            return View(cLPO);
        }

        // GET: CLPOs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLPO = await _context.CLPOs.FindAsync(id);
            if (cLPO == null)
            {
                return NotFound();
            }
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLPO.macdmon);
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo", cLPO.maplo);
            return View(cLPO);
        }

        // POST: CLPOs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("maclpo,ngayupdate,macdmon,maplo")] CLPO cLPO)
        {
            if (id != cLPO.maclpo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cLPO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CLPOExists(cLPO.maclpo))
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
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs, "macdmon", "macdmon", cLPO.macdmon);
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo", cLPO.maplo);
            return View(cLPO);
        }

        // GET: CLPOs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cLPO = await _context.CLPOs
                .Include(c => c.Chuandaura_monhoc)
                .Include(c => c.PLO)
                .FirstOrDefaultAsync(m => m.maclpo == id);
            if (cLPO == null)
            {
                return NotFound();
            }

            return View(cLPO);
        }

        // POST: CLPOs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cLPO = await _context.CLPOs.FindAsync(id);
            _context.CLPOs.Remove(cLPO);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CLPOExists(int id)
        {
            return _context.CLPOs.Any(e => e.maclpo == id);
        }
    }
}
