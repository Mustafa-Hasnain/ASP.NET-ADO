using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.IO;

namespace WebApplication2.Controllers
{
    public class homeController : Controller
    {
        imageEntities db = new imageEntities();
        // GET: home
        imageEntities obj = new imageEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(img t)
        {
            string filename = Path.GetFileNameWithoutExtension(t.Img_file.FileName);

            string ext = Path.GetExtension(t.Img_file.FileName);

            filename = filename + ext;

            t.image_path = "~/images/" + filename;
            string path = Path.Combine(Server.MapPath("~/images/"), filename);
            t.Img_file.SaveAs(path);
            db.imgs.Add(t);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            var row = db.imgs.ToList();
            return View(row);
        }
        public ActionResult edit(int id)
        {
            var row = db.imgs.Where(model => model.id == id).FirstOrDefault();            
            return View();
        }
        [HttpPost]
        public ActionResult edit(img t)
        {
            db.Entry(t).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}