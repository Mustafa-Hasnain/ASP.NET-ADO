using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string Name = "Mustafa";
            return View();
        }
        public string Details()
        {

            return "Its a ASP WEB APPLICATION";
        }

    }
}