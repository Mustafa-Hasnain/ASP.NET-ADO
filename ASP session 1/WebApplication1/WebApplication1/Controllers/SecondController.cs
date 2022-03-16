using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult SecondIndex()
        {
            ViewBag.Name = "Mustafa";
            ViewData["Subject"] = "ASP .NET";
            TempData["Language"] = "C#";
            return View();
        }

        public int Sum(int a = 10, int b = 20)
        {
            int sum = a + b;
            return sum;
        }
        public ActionResult Temp()
        {
            TempData["Language"].ToString();
            return View();
        }
    }
}