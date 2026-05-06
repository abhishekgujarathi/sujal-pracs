using Practical_13_2.Models;
using System.Web.Mvc;

public class EmployeeController : Controller
{
    private readonly EmployeeService _serviceEmployee;
    private readonly DesignationService _serviceDesignation;


    public EmployeeController()
    {
        var context = new AppDbContext();

        var repoEmployee = new EmployeeRepository(context);
        var repoDesignation = new DesignationRepository(context);

        _serviceEmployee = new EmployeeService(repoEmployee);
        _serviceDesignation = new DesignationService(repoDesignation);
    }

    public ActionResult Index()
    {
        var employees = _serviceEmployee.GetAllEmployees();
        return View(employees);
    }

    public ActionResult Create()
    {
        BindDesignationDropdown();
        return View();
    }

    [HttpPost]
    public ActionResult Create(Employee emp)
    {
        BindDesignationDropdown();

        if (ModelState.IsValid)
        {
            string msg = _serviceEmployee.CreateEmployee(emp);
            ViewBag.Message = msg;
            ModelState.Clear(); 
            return View();
        }

        return View(emp);
    }

    public ActionResult Update(int id)
    {
        var emp = _serviceEmployee.GetEmployeeById(id);
        BindDesignationDropdown();
        return View(emp);
    }

    [HttpPost]
    public ActionResult Update(Employee emp)
    {
        BindDesignationDropdown();

        if (ModelState.IsValid)
        {
            string msg = _serviceEmployee.UpdateEmployee(emp);
            ViewBag.Message = msg;
            return View(emp);
        }

        return View(emp);
    }

    public ActionResult Delete(int id)
    {
        var emp = _serviceEmployee.GetEmployeeById(id);
        return View(emp);
    }


    [HttpPost]
    public ActionResult DeleteConfirmed(int id)
    {
        string msg = _serviceEmployee.DeleteEmployee(id);
        TempData["Message"] = msg;

        return RedirectToAction("Index");
    }

    private void BindDesignationDropdown()
    {
        var designations = _serviceDesignation.GetAllDesignations();
        ViewBag.DesignationList = new SelectList(designations, "Id", "DesignationName");
    }
}