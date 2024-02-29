using GitHUb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GitHUb.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
           // more text 
            //testing GitHub
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
