using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        masterEntities1 db = new masterEntities1();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(img t)
        {
            string filename = Path.GetFileNameWithoutExtension(t.Imgfile.FileName);
            string ext = Path.GetExtension(t.Imgfile.FileName);
            filename = filename + ext;
            t.ImgPath = "~/images/" + filename;
            string path = Path.Combine(Server.MapPath("~/images/"), filename);
            t.Imgfile.SaveAs(path);
            db.img.Add(t);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult List()
        {
            var row = db.img.ToList();
            return View(row);
        }

    }
}