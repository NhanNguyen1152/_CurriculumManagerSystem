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
    public class DeCuongQuyDinhsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public DeCuongQuyDinhsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: DeCuongQuyDinhs
        public async Task<IActionResult> Index()
        {
            var acomptec_lvthainhanContext = _context.DeCuongQuyDinhs.Include(d => d.DeCuongchiTiet).Include(d => d.Quydinh_Kiemtra);
            return View(await acomptec_lvthainhanContext.ToListAsync());
        }

        // GET: DeCuongQuyDinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongQuyDinh = await _context.DeCuongQuyDinhs
                .Include(d => d.DeCuongchiTiet)
                .Include(d => d.Quydinh_Kiemtra)
                .FirstOrDefaultAsync(m => m.dcqd_id == id);
            if (deCuongQuyDinh == null)
            {
                return NotFound();
            }

            return View(deCuongQuyDinh);
        }

        // GET: DeCuongQuyDinhs/Create
        public IActionResult Create()
        {
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp");
            ViewData["maqd"] = new SelectList(_context.Quydinh_Kiemtras, "maqd", "maqd");
            return View();
        }

        // POST: DeCuongQuyDinhs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("dcqd_id,mahp,maqd")] DeCuongQuyDinh deCuongQuyDinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongQuyDinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp", deCuongQuyDinh.mahp);
            ViewData["maqd"] = new SelectList(_context.Quydinh_Kiemtras, "maqd", "maqd", deCuongQuyDinh.maqd);
            return View(deCuongQuyDinh);
        }

        // GET: DeCuongQuyDinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongQuyDinh = await _context.DeCuongQuyDinhs.FindAsync(id);
            if (deCuongQuyDinh == null)
            {
                return NotFound();
            }
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp", deCuongQuyDinh.mahp);
            ViewData["maqd"] = new SelectList(_context.Quydinh_Kiemtras, "maqd", "maqd", deCuongQuyDinh.maqd);
            return View(deCuongQuyDinh);
        }

        // POST: DeCuongQuyDinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("dcqd_id,mahp,maqd")] DeCuongQuyDinh deCuongQuyDinh)
        {
            if (id != deCuongQuyDinh.dcqd_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deCuongQuyDinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeCuongQuyDinhExists(deCuongQuyDinh.dcqd_id))
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
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "mahp", deCuongQuyDinh.mahp);
            ViewData["maqd"] = new SelectList(_context.Quydinh_Kiemtras, "maqd", "maqd", deCuongQuyDinh.maqd);
            return View(deCuongQuyDinh);
        }

        // GET: DeCuongQuyDinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongQuyDinh = await _context.DeCuongQuyDinhs
                .Include(d => d.DeCuongchiTiet)
                .Include(d => d.Quydinh_Kiemtra)
                .FirstOrDefaultAsync(m => m.dcqd_id == id);
            if (deCuongQuyDinh == null)
            {
                return NotFound();
            }

            return View(deCuongQuyDinh);
        }

        // POST: DeCuongQuyDinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deCuongQuyDinh = await _context.DeCuongQuyDinhs.FindAsync(id);
            _context.DeCuongQuyDinhs.Remove(deCuongQuyDinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeCuongQuyDinhExists(int id)
        {
            return _context.DeCuongQuyDinhs.Any(e => e.dcqd_id == id);
        }
    }
}
