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
    public class Quydinh_KiemtrasController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Quydinh_KiemtrasController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Quydinh_Kiemtras
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quydinh_Kiemtras.ToListAsync());
        }

        // GET: Quydinh_Kiemtras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quydinh_Kiemtra = await _context.Quydinh_Kiemtras
                .FirstOrDefaultAsync(m => m.maqd == id);
            if (quydinh_Kiemtra == null)
            {
                return NotFound();
            }

            return View(quydinh_Kiemtra);
        }

        // GET: Quydinh_Kiemtras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quydinh_Kiemtras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("maqd,tenqd")] Quydinh_Kiemtra quydinh_Kiemtra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quydinh_Kiemtra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quydinh_Kiemtra);
        }

        // GET: Quydinh_Kiemtras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quydinh_Kiemtra = await _context.Quydinh_Kiemtras.FindAsync(id);
            if (quydinh_Kiemtra == null)
            {
                return NotFound();
            }
            return View(quydinh_Kiemtra);
        }

        // POST: Quydinh_Kiemtras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("maqd,tenqd")] Quydinh_Kiemtra quydinh_Kiemtra)
        {
            if (id != quydinh_Kiemtra.maqd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quydinh_Kiemtra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Quydinh_KiemtraExists(quydinh_Kiemtra.maqd))
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
            return View(quydinh_Kiemtra);
        }

        // GET: Quydinh_Kiemtras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quydinh_Kiemtra = await _context.Quydinh_Kiemtras
                .FirstOrDefaultAsync(m => m.maqd == id);
            if (quydinh_Kiemtra == null)
            {
                return NotFound();
            }

            return View(quydinh_Kiemtra);
        }

        // POST: Quydinh_Kiemtras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quydinh_Kiemtra = await _context.Quydinh_Kiemtras.FindAsync(id);
            _context.Quydinh_Kiemtras.Remove(quydinh_Kiemtra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Quydinh_KiemtraExists(int id)
        {
            return _context.Quydinh_Kiemtras.Any(e => e.maqd == id);
        }
    }
}
