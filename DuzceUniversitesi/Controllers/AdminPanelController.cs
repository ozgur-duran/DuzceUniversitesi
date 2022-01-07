using DuzceUniversitesi_DataAccess.Data;
using DuzceUniversitesi_Model.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUniversitesi.Controllers
{
    public class AdminPanelController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminPanelController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Duyuru> objlist = _db.Duyurular.ToList();
            return View(objlist);
        }
        
        public ActionResult GetirDuyuru(int id)
        {
            var ag = _db.Duyurular.Find(id);
            return View("GetirDuyuru", ag);
        }
        public ActionResult DuyuruGuncelle(Duyuru x)
        {
            var ag = _db.Duyurular.Find(x.DuyuruId);
            ag.DuyuruKonu = x.DuyuruKonu;
            ag.DuyuruAçıklama = x.DuyuruAçıklama;
            ag.DuyuruOlusturulmaTarihi = x.DuyuruOlusturulmaTarihi;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YeniDuyuru()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDuyuru(Duyuru x)
        {
            _db.Duyurular.Add(x);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SilDuyuru(int id)
        {
            var ag = _db.Duyurular.Find(id);
            _db.Duyurular.Remove(ag);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // AKADEMİK PERSONEL İŞLEMLERİ
        public ActionResult AkademikPersonelListesi()
        {
            List<AkademikPersonel> objlist = _db.AkademikPersoneller.ToList();
            return View(objlist);
        }
        
        public ActionResult GetirPersonel(int id)
        {
            var ag = _db.AkademikPersoneller.Find(id);
            return View("GetirPersonel", ag);
        }
        public ActionResult PersonelGuncelle(AkademikPersonel x)
        {
            var ag = _db.AkademikPersoneller.Find(x.AkademikPersonelId);
            ag.AkademikPersonelAdSoyad = x.AkademikPersonelAdSoyad;
            ag.AkademikPersonelDersler = x.AkademikPersonelDersler;
            ag.AkademikPersonelDogumTarihi = x.AkademikPersonelDogumTarihi;
            ag.AkademikPersonelMail = x.AkademikPersonelMail;
            ag.AkademikPersonelGorsel = x.AkademikPersonelGorsel;
            _db.SaveChanges();
            return RedirectToAction("AkademikPersonelListesi");

        }
        [HttpGet]
        public ActionResult YeniPersonel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniPersonel(AkademikPersonel x)
        {
            _db.AkademikPersoneller.Add(x);
            _db.SaveChanges();
            return RedirectToAction("AkademikPersonelListesi");
        }
        public ActionResult SilPersonel(int id)
        {
            var ag = _db.AkademikPersoneller.Find(id);
            _db.AkademikPersoneller.Remove(ag);
            _db.SaveChanges();
            return RedirectToAction("AkademikPersonelListesi");

        }

        //FAKÜLTE İŞLEMLERİ
        public ActionResult FakulteListesi()
        {
            List<Fakulte> objlist = _db.Fakulteler.ToList();
            return View(objlist);
        }
        public ActionResult GetirFakulte(int id)
        {
            var ag = _db.Fakulteler.Find(id);
            return View("GetirFakulte", ag);
        }
        public ActionResult FakulteGuncelle (Fakulte x)
        {
            var ag = _db.Fakulteler.Find(x.FakulteId);
            ag.FakulteAd = x.FakulteAd;
            _db.SaveChanges();
            return RedirectToAction("FakulteListesi");

        }
        [HttpGet]
        public ActionResult YeniFakulte()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniFakulte(Fakulte x)
        {
            _db.Fakulteler.Add(x);
            _db.SaveChanges();
            return RedirectToAction("FakulteListesi");
        }
        public ActionResult SilFakulte(int id)
        {
            var ag = _db.Fakulteler.Find(id);
            _db.Fakulteler.Remove(ag);
            _db.SaveChanges();
            return RedirectToAction("FakulteListesi");
        }


    }
}
