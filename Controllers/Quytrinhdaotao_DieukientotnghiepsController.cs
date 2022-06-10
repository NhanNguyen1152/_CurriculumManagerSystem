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
    public class Quytrinhdaotao_DieukientotnghiepsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Quytrinhdaotao_DieukientotnghiepsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Quytrinhdaotao_Dieukientotnghieps
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quytrinhdaotao_Dieukientotnghieps.ToListAsync());
        }

        // GET: Quytrinhdaotao_Dieukientotnghieps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quytrinhdaotao_Dieukientotnghiep = await _context.Quytrinhdaotao_Dieukientotnghieps
                .FirstOrDefaultAsync(m => m.ma_qt_dktn == id);
            if (quytrinhdaotao_Dieukientotnghiep == null)
            {
                return NotFound();
            }

            return View(quytrinhdaotao_Dieukientotnghiep);
        }

        // GET: Quytrinhdaotao_Dieukientotnghieps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Quytrinhdaotao_Dieukientotnghieps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_qt_dktn,noi_dung_quytrinhdieukien")] Quytrinhdaotao_Dieukientotnghiep quytrinhdaotao_Dieukientotnghiep)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quytrinhdaotao_Dieukientotnghiep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(quytrinhdaotao_Dieukientotnghiep);
        }

        // GET: Quytrinhdaotao_Dieukientotnghieps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quytrinhdaotao_Dieukientotnghiep = await _context.Quytrinhdaotao_Dieukientotnghieps.FindAsync(id);
            if (quytrinhdaotao_Dieukientotnghiep == null)
            {
                return NotFound();
            }
            return View(quytrinhdaotao_Dieukientotnghiep);
        }

        // POST: Quytrinhdaotao_Dieukientotnghieps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_qt_dktn,noi_dung_quytrinhdieukien")] Quytrinhdaotao_Dieukientotnghiep quytrinhdaotao_Dieukientotnghiep)
        {
            if (id != quytrinhdaotao_Dieukientotnghiep.ma_qt_dktn)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quytrinhdaotao_Dieukientotnghiep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Quytrinhdaotao_DieukientotnghiepExists(quytrinhdaotao_Dieukientotnghiep.ma_qt_dktn))
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
            return View(quytrinhdaotao_Dieukientotnghiep);
        }

        // GET: Quytrinhdaotao_Dieukientotnghieps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quytrinhdaotao_Dieukientotnghiep = await _context.Quytrinhdaotao_Dieukientotnghieps
                .FirstOrDefaultAsync(m => m.ma_qt_dktn == id);
            if (quytrinhdaotao_Dieukientotnghiep == null)
            {
                return NotFound();
            }

            return View(quytrinhdaotao_Dieukientotnghiep);
        }

        // POST: Quytrinhdaotao_Dieukientotnghieps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var quytrinhdaotao_Dieukientotnghiep = await _context.Quytrinhdaotao_Dieukientotnghieps.FindAsync(id);
            _context.Quytrinhdaotao_Dieukientotnghieps.Remove(quytrinhdaotao_Dieukientotnghiep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Quytrinhdaotao_DieukientotnghiepExists(int id)
        {
            return _context.Quytrinhdaotao_Dieukientotnghieps.Any(e => e.ma_qt_dktn == id);
        }
    }
}
