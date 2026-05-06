using System;
using System.Linq;
using System.Web.Mvc;
using Practical_14.Models;

namespace Practical_14.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        public EmployeeController()
        {
            var context = new Practical_14Entities3();

            var repo = new EmployeeRepository(context);

            _service = new EmployeeService(repo);
        }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 10;

            var data = _service.GetEmployees().ToList();

            int totalRecords = data.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            var pagedData = data
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            if (Request.IsAjaxRequest())
            {
                return PartialView("_EmployeeTable", pagedData);
            }

            return View(pagedData);
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
        public ActionResult Search(string name, int page = 1)
        {
            int pageSize = 10;
            var data = _service.GetEmployees().ToList();

            if (!string.IsNullOrEmpty(name))
            {
                data = data
                    .Where(x => x.Name != null && x.Name.ToLower().Contains(name.ToLower()))
                    .ToList();
            }

            int totalRecords = data.Count();
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            var pagedData = data
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;

            return PartialView("_EmployeeTable", pagedData);
        }
    }
}