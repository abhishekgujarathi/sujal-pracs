using Practical_13_2.Models;
using System.Web.Mvc;

public class DesignationController : Controller
{
    private readonly DesignationService _service;

    public DesignationController()
    {
        var context = new AppDbContext();
        var repo = new DesignationRepository(context);
        _service = new DesignationService(repo);
    }

    public ActionResult Index()
    {
        var designations = _service.GetAllDesignations();
        return View(designations);
    }

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Designation desg)
    {
        if (ModelState.IsValid)
        {
            string msg = _service.CreateDesignation(desg);
            ViewBag.Message = msg;
            ModelState.Clear();
            return View();
        }
        return View(desg);
    }

    public ActionResult Update(int id)
    {
        var desg = _service.GetDesignationById(id);

        if (desg == null)
            return HttpNotFound();

        return View(desg);
    }

    [HttpPost]
    public ActionResult Update(Designation desg)
    {
        if (ModelState.IsValid)
        {
            string msg = _service.UpdateDesignation(desg);
            ViewBag.Message = msg;
            return View(desg);
        }
        return View(desg);
    }

    public ActionResult Delete(int id)
    {
        var desg = _service.GetDesignationById(id);

        if (desg == null)
            return HttpNotFound();

        return View(desg);
    }

    [HttpPost]
    [ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        string msg = _service.DeleteDesignation(id);
        TempData["Message"] = msg;

        return RedirectToAction("Index");
    }
}