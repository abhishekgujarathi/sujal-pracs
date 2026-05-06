using System.Web.Mvc;

namespace PracticalTen.Controllers
{
    public class EmployeeController : Controller
    {
        
        [Route("Employee")]
        public ActionResult Index()
        {
            return View();
        }
        
        [Route("Employee/{name:alpha}")]
        public ActionResult GetName(string name)
        {
            ViewBag.Name = name;
            return View();
        }
    }
}