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
    public class Hinhthuc_DanhgiasController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Hinhthuc_DanhgiasController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Hinhthuc_Danhgias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hinhthuc_Danhgias.ToListAsync());
        }

        // GET: Hinhthuc_Danhgias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhthuc_Danhgia = await _context.Hinhthuc_Danhgias
                .FirstOrDefaultAsync(m => m.mahtdg == id);
            if (hinhthuc_Danhgia == null)
            {
                return NotFound();
            }

            return View(hinhthuc_Danhgia);
        }

        // GET: Hinhthuc_Danhgias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hinhthuc_Danhgias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mahtdg,thanhphan_danhgia,hinhthuc,trongso")] Hinhthuc_Danhgia hinhthuc_Danhgia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hinhthuc_Danhgia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hinhthuc_Danhgia);
        }

        // GET: Hinhthuc_Danhgias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhthuc_Danhgia = await _context.Hinhthuc_Danhgias.FindAsync(id);
            if (hinhthuc_Danhgia == null)
            {
                return NotFound();
            }
            return View(hinhthuc_Danhgia);
        }

        // POST: Hinhthuc_Danhgias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mahtdg,thanhphan_danhgia,hinhthuc,trongso")] Hinhthuc_Danhgia hinhthuc_Danhgia)
        {
            if (id != hinhthuc_Danhgia.mahtdg)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hinhthuc_Danhgia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Hinhthuc_DanhgiaExists(hinhthuc_Danhgia.mahtdg))
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
            return View(hinhthuc_Danhgia);
        }

        // GET: Hinhthuc_Danhgias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hinhthuc_Danhgia = await _context.Hinhthuc_Danhgias
                .FirstOrDefaultAsync(m => m.mahtdg == id);
            if (hinhthuc_Danhgia == null)
            {
                return NotFound();
            }

            return View(hinhthuc_Danhgia);
        }

        // POST: Hinhthuc_Danhgias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hinhthuc_Danhgia = await _context.Hinhthuc_Danhgias.FindAsync(id);
            _context.Hinhthuc_Danhgias.Remove(hinhthuc_Danhgia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Hinhthuc_DanhgiaExists(int id)
        {
            return _context.Hinhthuc_Danhgias.Any(e => e.mahtdg == id);
        }
    }
}
