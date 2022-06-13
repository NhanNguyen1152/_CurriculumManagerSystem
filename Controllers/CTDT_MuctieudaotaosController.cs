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
    public class CTDT_MuctieudaotaosController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public CTDT_MuctieudaotaosController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: CTDT_Muctieudaotaos
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.CTDT_Muctieudaotaos.Include(c => c.Chuongtrinh_Daotao).Include(c => c.Muctieu_Daotao);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: CTDT_Muctieudaotaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTDT_Muctieudaotao = await _context.CTDT_Muctieudaotaos
                .Include(c => c.Chuongtrinh_Daotao)
                .Include(c => c.Muctieu_Daotao)
                .FirstOrDefaultAsync(m => m.ma_ctdt_mtdt == id);
            if (cTDT_Muctieudaotao == null)
            {
                return NotFound();
            }

            return View(cTDT_Muctieudaotao);
        }

        // GET: CTDT_Muctieudaotaos/Create
        public IActionResult Create()
        {
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt");
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt");
            return View();
        }

        // POST: CTDT_Muctieudaotaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_ctdt_mtdt,ma_ctdt,ma_mtdt")] CTDT_Muctieudaotao cTDT_Muctieudaotao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cTDT_Muctieudaotao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", cTDT_Muctieudaotao.ma_ctdt);
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt", cTDT_Muctieudaotao.ma_mtdt);
            return View(cTDT_Muctieudaotao);
        }

        // GET: CTDT_Muctieudaotaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTDT_Muctieudaotao = await _context.CTDT_Muctieudaotaos.FindAsync(id);
            if (cTDT_Muctieudaotao == null)
            {
                return NotFound();
            }
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", cTDT_Muctieudaotao.ma_ctdt);
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt", cTDT_Muctieudaotao.ma_mtdt);
            return View(cTDT_Muctieudaotao);
        }

        // POST: CTDT_Muctieudaotaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_ctdt_mtdt,ma_ctdt,ma_mtdt")] CTDT_Muctieudaotao cTDT_Muctieudaotao)
        {
            if (id != cTDT_Muctieudaotao.ma_ctdt_mtdt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cTDT_Muctieudaotao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CTDT_MuctieudaotaoExists(cTDT_Muctieudaotao.ma_ctdt_mtdt))
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
            ViewData["ma_ctdt"] = new SelectList(_context.Chuongtrinh_Daotaos, "ma_ctdt", "ma_ctdt", cTDT_Muctieudaotao.ma_ctdt);
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt", cTDT_Muctieudaotao.ma_mtdt);
            return View(cTDT_Muctieudaotao);
        }

        // GET: CTDT_Muctieudaotaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cTDT_Muctieudaotao = await _context.CTDT_Muctieudaotaos
                .Include(c => c.Chuongtrinh_Daotao)
                .Include(c => c.Muctieu_Daotao)
                .FirstOrDefaultAsync(m => m.ma_ctdt_mtdt == id);
            if (cTDT_Muctieudaotao == null)
            {
                return NotFound();
            }

            return View(cTDT_Muctieudaotao);
        }

        // POST: CTDT_Muctieudaotaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cTDT_Muctieudaotao = await _context.CTDT_Muctieudaotaos.FindAsync(id);
            _context.CTDT_Muctieudaotaos.Remove(cTDT_Muctieudaotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CTDT_MuctieudaotaoExists(int id)
        {
            return _context.CTDT_Muctieudaotaos.Any(e => e.ma_ctdt_mtdt == id);
        }
    }
}
