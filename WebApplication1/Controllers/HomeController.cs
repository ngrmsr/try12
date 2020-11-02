using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                advertise = new List<Ads>()
                {
                    new Ads () { Title="aa" , Description="aaaaaaaaaaa"},
                    new Ads () { Title="bb" , Description="bbbbbbbbbbbbbbbbb"}

                },
                Categories = new List<CategoryViewModel>()
                {
                    new CategoryViewModel () { Name="sport" , Count=4},
                    new CategoryViewModel () { Name="Science" , Count=10}

                }
            };
            return View(homeViewModel);
        }
        public IActionResult NoView()
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
