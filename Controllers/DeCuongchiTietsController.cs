using System.Runtime.Intrinsics.X86;
using System.Net.Cache;
using System.Net.Mail;
using System.Reflection.PortableExecutable;
using System.Net.Http;
using System.Net;
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
            // HttpContext.Session.Remove("idDecuong");
            // HttpContext.Session.Remove("nameDecuong");
             //HttpContext.Session.Clear();
            var appDbContext = _context.DeCuongchiTiets
            .Include(d => d.Khoikienthuc)
            .Include(d => d.DeCuongNhiemvus);
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
        public IActionResult Create(int id, int mamuctieu, int machitietmonhoc, int machitietchuong, int maphutrach, int mathoigianhoc, int machuandaura, int maclpo, int macloppday, int maclopphoc, int matailieu)
        {   
            HttpContext.Session.SetInt32("id_edit_componet", id);
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
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs.Where(m=> m.mahp ==  HttpContext.Session.GetInt32("idDecuong")), "macdmon", "chisocio");
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "chisoplo");
            ViewData["mapphoc"] = new SelectList(_context.Phuongphap_Hocs, "mapphoc", "tenpp");
            ViewData["mappday"] = new SelectList(_context.Phuongphap_Giangdays, "mappday", "tenpp");
            HttpContext.Session.SetInt32("MaMuctieu",mamuctieu);
            HttpContext.Session.SetInt32("MaChitietmonhoc", machitietmonhoc);
            HttpContext.Session.SetInt32("MaChitietchuong", machitietchuong);
            HttpContext.Session.SetInt32("MaPhutrach", maphutrach);
            HttpContext.Session.SetInt32("MaThoigianhoc", mathoigianhoc);
            HttpContext.Session.SetInt32("MaChuandaura", machuandaura);
            HttpContext.Session.SetInt32("MaClpo", maclpo);
            HttpContext.Session.SetInt32("MaClo_pphoc", maclopphoc);
            HttpContext.Session.SetInt32("MaClo_ppday", macloppday);
            HttpContext.Session.SetInt32("MaTailieu", matailieu);
            return View();
        }

        // POST: DeCuongchiTiets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("mahp,mahp_decuong,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt,hp_tienquyet,yeucau_hocphan")] DeCuongchiTiet deCuongchiTiet, int current = 1)
        {
            if (ModelState.IsValid)
            {
                // HttpContext.Session.Remove("idDecuong");
                // HttpContext.Session.Remove("nameDecuong");
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
        public async Task<IActionResult> Edit(int id, int mamuctieu, int machitietmonhoc, int machitietchuong, int maphutrach, int mathoigianhoc, int machuandaura, int maclpo, int macloppday, int maclopphoc, int matailieu)
        {
            HttpContext.Session.SetInt32("id_edit_dccht", id );
            // ViewData["name_dccht"] =  _context.DeCuongchiTiets.Where(m=> m.mahp == id).Select(z => z.tenhp_tviet);
            TempData["id_edit_dc"] = id ;
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            ViewData["mahp"] = new SelectList(_context.DeCuongchiTiets, "mahp", "tenhp_tviet");
            ViewData["manv"] = new SelectList(_context.NhiemvuSVs, "manv", "noidung");
            ViewData["maqd"] = new SelectList(_context.Quydinh_Kiemtras, "maqd", "tenqd");
            ViewData["mahtdg"] = new SelectList(_context.Hinhthuc_Danhgias, "mahtdg", "hinhthuc");
            ViewData["magv"] = new SelectList(_context.GiangViens, "magv", "hoten");
            ViewData["makh"] = new SelectList(_context.Khoahocs, "makh", "tenkh");
            ViewData["mahk"] = new SelectList(_context.Hockys, "mahk", "tenhk");
            ViewData["matl"] = new SelectList(_context.Tailieus, "matl", "tentailieu");
            ViewData["mact"] = new SelectList(_context.Chitietmonhocs.Where(m=> m.mahp ==  HttpContext.Session.GetInt32("id_edit_dccht_after")), "mact", "tenchuong");
            ViewData["macdmon"] = new SelectList(_context.Chuandaura_Monhocs.Where(m=> m.mahp ==  HttpContext.Session.GetInt32("id_edit_dccht_after")), "macdmon", "chisocio");
            ViewData["maplo"] = new SelectList(_context.PLOs, "maplo", "chisoplo");
            ViewData["mapphoc"] = new SelectList(_context.Phuongphap_Hocs, "mapphoc", "tenpp");
            ViewData["mappday"] = new SelectList(_context.Phuongphap_Giangdays, "mappday", "tenpp");
            HttpContext.Session.SetInt32("MaMuctieu",mamuctieu);
            HttpContext.Session.SetInt32("MaChitietmonhoc", machitietmonhoc);
            HttpContext.Session.SetInt32("MaChitietchuong", machitietchuong);
            HttpContext.Session.SetInt32("MaPhutrach", maphutrach);
            HttpContext.Session.SetInt32("MaThoigianhoc", mathoigianhoc);
            HttpContext.Session.SetInt32("MaChuandaura", machuandaura);
            HttpContext.Session.SetInt32("MaClpo", maclpo);
            HttpContext.Session.SetInt32("MaClo_pphoc", maclopphoc);
            HttpContext.Session.SetInt32("MaClo_ppday", macloppday);
            HttpContext.Session.SetInt32("MaTailieu", matailieu);
            return View();
        }

        public async Task<IActionResult> Edit_copy(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuandaura_monhoc = await _context.DeCuongchiTiets.FindAsync(id);
            if (chuandaura_monhoc == null)
            {
                return NotFound();
            }
            ViewData["makkt"] = new SelectList(_context.Khoikienthucs, "makkt", "kkt_ten");
            return View(chuandaura_monhoc);
            //return View();
        }

        // POST: DeCuongchiTiets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("mahp,mahp_decuong,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt,hp_tienquyet,makkt,yeucau_hocphan")] DeCuongchiTiet deCuongchiTiet)
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
                HttpContext.Session.SetInt32("id_edit_dccht_after", deCuongchiTiet.mahp);
                return RedirectToAction("Edit");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit_copy(int id, [Bind("mahp,mahp_decuong,tenhp_tviet,tenhp_tanh,sotc_lt,sotc_th,yeucaukhacvoi_hocphan,tomtat_noidunghocphan,makkt,hp_tienquyet,yeucau_hocphan")] DeCuongchiTiet deCuongchiTiet)
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
                // HttpContext.Session.SetInt32("id_edit_dccht_after", deCuongchiTiet.mahp);
                // return RedirectToAction("Edit");
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
        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deCuongchiTiet = await _context.DeCuongchiTiets.FindAsync(id);
            _context.DeCuongchiTiets.Remove(deCuongchiTiet);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
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
        public async Task<IActionResult> DeleteMucTieuEdit(int id)
        {
            var muctieu = await _context.Muctieus.FindAsync(id);
            _context.Muctieus.Remove(muctieu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
        }
        //cretae-muctieu
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
                HttpContext.Session.Remove("MaMuctieu");  
                return RedirectToAction("Create");                                                        
                
            }
            return View(muctieu);
        } 
        //edit-muctieu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit_Muctieu([Bind("mamt,noidung,mtchinh,mtphu,mahp")] Muctieu muctieu)
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
                    await _context.SaveChangesAsync();
                    HttpContext.Session.Remove("MaMuctieu");  
                    return RedirectToAction("Edit");

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
        //decuongnhiemvu-edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditListNV(int[] arrayDCNV)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCNV)
                {
                    
                    var DCNV = new DeCuongNhiemvu();
                    DCNV.mahp = (int)TempData["id_dc_after"];
                    DCNV.manv = item; 
                    _context.Add(DCNV); 
                    await _context.SaveChangesAsync();
                }
                     return RedirectToAction("Edit");
                
            }
            return View();
        }
  
        public async Task<IActionResult> DeleteNhiemvu(int id)
        {
             var deCuongNhiemvu = await _context.DeCuongNhiemvus.FindAsync(id);
            _context.DeCuongNhiemvus.Remove(deCuongNhiemvu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        public async Task<IActionResult> DeleteNhiemvuEdit(int id)
        {
             var deCuongNhiemvu = await _context.DeCuongNhiemvus.FindAsync(id);
            _context.DeCuongNhiemvus.Remove(deCuongNhiemvu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        //edit_quydinh
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditListQD(int[] arrayDCQD )
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCQD)
                {
                    
                    var DCQD = new DeCuongQuyDinh();
                    DCQD.mahp = (int)TempData["id_dc_after"];
                    DCQD.maqd = item; 
                    _context.Add(DCQD); 
                    await _context.SaveChangesAsync();
                }
                     return RedirectToAction("Edit");
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
        public async Task<IActionResult> DeleteQuydinhEdit(int? id)
        {
             var decuongquydinh = await _context.DeCuongQuyDinhs.FindAsync(id);
            _context.DeCuongQuyDinhs.Remove(decuongquydinh);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
        }
        //CreateDecuonghinhthuc
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        //edit_decuonghinhthuc
        [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task<IActionResult> EditListHT(int[] arrayDCHT)
        {
            if (ModelState.IsValid)
            {
                foreach(var item in arrayDCHT)
                {
                    
                    var DCHT = new DeCuongHinhthuc();
                    DCHT.mahp = (int)TempData["id_dc_after"];
                    DCHT.mahtdg = item; 
                    _context.Add(DCHT); 
                    await _context.SaveChangesAsync();
                }

                    return RedirectToAction("Edit");
            }
            return View();
        }
        //delete_decuonghinhthuc
        public async Task<IActionResult> DeleteHinhthuc(int? id)
        {
             var deCuongHinhthuc = await _context.DeCuongHinhthucs.FindAsync(id);
            _context.DeCuongHinhthucs.Remove(deCuongHinhthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        public async Task<IActionResult> DeleteHinhthucEdit(int? id)
        {
             var deCuongHinhthuc = await _context.DeCuongHinhthucs.FindAsync(id);
            _context.DeCuongHinhthucs.Remove(deCuongHinhthuc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
        }
        //CreateDecuongtailieu
         public IActionResult _Partial_decuongtailieu()
        {
            
            return PartialView("_Partial_decuongtailieu");
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
                HttpContext.Session.SetInt32("id_Chitietmonhoc", chitietmonhoc.mact);   
                HttpContext.Session.Remove("MaChitietmonhoc");                                                                       
                return RedirectToAction("Create");
          
            }
            return View(chitietmonhoc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditChitietmonhoc([Bind("mact,chiso,tenchuong,tietlt,tietth,mahp")] Chitietmonhoc chitietmonhoc)
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
                HttpContext.Session.Remove("MaChitietmonhoc");                                                               
                return RedirectToAction("Edit");
          
            }
            return View(chitietmonhoc);
        }
        //Edit_chitietmonhoc
        //delete-chitietmonhoc
        public async Task<IActionResult> DeleteChitietmonhoc(int? id)
        {
             var chitietmonhoc = await _context.Chitietmonhocs.FindAsync(id);
            _context.Chitietmonhocs.Remove(chitietmonhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
         public async Task<IActionResult> DeleteChitietmonhocEdit(int? id)
        {
             var chitietmonhoc = await _context.Chitietmonhocs.FindAsync(id);
            _context.Chitietmonhocs.Remove(chitietmonhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
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
                HttpContext.Session.Remove("MaChitietchuong");
                    return RedirectToAction("Create");
            }
            return View(chitiet_Chuong);
        }
        //EditChitietchuong
         public async Task<IActionResult> EditChitietchuong([Bind("mactchuong,chiso,tentieumuc,tuanhoc,thoiluonghoc,mact")] Chitiet_Chuong chitiet_Chuong)
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
                HttpContext.Session.Remove("idChitietchuong");
                    return RedirectToAction("Edit");
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
        public async Task<IActionResult> DeleteChitietchuongEdit(int? id)
        {
             var chitietchuong = await _context.Chitiet_Chuongs.FindAsync(id);
            _context.Chitiet_Chuongs.Remove(chitietchuong);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
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
                HttpContext.Session.Remove("MaPhutrach");
                return RedirectToAction("Create");                                                                            
            }
            return View(phutrach);
        }
        //edit_phutrach
        public async Task<IActionResult> EditPhutrach([Bind("mapt,vaitro,mahp,magv")] Phutrach phutrach)
        {
            if (ModelState.IsValid)
            {
                if(phutrach.mapt ==  0)
                {
                    _context.Add(phutrach);
                }
                else
                {
                    _context.Update(phutrach);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("id_edit_pt");
                return RedirectToAction("Edit");                                                                            
            }
            return View(phutrach);
        }
        //delete-phutrach
         public async Task<IActionResult> DeletePhutrach(int id)
        {
            var phutrach = await _context.Phutrachs.FindAsync(id);
            _context.Phutrachs.Remove(phutrach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeletePhutrach_Edit(int id)
        {
            var phutrach = await _context.Phutrachs.FindAsync(id);
            _context.Phutrachs.Remove(phutrach);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
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
                HttpContext.Session.Remove("MaThoigianhoc"); 
                 return RedirectToAction("Create");                                                                         
            }
            return View(thoigianhoc);
        }
        //editThoigianhoc
        public async Task<IActionResult> EditThoigianhoc([Bind("matg,yeucauhocphan,mahp,makh,mahk")] Thoigianhoc thoigianhoc)
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
                HttpContext.Session.Remove("id_edit_Thoigianhoc");   
                 return RedirectToAction("Edit");                                                                         
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
        public async Task<IActionResult> DeleteThoigianhocEdit(int? id)
        {
             var thoigianhoc = await _context.Thoigianhocs.FindAsync(id);
            _context.Thoigianhocs.Remove(thoigianhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
        }
        //CreateChuandauramonhoc
        public async Task<IActionResult> CreateChuandauramonhoc([Bind("macdmon,chisocio,noidung,loai,mahp")] Chuandaura_monhoc chuandaura_monhoc)
        {
            if (ModelState.IsValid)
            {
                
                if(chuandaura_monhoc.macdmon <= 0)
                {
                    _context.Add(chuandaura_monhoc);
                }
                else
                {
                    _context.Update(chuandaura_monhoc);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("MaChuandaura");   
                return RedirectToAction("Create");   
            }
            return View(chuandaura_monhoc);
        }
        //CreateChuandauramonhoc
        public async Task<IActionResult> EditChuandauramonhoc([Bind("macdmon,chisocio,noidung,loai,mahp")] Chuandaura_monhoc chuandaura_monhoc)
        {
            if (ModelState.IsValid)
            {
                
                if(chuandaura_monhoc.macdmon <= 0)
                {
                    _context.Add(chuandaura_monhoc);
                }
                else
                {
                    _context.Update(chuandaura_monhoc);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("id_edit_cdrmh");   
                return RedirectToAction("Edit");   
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
        public async Task<IActionResult> DeleteChuandauramonhocEdit(int? id)
        {
             var chuandaura_monhoc = await _context.Chuandaura_Monhocs.FindAsync(id);
            _context.Chuandaura_Monhocs.Remove(chuandaura_monhoc);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
        }
        //Create_ClPO
        public async Task<IActionResult> CreateCLPO([Bind("maclpo,ngayupdate,macdmon,maplo")] CLPO cLPO)
        {
            if (ModelState.IsValid)
            {
                if(cLPO.maclpo <= 0)
                {
                    _context.Add(cLPO);
                }
                else
                {
                    _context.Update(cLPO);
                }
                await _context.SaveChangesAsync();
                 HttpContext.Session.Remove("MaClpo"); 
                return RedirectToAction("Create");
            }
            return View(cLPO);
        }
        //edit
        public async Task<IActionResult> EditCLPO([Bind("maclpo,ngayupdate,macdmon,maplo")] CLPO cLPO)
        {
            if (ModelState.IsValid)
            {
                if(cLPO.maclpo <= 0)
                {
                    _context.Add(cLPO);
                }
                else
                {
                    _context.Update(cLPO);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit");
            }
            return View(cLPO);
        }
        //deleteplo
        public async Task<IActionResult> DeleteCLPO(int? id)
        {
             var cLPO = await _context.CLPOs.FindAsync(id);
            _context.CLPOs.Remove(cLPO);
            await _context.SaveChangesAsync();
             return RedirectToAction("Create");
        }
        public async Task<IActionResult> DeleteCLPOEdit(int? id)
        {
             var cLPO = await _context.CLPOs.FindAsync(id);
            _context.CLPOs.Remove(cLPO);
            await _context.SaveChangesAsync();
             return RedirectToAction("Edit");
        }
        //createpphoc
        public async Task<IActionResult> CreatePPhoc([Bind("maclopphoc,mucdo,mapphoc,macdmon")] CLOPhuongphaphoc cLOPhuongphaphoc)
        {
            if (ModelState.IsValid)
            {
                if(cLOPhuongphaphoc.maclopphoc <= 0)
                {
                    _context.Add(cLOPhuongphaphoc);
                }
                else
                {
                    _context.Update(cLOPhuongphaphoc);
                }
                await _context.SaveChangesAsync();
                  HttpContext.Session.Remove("MaClo_pphoc"); 
                return RedirectToAction("Create");
            }
            return View();
        }
        //createpphoc
        public async Task<IActionResult> EditPPhoc([Bind("maclopphoc,mucdo,mapphoc,macdmon")] CLOPhuongphaphoc cLOPhuongphaphoc)
        {
            if (ModelState.IsValid)
            {
                if(cLOPhuongphaphoc.maclopphoc <= 0)
                {
                    _context.Add(cLOPhuongphaphoc);
                }
                else
                {
                    _context.Update(cLOPhuongphaphoc);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit");
            }
            return View(cLOPhuongphaphoc);
        }
        //delete-pphoc
        public async Task<IActionResult> DeleteClopphoc(int id)
        {
            var cLOPhuongphaphoc = await _context.CLOPhuongphaphocs.FindAsync(id);
            _context.CLOPhuongphaphocs.Remove(cLOPhuongphaphoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
         public async Task<IActionResult> DeleteClopphocEdit(int id)
        {
            var cLOPhuongphaphoc = await _context.CLOPhuongphaphocs.FindAsync(id);
            _context.CLOPhuongphaphocs.Remove(cLOPhuongphaphoc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }
        //createppday
        public async Task<IActionResult> CreatePPday([Bind("maloppday,mucdo,mappday,macdmon")] CLOPhuongphapday cLOPhuongphapday)
        {
            if (ModelState.IsValid)
            {
                if(cLOPhuongphapday.maloppday <= 0)
                {
                    _context.Add(cLOPhuongphapday);
                }
                else
                {
                    _context.Update(cLOPhuongphapday);
                }
                await _context.SaveChangesAsync();
                  HttpContext.Session.Remove("MaClo_ppday"); 
                return RedirectToAction("Create");
            }
            return View();
        }
        //editppday
        public async Task<IActionResult> EditPPday([Bind("maloppday,mucdo,mappday,macdmon")] CLOPhuongphapday cLOPhuongphapday)
        {
            if (ModelState.IsValid)
            {
                if(cLOPhuongphapday.maloppday <= 0)
                {
                    _context.Add(cLOPhuongphapday);
                }
                else
                {
                    _context.Update(cLOPhuongphapday);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit");
            }
            return View(cLOPhuongphapday);
        }
        public async Task<IActionResult> DeleteCloppday(int id)
        {
            var cLOPhuongphapday = await _context.CLOPhuongphapdays.FindAsync(id);
            _context.CLOPhuongphapdays.Remove(cLOPhuongphapday);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
        public async Task<IActionResult> DeleteCloppdayEdit(int id)
        {
            var cLOPhuongphapday = await _context.CLOPhuongphapdays.FindAsync(id);
            _context.CLOPhuongphapdays.Remove(cLOPhuongphapday);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit));
        }
        //createTailieu
        public async Task<IActionResult> CreateDecuongtailieu([Bind("dctl_id,mahp,matl")] DecuongTailieu decuongTailieu)
        {
            if (ModelState.IsValid)
            {   decuongTailieu.mahp = (int)TempData["id_dc"];
                if(decuongTailieu.dctl_id <= 0)
                {
                      _context.Add(decuongTailieu);
                }
                else
                {
                      _context.Update(decuongTailieu);
              
                }                   
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Create");
            }
            return View(decuongTailieu);
            
        }
        public async Task<IActionResult> EditDecuongtailieu([Bind("dctl_id,mahp,matl")] DecuongTailieu decuongTailieu)
        {
            if (ModelState.IsValid)
            {   decuongTailieu.mahp = (int)TempData["id_dc_after"];
                if(decuongTailieu.dctl_id <= 0)
                {
                      _context.Add(decuongTailieu);
                }
                else
                {
                      _context.Update(decuongTailieu);
              
                }                   
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Edit");
            }
            return View(decuongTailieu);
            
        }
        //CreateTailieu
        public async Task<IActionResult> CreateTailieu([Bind("matl,tacgia,tentailieu,thongtinkhac,loaitl")] Tailieu tailieu)
        {
             if (ModelState.IsValid)
            {
                if(tailieu.matl <= 0)
                {
                    _context.Add(tailieu);
                }
                else
                {
                    _context.Update(tailieu);
                }
                await _context.SaveChangesAsync();
                HttpContext.Session.Remove("MaTailieu"); 
               return RedirectToAction("Create");
            }
            return View(tailieu);
        }
        public async Task<IActionResult> EditTailieu([Bind("matl,tacgia,tentailieu,thongtinkhac,loaitl")] Tailieu tailieu)
        {
             if (ModelState.IsValid)
            {
                
                if(tailieu.matl <= 0)
                {
                    _context.Add(tailieu);
                }
                else
                {
                    _context.Update(tailieu);
                }
                await _context.SaveChangesAsync();
               return RedirectToAction("Edit");
            }
            return View(tailieu);
        }
        //detele_tailieu
        public async Task<IActionResult> DeleteTailieu(int id)
        {
             var tailieu = await _context.Tailieus.FindAsync(id);
            _context.Tailieus.Remove(tailieu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Create");
        }
        public async Task<IActionResult> DeleteTailieuEdit(int id)
        {
             var tailieu = await _context.Tailieus.FindAsync(id);
            _context.Tailieus.Remove(tailieu);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit");
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
          public async Task<IActionResult> CLO_PLO(int id)
        {   
            var acomptec_lvthainhanContext = _context.CLPOs.Include(c => c.Chuandaura_monhoc).ThenInclude(c => c.DeCuongchiTiet).Include(c => c.PLO).Where(c=> c.Chuandaura_monhoc.mahp == id).OrderBy(c=> c.Chuandaura_monhoc.chisocio).OrderBy(c=> c.PLO.chisoplo);
            // HttpContext.Session.SetString("clpo_name", acomptec_lvthainhanContext.DeCuongchiTiet.tenhp_tviet);
             return View(await acomptec_lvthainhanContext.ToListAsync());
        }
    }
}
