using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrashCollector.Web.Models;

namespace TrashCollector.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            if(this.User.IsInRole("Employee"))
            {
                return RedirectToAction("TodaysPickUps", "Employee");
            }
            else {
                return View();
            }

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
