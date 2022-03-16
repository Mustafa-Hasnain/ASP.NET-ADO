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
        //Making a Object of Model Context Database/Class
        db_ASPEntities db = new db_ASPEntities();


        // GET: Home
        //This is a Get Function  
        public ActionResult Index()
        {
            return View();
        }

        //so we need to SET Function for Database
        [HttpPost]

        //Here We Insert a Parameter for the Database/Table
        public ActionResult Index(signup t)
        {
            db.signups.Add(t);
            //The Value that would be return will be integer so we will save in int variable
            var s = db.SaveChanges();
            //Printing the Message for the Return value
            if (s>0)
            {
                ViewBag.msg = "The Data is Inserted";
            }
            else
            {
                ViewBag.errormsg = "The Data is Not Inserted";
            }

            return View();
        }

    }
}