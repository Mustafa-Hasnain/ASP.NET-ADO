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
        // GET: Home
        db_imageEntities db = new db_imageEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tb_img t)
        {
            //making variable for storing filename
            string filename = Path.GetFileNameWithoutExtension(t.Img_file.FileName);

            //making an extension variable
            string ext = Path.GetExtension(t.Img_file.FileName);

            //Adding a Condition/validation to get jpeg file only
            if (ext.ToLower()==".jpg" || ext.ToLower()==".jpeg")
            {
                //Concatenating the filename
                filename = filename + ext;

                t.Img_path = "~/images/" + filename;

                //Add the image path to images folder
                string path = Path.Combine(Server.MapPath("~/images/"), filename);
                t.Img_file.SaveAs(path);
                db.tb_img.Add(t);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.errormsg = "File not Supported";
            }
            return View();
        }
        public ActionResult List()
        {
            var data = db.tb_img.ToList();
            return View(data);
        }


    }
}