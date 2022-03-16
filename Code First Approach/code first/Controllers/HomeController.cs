using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using code_first.Models;

namespace code_first.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        classcontext db = new classcontext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Class1 l)
        {
            db.Students.Add(l);
            db.SaveChanges();
            return View();
        }
    }
}