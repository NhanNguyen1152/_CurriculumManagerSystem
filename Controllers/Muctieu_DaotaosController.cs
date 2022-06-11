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
    public class Muctieu_DaotaosController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Muctieu_DaotaosController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Muctieu_Daotaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Muctieu_Daotaos.ToListAsync());
        }

        // GET: Muctieu_Daotaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muctieu_Daotao = await _context.Muctieu_Daotaos
                .FirstOrDefaultAsync(m => m.ma_mtdt == id);
            if (muctieu_Daotao == null)
            {
                return NotFound();
            }

            return View(muctieu_Daotao);
        }

        // GET: Muctieu_Daotaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Muctieu_Daotaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_mtdt,noi_dung,mtdt_chinh,mtdt_phu,mtdt_chiso")] Muctieu_Daotao muctieu_Daotao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(muctieu_Daotao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(muctieu_Daotao);
        }

        // GET: Muctieu_Daotaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muctieu_Daotao = await _context.Muctieu_Daotaos.FindAsync(id);
            if (muctieu_Daotao == null)
            {
                return NotFound();
            }
            return View(muctieu_Daotao);
        }

        // POST: Muctieu_Daotaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_mtdt,noi_dung,mtdt_chinh,mtdt_phu,mtdt_chiso")] Muctieu_Daotao muctieu_Daotao)
        {
            if (id != muctieu_Daotao.ma_mtdt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(muctieu_Daotao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Muctieu_DaotaoExists(muctieu_Daotao.ma_mtdt))
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
            return View(muctieu_Daotao);
        }

        // GET: Muctieu_Daotaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var muctieu_Daotao = await _context.Muctieu_Daotaos
                .FirstOrDefaultAsync(m => m.ma_mtdt == id);
            if (muctieu_Daotao == null)
            {
                return NotFound();
            }

            return View(muctieu_Daotao);
        }

        // POST: Muctieu_Daotaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var muctieu_Daotao = await _context.Muctieu_Daotaos.FindAsync(id);
            _context.Muctieu_Daotaos.Remove(muctieu_Daotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Muctieu_DaotaoExists(int id)
        {
            return _context.Muctieu_Daotaos.Any(e => e.ma_mtdt == id);
        }
    }
}
