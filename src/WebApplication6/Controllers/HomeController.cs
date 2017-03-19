using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Time()
        {
            return Content(DateTime.Now.ToString("dd.MM.yyyy"));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Page3()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
