using System.Web.Mvc;
using System.Web.Services.Description;
using Practical_13_1.Models;

namespace Practical_13_1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        public EmployeeController()
        {
            var context = new EmployeeDbContext();

            var repo = new EmployeeRepository(context);

            _service = new EmployeeService(repo);
        }

        public ActionResult Index()
        {
            var employees = _service.GetEmployees();
            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _service.CreateEmployee(emp);
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        public ActionResult Update(int id)
        {
            var employee = _service.GetEmployee(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Update(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _service.UpdateEmployee(emp);
                return RedirectToAction("Index");
            }

            return View(emp);
        }
        public ActionResult Delete(int id)
        {
            var employee = _service.GetEmployee(id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            _service.DeleteEmployee(id);
            return RedirectToAction("Index");

        }
    }
}