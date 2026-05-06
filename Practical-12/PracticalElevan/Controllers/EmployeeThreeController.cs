using PracticalTwelve.Models;
using System.Web.Mvc;

namespace PracticalTwelve.Controllers
{
    public class EmployeeThreeController : Controller
    {
        private readonly EmployeeThreeService _service = new EmployeeThreeService();

        public ActionResult Index()
        {
            _service.CreateIndex();

            var model = new DashboardViewModel
            {
                CountByDesignation = _service.GetCountByDesignation(),
                DisplayByDesignation = _service.GetDisplayByDesignation(),
                DisplayByView = _service.GetDisplayByView(),
                DisplayByStoredProcedure = _service.GetDisplayByStoredProcedure(),
                MoreThanOne = _service.GetMoreThanOneEmployeeDesignation(),
                MaxSalaryEmployee = _service.GetMaxSalaryEmployee()
            };
            var designations = _service.GetDesignations();
            ViewBag.DesignationList = new SelectList(designations, "Id", "DesignationName");
            return View(model);
        }
        public ActionResult InsertEmployee()
        {
            var designations = _service.GetDesignations();
            ViewBag.DesignationList = new SelectList(designations, "Id", "DesignationName");
            return View();
        }

        [HttpPost]
        public ActionResult InsertEmployee(EmployeeThree emp)
        {
            if (ModelState.IsValid)
            {
                _service.InsertEmployee(emp);
                return RedirectToAction("Index");
            }
            var designations = _service.GetDesignations();
            ViewBag.DesignationList = new SelectList(designations, "Id", "DesignationName");
            return View("InsertEmployee",emp);
        }
        public ActionResult InsertDesignation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertDesignation(Designation desg)
        {
            if (ModelState.IsValid)
            {
                string result = _service.InsertDesignation(desg);

                if(result == "Success")
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", result);
                }
            }
            return View(desg);
        }

        public PartialViewResult DisplayEmployeesByDesignationStoredProcedure(int id)
        {
            var data = _service.GetDisplayEmployeesByDesignationStoredProcedure(id);

            return PartialView("_EmployeeByDesignation", data);
        }
        public ActionResult CreateIndex()
        {
            _service.CreateIndex();
            return RedirectToAction("Index");
        }
    }
}