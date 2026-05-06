using PracticalTwelve.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PracticalTwelve.Controllers
{
    public class EmployeeTwoController : Controller
    {
        private readonly EmployeeTwoService _service = new EmployeeTwoService();

        public ActionResult Index()
        {
            List<EmployeeTwo> list = new List<EmployeeTwo>();
            list = _service.GetAllEmployees();
            return View(list);
        }
        public ActionResult Insert()
        {
            var list = Data.EmployeeTwoSeeder.GetDummyData();
            
            foreach(var emp in list)
            {
                _service.AddEmployee(emp);
            }

            return RedirectToAction("Index");
        }

        public ActionResult GetBefore2000()
        {
            var list = _service.GetEmployeeBefore2000();
            return View("Index", list);
        }
        public ActionResult GetTotalSalary()
        {
            var list = _service.GetAllEmployees();
            ViewBag.Key = "Total Salary";
            ViewBag.Value = _service.GetEmployeeTotalSalary();
            return View("Index", list);
        }
        public ActionResult CountNullMiddleName()
        {
            var list = _service.GetAllEmployees();
            ViewBag.Key = "Total MiddleName with NULL";
            ViewBag.Value = _service.CountEmployeeNullMiddleName();
            return View("Index", list);
        }

    }
}