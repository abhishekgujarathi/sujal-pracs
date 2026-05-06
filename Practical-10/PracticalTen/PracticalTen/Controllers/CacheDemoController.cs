using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalTen.Controllers
{
    public class CacheDemoController : Controller
    {
        [OutputCache(CacheProfile="FiveMinCache")]
        public ActionResult Index()
        {
            string time = DateTime.Now.ToString();
            ViewBag.Time = time;
            return View();
        }
    }
}