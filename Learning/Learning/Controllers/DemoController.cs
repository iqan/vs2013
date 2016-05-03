using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Learning.Models;

namespace Learning.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/
        public TempModels Tm = new TempModels();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Threading()
        {

            return View();
        }

        public ActionResult LinqDemo()
        {
            Session["col"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult LinqDemo(string colorName)
        {
            Session["col"] += colorName;
            Session["col"] += " ";
            return View();
        }
    }
}
