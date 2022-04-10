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
    public class Chitiet_ChuongsController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Chitiet_ChuongsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Chitiet_Chuongs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chitiet_Chuongs.ToListAsync());
        }

        // GET: Chitiet_Chuongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiet_Chuong = await _context.Chitiet_Chuongs
                .FirstOrDefaultAsync(m => m.mactchuong == id);
            if (chitiet_Chuong == null)
            {
                return NotFound();
            }

            return View(chitiet_Chuong);
        }

        // GET: Chitiet_Chuongs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chitiet_Chuongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mactchuong,chiso,tentieumuc,tuanhoc,thoiluonghoc,mact")] Chitiet_Chuong chitiet_Chuong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitiet_Chuong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chitiet_Chuong);
        }

        // GET: Chitiet_Chuongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiet_Chuong = await _context.Chitiet_Chuongs.FindAsync(id);
            if (chitiet_Chuong == null)
            {
                return NotFound();
            }
            return View(chitiet_Chuong);
        }

        // POST: Chitiet_Chuongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mactchuong,chiso,tentieumuc,tuanhoc,thoiluonghoc,mact")] Chitiet_Chuong chitiet_Chuong)
        {
            if (id != chitiet_Chuong.mactchuong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chitiet_Chuong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Chitiet_ChuongExists(chitiet_Chuong.mactchuong))
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
            return View(chitiet_Chuong);
        }

        // GET: Chitiet_Chuongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chitiet_Chuong = await _context.Chitiet_Chuongs
                .FirstOrDefaultAsync(m => m.mactchuong == id);
            if (chitiet_Chuong == null)
            {
                return NotFound();
            }

            return View(chitiet_Chuong);
        }

        // POST: Chitiet_Chuongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chitiet_Chuong = await _context.Chitiet_Chuongs.FindAsync(id);
            _context.Chitiet_Chuongs.Remove(chitiet_Chuong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Chitiet_ChuongExists(int id)
        {
            return _context.Chitiet_Chuongs.Any(e => e.mactchuong == id);
        }
    }
}
