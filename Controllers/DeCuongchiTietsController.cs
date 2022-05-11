using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _CurriculumManagerSystem.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace _CurriculumManagerSystem.Controllers
{
    public class DeCuongchiTietsController : Controller
    {
        
        private readonly acomptec_lvthainhanContext _context;

        public DeCuongchiTietsController(acomptec_lvthainhanContext context)
        {
            _context = context;
        }

        // GET: DeCuongchiTiets
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc).Include(d => d.DeCuongNhiemvus);
            return View(await appDbContext.ToListAsync());
        }

        // GET: DeCuongchiTiets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets
                .FirstOrDefaultAsync(m => m.mahp == id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }

            return View(deCuongchiTiet);
        }
        
        int currentTab = 1;

        // GET: DeCuongchiTiets/Create
        public IActionResult Create(int id)
        {
            ViewBag.param = currentTab;
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            ViewData["manv"] = new SelectList(_context.NhiemvuSVs, "manv", "noidung");
            ViewData["maqd"] = new SelectList(_context.Quydinh_Kiemtras, "maqd", "tenqd");
            ViewData["mahtdg"] = new SelectList(_context.Hinhthuc_Danhgias, "mahtdg", "hinhthuc");
            ViewData["magv"] = new SelectList(_context.GiangViens, "magv", "hoten");
            ViewData["makh"] = new SelectList(_context.Khoahocs, "makh", "tenkh");
            ViewData["mahk"] = new SelectList(_context.Hockys, "mahk", "tenhk");
            if(id > 0)
            {
                HttpContext.Session.SetInt32("idMuctieu",id);
            }
            return View();
        }

        // POST: DeCuongchiTiets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mahp,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt")] DeCuongchiTiet deCuongchiTiet, int current = 1)
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.Remove("idDecuong");
                HttpContext.Session.Remove("nameDecuong");
                _context.Add(deCuongchiTiet);
                await _context.SaveChangesAsync();
                current++;
                currentTab = current;
                HttpContext.Session.SetInt32("idDecuong", deCuongchiTiet.mahp);
                HttpContext.Session.SetString("nameDecuong", deCuongchiTiet.tenhp_tviet);
                return RedirectToAction("Create");
                //return RedirectToAction("Index", new RouteValueDictionary( new { Controller = "Decuongchitiets", Action = "Create", id = deCuongchiTiet.mahp }));
            }
            return View(deCuongchiTiet);
        }

        // GET: DeCuongchiTiets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets.FindAsync(id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            return View(deCuongchiTiet);
        }

        // POST: DeCuongchiTiets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mahp,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt")] DeCuongchiTiet deCuongchiTiet)
        {
            if (id != deCuongchiTiet.mahp)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deCuongchiTiet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeCuongchiTietExists(deCuongchiTiet.mahp))
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
            return View(deCuongchiTiet);
        }

        // GET: DeCuongchiTiets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deCuongchiTiet = await _context.DeCuongchiTiets
                .FirstOrDefaultAsync(m => m.mahp == id);
            if (deCuongchiTiet == null)
            {
                return NotFound();
            }
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            return View(deCuongchiTiet);
        }

        // POST: DeCuongchiTiets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deCuongchiTiet = await _context.DeCuongchiTiets.FindAsync(id);
            _context.DeCuongchiTiets.Remove(deCuongchiTiet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeCuongchiTietExists(int id)
        {
            return _context.DeCuongchiTiets.Any(e => e.mahp == id);
        }
         //Create Edit muctieu

        // public async Task<IActionResult> getMucTieu() 
        // {
        //     var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc).Include(d => d.Muctieus).Include(d => d.Phutraches);
        //     return View(await appDbContext.ToListAsync());
        // }

        // public IActionResult _Partial_muctieu()
        // { 
           
        //     return PartialView("_Partial_muctieu");
        // }                             
       public async Task<IActionResult> DeleteMucTieu(int id)
        {
            var muctieu = await _context.Muctieus.FindAsync(id);
            _context.Muctieus.Remove(muctieu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MultiAction([Bind("mamt,noidung,mtchinh,mtphu,mahp")] Muctieu muctieu)
        {
            if (ModelState.IsValid)
            {
                if(muctieu.mamt <= 0)
                {
                    _context.Add(muctieu);
                }
                else
                {
                    _context.Update(muctieu);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("idMuctieu");                                                                            
                return RedirectToAction("Create");
            }
            return View(muctieu);
        }   

        //Decuongnhiemvu-create
         public IActionResult _Partial_decuongnhiemvu()
        {
            
            return PartialView("_Partial_decuongnhiemvu");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDecuongnhiemvu([Bind("dcnv_id,mahp,manv")] DeCuongNhiemvu deCuongNhiemvu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongNhiemvu);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            
            return View(deCuongNhiemvu);
        }
        //Decuongquydinh-create
         public IActionResult _Partial_decuongquydinh()
        {
            
            return PartialView("_Partial_decuongquydinh");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDecuongquydinh([Bind("dcqd_id,mahp,maqd")] DeCuongQuyDinh deCuongQuyDinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongQuyDinh);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            
            return View(deCuongQuyDinh);
        }
        //CreateDecuonghinhthuc
         public IActionResult _Partial_decuonghinhthuc()
        {
            
            return PartialView("_Partial_decuonghinhthuc");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDecuonghinhthuc([Bind("dcht_id,mahp,mahtdg")] DeCuongHinhthuc deCuongHinhthuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deCuongHinhthuc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            
            return View(deCuongHinhthuc);
        }
        //CreateDecuongtailieu
         public IActionResult _Partial_decuongtailieu()
        {
            
            return PartialView("_Partial_decuongtailieu");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDecuongtailieu([Bind("matl,tacgia,tentailieu,thongtinkhac,loaitl")] Tailieu tailieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tailieu);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(tailieu);
        }
        //CreateChitietmonhoc
        public IActionResult _Partial_chitietmonhoc()
        {
            
            return PartialView("_Partial_chitietmonhoc");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateChitietmonhoc([Bind("mact,chiso,tenchuong,tietlt,tietth,mahp")] Chitietmonhoc chitietmonhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chitietmonhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(chitietmonhoc);
        }
        //CreatePhutrach
        public IActionResult _Partial_phutrach()
        {
            
            return PartialView("_Partial_phutrach");
        }
        public async Task<IActionResult> CreatePhutrach([Bind("mapt,vaitro,mahp,magv")] Phutrach phutrach)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phutrach);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(phutrach);
        }
        //CreateThoigianhoc
        public IActionResult _Partial_thoigianhoc()
        {
            
            return PartialView("_Partial_thoigianhoc");
        }
        public async Task<IActionResult> CreateThoigianhoc([Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thoigianhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(thoigianhoc);
        }
        //CreateChuandauramonhoc
        public IActionResult _Partial_chuandauramonhoc()
        {
            
            return PartialView("_Partial_chuandauramonhoc");
        }
        public async Task<IActionResult> CreateChuandauramonhoc([Bind("macdmon,chisocio,noidung,loai,mahp")] Chuandaura_monhoc chuandaura_monhoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuandaura_monhoc);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(chuandaura_monhoc);
        }
    }
}
