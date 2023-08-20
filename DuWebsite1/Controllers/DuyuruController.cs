using DuWebsite1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuWebsite1.Models.ViewModels;

namespace DuWebsite1.Controllers
{
    public class DuyuruController : Controller
    {
        EFDuWebsiteRepository websiteRepository = new EFDuWebsiteRepository(new DuDbContext());
        public int PageSize = 4; 


        public ViewResult Index(int DuyuruSayfası = 1)
            => View(new DuyuruListViewModel {
                duyurular = websiteRepository.Duyurular
                .OrderBy(p => p.DuyuruId)
                .Skip((DuyuruSayfası - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = DuyuruSayfası,
                    ItemsPerPage = PageSize,
                    TotalItems = websiteRepository.Duyurular.Count()
                }
            });


        public ActionResult DuyuruDetay(int id)
        {
            var duyuru = websiteRepository.Duyurular.FirstOrDefault(x => x.DuyuruId == id);
            return View(duyuru);
        }

        public ActionResult Privacy()
        {
            return View();
        }


    }
}
