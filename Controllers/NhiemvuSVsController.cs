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
    public class NhiemvuSVsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public NhiemvuSVsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: NhiemvuSVs
        public async Task<IActionResult> Index()
        {
            return View(await _context.NhiemvuSVs.ToListAsync());
        }

        // GET: NhiemvuSVs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhiemvuSV = await _context.NhiemvuSVs
                .FirstOrDefaultAsync(m => m.manv == id);
            if (nhiemvuSV == null)
            {
                return NotFound();
            }

            return View(nhiemvuSV);
        }

        // GET: NhiemvuSVs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NhiemvuSVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("manv,noidung")] NhiemvuSV nhiemvuSV)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nhiemvuSV);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nhiemvuSV);
        }

        // GET: NhiemvuSVs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhiemvuSV = await _context.NhiemvuSVs.FindAsync(id);
            if (nhiemvuSV == null)
            {
                return NotFound();
            }
            return View(nhiemvuSV);
        }

        // POST: NhiemvuSVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("manv,noidung")] NhiemvuSV nhiemvuSV)
        {
            if (id != nhiemvuSV.manv)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nhiemvuSV);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NhiemvuSVExists(nhiemvuSV.manv))
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
            return View(nhiemvuSV);
        }

        // GET: NhiemvuSVs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhiemvuSV = await _context.NhiemvuSVs
                .FirstOrDefaultAsync(m => m.manv == id);
            if (nhiemvuSV == null)
            {
                return NotFound();
            }

            return View(nhiemvuSV);
        }

        // POST: NhiemvuSVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nhiemvuSV = await _context.NhiemvuSVs.FindAsync(id);
            _context.NhiemvuSVs.Remove(nhiemvuSV);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NhiemvuSVExists(int id)
        {
            return _context.NhiemvuSVs.Any(e => e.manv == id);
        }
    }
}
