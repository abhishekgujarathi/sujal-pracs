using PracticalTwelve.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PracticalTwelve.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _service = new EmployeeService();
        public ActionResult Index()
        {
            List<Employee> list = new List<Employee>();
            list = _service.GetAllEmployees();
            return View(list);
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _service.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public ActionResult UpdateFirstName()
        {
            _service.UpdateEmployeeFirstName();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateMiddleName()
        {
            _service.UpdateEmployeeMiddleName();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteLessThanTwo()
        {
            _service.DeleteEmployeeLessThanTwo();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAll()
        {
            _service.DeleteEmployeeAll();
            return RedirectToAction("Index");
        }
    }
}