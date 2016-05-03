using Invitation.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Invitation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Index(Response resp)
        {
            if (ModelState.IsValid)
            {
                if (!System.IO.File.Exists(@"D:\Iqan\Git\vs2013\Invitation\Invitation\App_Data\Responses\Responses.txt"))
                {
                    string[] headings = { "Order of cols:", "Name| Email| Phone| Recorded Time", "" };
                    System.IO.File.WriteAllLines(@"D:\Iqan\Git\vs2013\Invitation\Invitation\App_Data\Responses\Responses.txt", headings);
                }
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@"D:\Iqan\Git\vs2013\Invitation\Invitation\App_Data\Responses\Responses.txt",
                        true))
                {
                    file.WriteLine(resp.Name + "| " + resp.Email + "| " + resp.Phone + "| " + DateTime.Now);
                }

                return View("Thanks", resp);
            }
            else
            {
                return View();
            }
        }
    }
}
