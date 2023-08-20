using DuWebsite1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Controllers
{
    public class AdminController : Controller
    {
        EFAdminRepository websiteRepository = new EFAdminRepository(new DuDbContext());

        public IActionResult Index(int id)
        {

            var user = websiteRepository.Kullanıcılar.FirstOrDefault(x => x.AdminId == id);

            return View(user);
        }

        public ActionResult DuyuruEdit()
        {
            var Duyurular = websiteRepository.Duyurular;

            return View(Duyurular);
        }
        public ActionResult DuyuruDelete(int id)
        {
            var duyuru = websiteRepository.IdyegoreDuyuru(id);
            websiteRepository.DuyuruSil(duyuru);
            return RedirectToAction("DuyuruEdit");
        }


        [HttpGet("/Admin/DuyuruUpdate/{duyuruId}")]
        //[HttpGet]
        public ActionResult DuyuruUpdate(int duyuruId)
        {
            var duyuru = websiteRepository.IdyegoreDuyuru(duyuruId);


            return View(duyuru);

            //return RedirectToAction("Duyuru/DuyuruUpdate");
        }

        [HttpPost]
        public ActionResult DuyuruUpdate(Duyuru duyuru)
        {

            websiteRepository.DuyuruGüncelle(duyuru);

            return RedirectToAction("DuyuruEdit");

            //return RedirectToAction("Duyuru/DuyuruUpdate");
        }

        [HttpPost]
        public ActionResult DuyuruEkler(Duyuru Duyuru)
        {
            websiteRepository.DuyuruEkle(Duyuru);
            return RedirectToAction("DuyuruEdit");

        }

        [HttpGet]
        public ActionResult DuyuruEkler(int Id)
        {
            var duyuru = websiteRepository.IdyegoreDuyuru(Id);
            return View();
        }

       
        public ActionResult KullaniciEkle()
        {
            return View();

        }
        [HttpPost]
        public ActionResult KullaniciEkle(Admin admin)
        {
            websiteRepository.UserEkle(admin);
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult Control (Admin admin)
        {
            var result1 = websiteRepository.Kullanıcılar.Where(x => x.KullaniciAdi == admin.KullaniciAdi).Any();
            var result2 = websiteRepository.Kullanıcılar.Where(x => x.Sifre == admin.Sifre).Any();

            if (result1 && result2 == true)
            {
                return RedirectToAction("DuyuruEdit");
            }
            else
                return View();
            
        }

        



    }
}
