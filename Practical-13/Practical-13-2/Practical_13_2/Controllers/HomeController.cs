using Practical_13_2.Models;
using System.Web.Mvc;

namespace Practical_13_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeService _service;

        public HomeController()
        {
            var context = new AppDbContext();
            var repo = new EmployeeRepository(context);
            _service = new EmployeeService(repo);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetEmployeeCountByDesignation()
        {
            var data = _service.GetEmployeeCountByDesignation();
            return View("Index", data);
        }
    }
}