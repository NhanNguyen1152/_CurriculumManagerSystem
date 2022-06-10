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
    public class Doituong_TuyensinhsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Doituong_TuyensinhsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Doituong_Tuyensinhs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Doituong_Tuyensinhs.ToListAsync());
        }

        // GET: Doituong_Tuyensinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doituong_Tuyensinh = await _context.Doituong_Tuyensinhs
                .FirstOrDefaultAsync(m => m.ma_dtts == id);
            if (doituong_Tuyensinh == null)
            {
                return NotFound();
            }

            return View(doituong_Tuyensinh);
        }

        // GET: Doituong_Tuyensinhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Doituong_Tuyensinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_dtts,noi_dung_dtts")] Doituong_Tuyensinh doituong_Tuyensinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doituong_Tuyensinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(doituong_Tuyensinh);
        }

        // GET: Doituong_Tuyensinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doituong_Tuyensinh = await _context.Doituong_Tuyensinhs.FindAsync(id);
            if (doituong_Tuyensinh == null)
            {
                return NotFound();
            }
            return View(doituong_Tuyensinh);
        }

        // POST: Doituong_Tuyensinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_dtts,noi_dung_dtts")] Doituong_Tuyensinh doituong_Tuyensinh)
        {
            if (id != doituong_Tuyensinh.ma_dtts)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doituong_Tuyensinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Doituong_TuyensinhExists(doituong_Tuyensinh.ma_dtts))
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
            return View(doituong_Tuyensinh);
        }

        // GET: Doituong_Tuyensinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doituong_Tuyensinh = await _context.Doituong_Tuyensinhs
                .FirstOrDefaultAsync(m => m.ma_dtts == id);
            if (doituong_Tuyensinh == null)
            {
                return NotFound();
            }

            return View(doituong_Tuyensinh);
        }

        // POST: Doituong_Tuyensinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doituong_Tuyensinh = await _context.Doituong_Tuyensinhs.FindAsync(id);
            _context.Doituong_Tuyensinhs.Remove(doituong_Tuyensinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Doituong_TuyensinhExists(int id)
        {
            return _context.Doituong_Tuyensinhs.Any(e => e.ma_dtts == id);
        }
    }
}
