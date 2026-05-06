using System.Web.Mvc;

namespace Practical_15_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string username = User.Identity.Name;
            string type = User.Identity.AuthenticationType;

            ViewBag.User = username;
            ViewBag.Type = type;
            ViewBag.IsAuth = User.Identity.IsAuthenticated;
            return View();
        }

        [Authorize]
        public ActionResult DashBoard()
        {
            return View();
        }

        
    }
}