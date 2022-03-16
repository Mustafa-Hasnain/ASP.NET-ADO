using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Registration_From.Models;

namespace Registration_From.Controllers
{
    public class HomeController : Controller
    {
        db_ASPEntities db = new db_ASPEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration_Form t)
        {
            db.Registration_Form.Add(t);
            int a= db.SaveChanges();
            if (a == 1)
            {
                ViewBag.msg = "Data Recieved Seccessfully";
            }
            else
            {
                ViewBag.errormsg = "Data didnot sent";
            }
            return View();
        }
        public ActionResult list()
        {
            var row = db.Registration_Form.ToList();
            return View(row);
        }
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(Registration_Form t) 
        {
            var data = db.Registration_Form.Where(model => model.Email == t.Email && model.Password == t.Password).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("list");
            }
            else
            {
                return ViewBag.error = "Login Failed";
            }
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Registration_Form t)
        {
            db.Entry(t).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("list");
            }
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(Registration_Form t)
        {
            db.Entry(t).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("list");
            }
            return View();
        }

    }
}