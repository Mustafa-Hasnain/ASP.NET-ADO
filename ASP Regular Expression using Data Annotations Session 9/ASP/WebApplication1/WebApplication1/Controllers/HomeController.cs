using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        db_signupEntities db = new db_signupEntities();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tb_signup t)
        {
            db.tb_signup.Add(t);
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.msg = "Data Not Inserted";
            }
            return View();
        }
        public ActionResult List()
        {
            var data = db.tb_signup.ToList();
            return View(data);
        }
        public ActionResult Edit(int id)
        {
            var row = db.tb_signup.Where(model => model.Id == id);
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(tb_signup t)
        {
            db.Entry(t).State = EntityState.Modified;
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("List");
            }
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(tb_signup t)
        {
            db.Entry(t).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                return RedirectToAction("List");
            }
            return View();
        }

    }
}