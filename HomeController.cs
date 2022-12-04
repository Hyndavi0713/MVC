using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace _HOL2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>this is a demo of contentresult</h1>,");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1> this is a demo of contentresult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1> this is a demo of contentResult</h1>", "text/html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1> this a demo of contentresult<h1>", "text/xml");
            }
            return Content("Invalid content type");
        }
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"D:\hyndavi.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"D:\hyndavi.jpg", "image/jpg", "default.jpg");
        }
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }
        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "xml" });
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

    }
}
