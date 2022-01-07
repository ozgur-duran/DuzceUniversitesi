using DuzceUniversitesi_DataAccess.Data;
using DuzceUniversitesi_Model.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DuzceUniversitesi.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            var info = _db.Adminler.FirstOrDefault(x => x.AdminKullaniciAdi == admin.AdminKullaniciAdi && x.AdminSifre == admin.AdminSifre);
            if (info != null)
            {
                return RedirectToAction("Index", "AdminPanel");
            }
            else
            {

            }
            return View();
            
        }
    }
}
