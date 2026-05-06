using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practical_11.Models;

namespace Practical_11.Controllers
{
    public class PersonController : Controller
    {
        static List<Person> list = new List<Person>();
        public ActionResult Index()
        {
            return View(list);
        }

        public ActionResult Create()
        {
            return View(new Person());
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
            return View(p);
        }

        public ActionResult Update(int id)
        {
            var person = list.FirstOrDefault(m => m.Id == id);
            return View(person);
        }

        [HttpPost]
        public ActionResult Update(Person p)
        {
            if (ModelState.IsValid)
            {
                var person = list.FirstOrDefault(m => m.Id == p.Id);

                if (person != null)
                {
                    person.Name = p.Name;
                    person.DOB = p.DOB;
                    person.Address = p.Address;
                }
                return RedirectToAction("Index");
            }
            return View(p);
        }

        public ActionResult Delete(int id)
        {
            var person = list.FirstOrDefault(m=>m.Id == id);

            return View("Delete", person);
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