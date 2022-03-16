using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //Making Object of ASP Entities
        ASPEntities db = new ASPEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(signup s)
        {
            db.signups.Add(s);
            int a=db.SaveChanges();
            if (a > 0)
            {
                ViewBag.msg = "Data Inserted Succesfully";
            }
            else
            {
                ViewBag.errormsg = "Data not Inserted";
            }
            return View();
        }
        public ActionResult List()
        {
            var list_data = db.signups.ToList();
            return View(list_data);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(signup s)
        {
            //Query in C# for SQL SERVER
            var data = db.signups.Where(model => model.Email == s.Email && model.Password == s.Password);

            //Giving Condition FOR SQL SERVER
            if (data != null)
            {
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.msg = "Wrong Email or Password";
            }
            return View();
        }
    }
}