using System;
using System.Web.Mvc;

namespace PracticalTen.Controllers
{
    public class ActionResultDemoController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public PartialViewResult GetPartialView()
        {
            return PartialView("_PartialView");
        }
        public ContentResult GetContent() 
        {
            return Content("This is ContentResult");
        }
        public JsonResult GetJson()
        {
            var data = new
            {
                Id = 11,
                Name = "sujal",
                Role = "Developer"
            };
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        public FileResult GetFile()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(
                Server.MapPath("~/Content/sample.txt")
            );
            return File(fileBytes, "text/plain", "sample.txt");
        }

        public EmptyResult GetEmpty()
        {
            return new EmptyResult();
        }

        public JavaScriptResult GetJavaScript()
        {
            string script = "alert('This is JavaScriptResult');";
            return JavaScript(script);
        }
        public HttpNotFoundResult GetHttpNotFound()
        {
            return HttpNotFound("Data Not Found!!");
        }
        public HttpStatusCodeResult GetHttpStatusCode()
        {
            return new HttpStatusCodeResult(400, "Bad Request");
        }
        public RedirectResult GoToGoogle()
        {
            return Redirect("https://www.google.com/");
        }
        public RedirectToRouteResult GoToHome()
        {
            return RedirectToAction("Index", "Home");
        }

    }
}