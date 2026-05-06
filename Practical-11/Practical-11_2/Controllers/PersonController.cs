using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Practical_11_2.Models;

namespace Practical_11_2.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> list = new List<Person>();

        public ActionResult Index()
        {
            return View(list);
        }

        public PartialViewResult Create()
        {
            return PartialView("_Create", new Person());
        }

      
        [HttpPost]
        public ActionResult Create(Person p)
        {
            if (ModelState.IsValid)
            {
                p.Id = list.Count + 1;
                list.Add(p);
                return RedirectToAction("Index");
            }
            return PartialView("_Create", p);
        }

        
        public PartialViewResult Update(int id)
        {
            var person = list.FirstOrDefault(x => x.Id == id);
            return PartialView("_Update", person);
        }


        [HttpPost]
        public ActionResult Update(Person p)
        {
            if (ModelState.IsValid)  
            {
                var person = list.FirstOrDefault(x => x.Id == p.Id);
                if (person != null)
                {
                    person.Name = p.Name;
                    person.DOB = p.DOB;
                    person.Address = p.Address;
                }
                return RedirectToAction("Index");
            }

            return PartialView("_Update", p); 
        }


        public PartialViewResult Delete(int id)
        {
            var person = list.FirstOrDefault(x => x.Id == id);
            return PartialView("_Delete", person);
        }

        
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var person = list.FirstOrDefault(x => x.Id == id);
            if (person != null)
            {
                list.Remove(person);
            }
            return RedirectToAction("Index");
        }
    }
}