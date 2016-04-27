using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StateMgmtDemo.Models;

namespace StateMgmtDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Name = "Parul";
            return View();
        }

        public ActionResult LogOn(User u)
        {
            //User u = new User();
            //u.UserName = "parul";
            //u.Password = "123";
            TempData["sname"] = "agrwl";
            TempData["fname"] = "parul";
            TempData.Keep();

            Session["sname2"] = "bitch";
            Session["fname2"] = "Die";
            
            return View(u);
        }

        public ActionResult LogOn2()
        {
            //Session["sname"] = "agrwl";
            //Session["fname"] = "parul";
            return View();
        }
    }
}
