using PracticalTen.Filters;
using System.Web.Mvc;

namespace PracticalTen.Controllers
{
    [CustomExceptionFilter]
    public class ExceptionDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Divide()
        {
            int a = 10;
            int b = 0;

            return Content("Result: " + a / b);
        }

    }
}