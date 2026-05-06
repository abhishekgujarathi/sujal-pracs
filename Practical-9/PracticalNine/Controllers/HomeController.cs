using System.Web.Mvc;

namespace PracticalNine.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestOne()
        {
            return View();
        }
        public ActionResult TestTwo() 
        {
            return View();
        }
        public ActionResult TestThree()
        {
            ViewBag.Message = "Hello World";
            return View();
        }
    }
}