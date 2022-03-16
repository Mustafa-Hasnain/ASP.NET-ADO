using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Database_First_Approach.Models;

namespace Database_First_Approach.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        db_ASPEntities db = new db_ASPEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(signup s)
        {
            db.signups.Add(s);
            db.SaveChanges();
            return View();
        }
    }
}