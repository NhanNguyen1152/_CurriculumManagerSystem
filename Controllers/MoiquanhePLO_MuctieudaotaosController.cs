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
    public class MoiquanhePLO_MuctieudaotaosController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public MoiquanhePLO_MuctieudaotaosController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: MoiquanhePLO_Muctieudaotaos
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.MoiquanhePLO_Muctieudaotaos.Include(m => m.Muctieu_Daotao).Include(m => m.PLO);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: MoiquanhePLO_Muctieudaotaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos
                .Include(m => m.Muctieu_Daotao)
                .Include(m => m.PLO)
                .FirstOrDefaultAsync(m => m.ma_plo_mtdt == id);
            if (moiquanhePLO_Muctieudaotao == null)
            {
                return NotFound();
            }

            return View(moiquanhePLO_Muctieudaotao);
        }

        // GET: MoiquanhePLO_Muctieudaotaos/Create
        public IActionResult Create()
        {
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "mtdt_chiso");
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "chisoplo");
            return View();
        }

        // POST: MoiquanhePLO_Muctieudaotaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_plo_mtdt,ngay_update,maplo,ma_mtdt")] MoiquanhePLO_Muctieudaotao moiquanhePLO_Muctieudaotao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moiquanhePLO_Muctieudaotao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt", moiquanhePLO_Muctieudaotao.ma_mtdt);
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo", moiquanhePLO_Muctieudaotao.maplo);
            return View(moiquanhePLO_Muctieudaotao);
        }

        // GET: MoiquanhePLO_Muctieudaotaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos.FindAsync(id);
            if (moiquanhePLO_Muctieudaotao == null)
            {
                return NotFound();
            }
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt", moiquanhePLO_Muctieudaotao.ma_mtdt);
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo", moiquanhePLO_Muctieudaotao.maplo);
            return View(moiquanhePLO_Muctieudaotao);
        }

        // POST: MoiquanhePLO_Muctieudaotaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_plo_mtdt,ngay_update,maplo,ma_mtdt")] MoiquanhePLO_Muctieudaotao moiquanhePLO_Muctieudaotao)
        {
            if (id != moiquanhePLO_Muctieudaotao.ma_plo_mtdt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moiquanhePLO_Muctieudaotao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoiquanhePLO_MuctieudaotaoExists(moiquanhePLO_Muctieudaotao.ma_plo_mtdt))
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
            ViewData["ma_mtdt"] = new SelectList(_context.Muctieu_Daotaos, "ma_mtdt", "ma_mtdt", moiquanhePLO_Muctieudaotao.ma_mtdt);
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "maplo", moiquanhePLO_Muctieudaotao.maplo);
            return View(moiquanhePLO_Muctieudaotao);
        }

        // GET: MoiquanhePLO_Muctieudaotaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos
                .Include(m => m.Muctieu_Daotao)
                .Include(m => m.PLO)
                .FirstOrDefaultAsync(m => m.ma_plo_mtdt == id);
            if (moiquanhePLO_Muctieudaotao == null)
            {
                return NotFound();
            }

            return View(moiquanhePLO_Muctieudaotao);
        }

        // POST: MoiquanhePLO_Muctieudaotaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var moiquanhePLO_Muctieudaotao = await _context.MoiquanhePLO_Muctieudaotaos.FindAsync(id);
            _context.MoiquanhePLO_Muctieudaotaos.Remove(moiquanhePLO_Muctieudaotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoiquanhePLO_MuctieudaotaoExists(int id)
        {
            return _context.MoiquanhePLO_Muctieudaotaos.Any(e => e.ma_plo_mtdt == id);
        }
    }
}
