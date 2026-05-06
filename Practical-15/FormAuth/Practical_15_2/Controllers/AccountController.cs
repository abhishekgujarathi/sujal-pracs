using System.Web.Mvc;
using Practical_15_2.Models;
using System.Web.Security;

namespace Practical_15_2.Controllers
{
    public class AccountController : Controller
    {
        IUserService service = new UserService();

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(User model)
        {
            if (ModelState.IsValid)
            {
                var user = service.ValidateUser(model.Username, model.Password);

                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Username, false);
                    return RedirectToAction("Index", "Home");
                }
            }
            ViewBag.Error = "Invalid username or password";
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                if (service.Register(user))
                {
                    return RedirectToAction("Login");
                }
                @ViewBag.Error = "User Already Exists";
                return View();
            }
            return View(user);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

    }
}