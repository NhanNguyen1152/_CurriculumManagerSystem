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
    public class Chuongtrinh_DaotaosController : Controller
    {
        private readonly acomptec_lvthainhanContext _context;

        public Chuongtrinh_DaotaosController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: Chuongtrinh_Daotaos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Chuongtrinh_Daotaos.ToListAsync());
        }

        // GET: Chuongtrinh_Daotaos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos
                .FirstOrDefaultAsync(m => m.ma_ctdt == id);
            if (chuongtrinh_Daotao == null)
            {
                return NotFound();
            }

            return View(chuongtrinh_Daotao);
        }

        // GET: Chuongtrinh_Daotaos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Chuongtrinh_Daotaos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ma_ctdt,nganh_daotao,trinhdo_daotao,loaihinh_daotao,thoigian_daotao,tenvanbang,noidaotao")] Chuongtrinh_Daotao chuongtrinh_Daotao)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuongtrinh_Daotao);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuongtrinh_Daotao);
        }

        // GET: Chuongtrinh_Daotaos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos.FindAsync(id);
            if (chuongtrinh_Daotao == null)
            {
                return NotFound();
            }
            return View(chuongtrinh_Daotao);
        }

        // POST: Chuongtrinh_Daotaos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ma_ctdt,nganh_daotao,trinhdo_daotao,loaihinh_daotao,thoigian_daotao,tenvanbang,noidaotao")] Chuongtrinh_Daotao chuongtrinh_Daotao)
        {
            if (id != chuongtrinh_Daotao.ma_ctdt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuongtrinh_Daotao);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Chuongtrinh_DaotaoExists(chuongtrinh_Daotao.ma_ctdt))
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
            return View(chuongtrinh_Daotao);
        }

        // GET: Chuongtrinh_Daotaos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos
                .FirstOrDefaultAsync(m => m.ma_ctdt == id);
            if (chuongtrinh_Daotao == null)
            {
                return NotFound();
            }

            return View(chuongtrinh_Daotao);
        }

        // POST: Chuongtrinh_Daotaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chuongtrinh_Daotao = await _context.Chuongtrinh_Daotaos.FindAsync(id);
            _context.Chuongtrinh_Daotaos.Remove(chuongtrinh_Daotao);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Chuongtrinh_DaotaoExists(int id)
        {
            return _context.Chuongtrinh_Daotaos.Any(e => e.ma_ctdt == id);
        }
    }
}
