using DuWebsite1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DuWebsite1.Controllers
{
    public class HomeController : Controller
    {
        private IDuWebsiteRepository repository;
        public int PageSize = 4;
        EFDuWebsiteRepository websiteRepository = new EFDuWebsiteRepository(new DuDbContext());

        //public HomeController(IDuWebsiteRepository repo)
        //{
        //    repository = repo;
        //}

        public ViewResult Index(){

            return View();
            }





    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}
