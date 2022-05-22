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
            HttpContext.Session.Remove("idDecuong");
            HttpContext.Session.Remove("nameDecuong");
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
            ViewData["matl"] = new SelectList(_context.Tailieus, "matl", "tentailieu");
            // ViewData["mact"] = new SelectList(_context.Chitietmonhocs, "mact", "tenchuong");
            ViewData["mact"] = new SelectList(_context.Chitietmonhocs.Where(m=> m.mahp ==  HttpContext.Session.GetInt32("idDecuong")), "mact", "tenchuong");

            if(id > 0)
            {
                HttpContext.Session.SetInt32("idMuctieu",id);
                HttpContext.Session.SetInt32("idChitietchuong", id);
                HttpContext.Session.SetInt32("idPhutrach", id);
                HttpContext.Session.SetInt32("idThoigianhoc", id);
            }
            return View();
        }

        // POST: DeCuongchiTiets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mahp,mahp_decuong,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt,hp_tienquyet")] DeCuongchiTiet deCuongchiTiet, int current = 1)
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
                TempData["id_dc"] = deCuongchiTiet.mahp;
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
        public async Task<IActionResult> Edit(int id, [Bind("mahp,mahp_decuong,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt,hp_tienquyet")] DeCuongchiTiet deCuongchiTiet)
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> createListNV(int[] arrayDCNV)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCNV)
                {
                    
                    var DCNV = new DeCuongNhiemvu();
                    DCNV.mahp = (int)TempData["id_dc"];
                    DCNV.manv = item; 
                    _context.Add(DCNV); 
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Create");
            }
            return View();
        }
        public async Task<IActionResult> DeleteNhiemvu(int? id)
        {
             var deCuongNhiemvu = await _context.DeCuongNhiemvus.FindAsync(id);
            _context.DeCuongNhiemvus.Remove(deCuongNhiemvu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        // public async Task<IActionResult> CreateDecuongnhiemvu([Bind("dcnv_id,mahp,manv")] DeCuongNhiemvu deCuongNhiemvu)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(deCuongNhiemvu);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction("Create");
        //     }
            
        //     return View(deCuongNhiemvu);
        // }
        //Decuongquydinh-create
         public IActionResult _Partial_decuongquydinh()
        {
            
            return PartialView("_Partial_decuongquydinh");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public async Task<IActionResult> CreateDecuongquydinh([Bind("dcqd_id,mahp,maqd")] DeCuongQuyDinh deCuongQuyDinh)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(deCuongQuyDinh);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction("Create");
        //     }
            
        //     return View(deCuongQuyDinh);
        // }
        public async Task<IActionResult> createListQD(int[] arrayDCQD )
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCQD)
                {
                    
                    var DCQD = new DeCuongQuyDinh();
                    DCQD.mahp = (int)TempData["id_dc"];
                    DCQD.maqd = item; 
                    _context.Add(DCQD); 
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Create");
            }
            return View();
        }
        //delete-Quydinh
        public async Task<IActionResult> DeleteQuydinh(int? id)
        {
             var decuongquydinh = await _context.DeCuongQuyDinhs.FindAsync(id);
            _context.DeCuongQuyDinhs.Remove(decuongquydinh);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        //CreateDecuonghinhthuc
         public IActionResult _Partial_decuonghinhthuc()
        {
            
            return PartialView("_Partial_decuonghinhthuc");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        // public async Task<IActionResult> CreateDecuonghinhthuc([Bind("dcht_id,mahp,mahtdg")] DeCuongHinhthuc deCuongHinhthuc)
        // {
        //     if (ModelState.IsValid)
        //     {
        //         _context.Add(deCuongHinhthuc);
        //         await _context.SaveChangesAsync();
        //         return RedirectToAction("Create");
        //     }
            
        //     return View(deCuongHinhthuc);
        // }
         public async Task<IActionResult> createListHT(int[] arrayDCHT)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCHT)
                {
                    
                    var DCHT = new DeCuongHinhthuc();
                    DCHT.mahp = (int)TempData["id_dc"];
                    DCHT.mahtdg = item; 
                    _context.Add(DCHT); 
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Create");
            }
            return View();
        }
        public async Task<IActionResult> DeleteHinhthuc(int? id)
        {
             var deCuongHinhthuc = await _context.DeCuongHinhthucs.FindAsync(id);
            _context.DeCuongHinhthucs.Remove(deCuongHinhthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        //CreateDecuongtailieu
         public IActionResult _Partial_decuongtailieu()
        {
            
            return PartialView("_Partial_decuongtailieu");
        }
        [HttpPost]
         public async Task<IActionResult> CreateDecuongtailieu([Bind("dctl_id,mahp,matl")] DecuongTailieu decuongTailieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(decuongTailieu);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create");
            }
            return View(decuongTailieu);
        }
        //CreateChitietmonhoc-edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateChitietmonhoc([Bind("mact,chiso,tenchuong,tietlt,tietth,mahp")] Chitietmonhoc chitietmonhoc)
        {
            if (ModelState.IsValid)
            {
                if(chitietmonhoc.mact <= 0)
                {
                    _context.Add(chitietmonhoc);
                }
                else
                {
                    _context.Update(chitietmonhoc);
                }
                await _context.SaveChangesAsync();
                // HttpContext.Session.SetInt32("idChitietmonhoc", chitietmonhoc.mact);   
                HttpContext.Session.Remove("idChitietmonhoc");                                                                      
                return RedirectToAction("Create");
            }
            return View(chitietmonhoc);
        }
        //delete-chitietmonhoc
        public async Task<IActionResult> DeleteChitietmonhoc(int? id)
        {
             var chitietmonhoc = await _context.Chitietmonhocs.FindAsync(id);
            _context.Chitietmonhocs.Remove(chitietmonhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        //CreateChitietchuong
         public async Task<IActionResult> CreateChitietchuong([Bind("mactchuong,chiso,tentieumuc,tuanhoc,thoiluonghoc,mact")] Chitiet_Chuong chitiet_Chuong)
        { 
            if (ModelState.IsValid)
            {
                if(chitiet_Chuong.mactchuong <= 0)
                {
                    _context.Add(chitiet_Chuong);
                }
                else
                {
                    _context.Update(chitiet_Chuong);
                }
                await _context.SaveChangesAsync();
                                                                      
                return RedirectToAction("Create");
            }
            return View(chitiet_Chuong);
        }
        //delete-chuong
        public async Task<IActionResult> DeleteChitietchuong(int? id)
        {
             var chitietchuong = await _context.Chitiet_Chuongs.FindAsync(id);
            _context.Chitiet_Chuongs.Remove(chitietchuong);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        //CreatePhutrach
        public async Task<IActionResult> CreatePhutrach([Bind("mapt,vaitro,mahp,magv")] Phutrach phutrach)
        {
            if (ModelState.IsValid)
            {
                if(phutrach.mapt <= 0)
                {
                    _context.Add(phutrach);
                }
                else
                {
                    _context.Update(phutrach);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("idPhutrach");                                                                            
                return RedirectToAction("Create");
            }
            return View(phutrach);
        }
        //CreateThoigianhoc
        public async Task<IActionResult> CreateThoigianhoc([Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
        {
             if (ModelState.IsValid)
            {
                if(thoigianhoc.matg <= 0)
                {
                    _context.Add(thoigianhoc);
                }
                else
                {
                    _context.Update(thoigianhoc);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("idThoigianhoc");                                                                            
                return RedirectToAction("Create");
            }
            return View(thoigianhoc);
        }
        //deleteThoigianhoc
         public async Task<IActionResult> DeleteThoigianhoc(int? id)
        {
             var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            _context.Thoigianhocs.Remove(thoigianhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        //CreateChuandauramonhoc
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
        public async Task<IActionResult> DeleteChuandauramonhoc(int? id)
        {
             var chuandaura_monhoc = await _context.Chuandaura_Monhocs.FindAsync(id);
            _context.Chuandaura_Monhocs.Remove(chuandaura_monhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        //CreateTailieu
        public IActionResult _Partial_tailieu()
        {
            
            return PartialView("_Partial_tailieu");
        }
        public async Task<IActionResult> CreateTailieu([Bind("matl,tacgia,tentailieu,thongtinkhac,loaitl")] Tailieu tailieu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tailieu);
                await _context.SaveChangesAsync();
                TempData["id_tl"] = tailieu.matl;
                return RedirectToAction("Create");
            }
            return View(tailieu);
        }
        

        //Getdecuongchitiet
        public IActionResult getBangtomtatCTDT()
        {
            var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc);
            TempData["listData"] = appDbContext.ToList();
            return View();
        }

        //Get huong dan de cuong chi tiet
        public IActionResult getHuongdanCTDT()
        {
            var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc);
            TempData["listData"] = appDbContext.ToList();
            return View();
        }
        //Get Noi dung chuong trinh dao tao
        public IActionResult getNoidungCTDT()
        {
            var appDbContext = _context.DeCuongchiTiets.Include(d => d.Khoikienthuc);
            TempData["listData"] = appDbContext.ToList();
            return View();
        }
    }
}
