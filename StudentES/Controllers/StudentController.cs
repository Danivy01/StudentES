using StudentES.Models;
using StudentES.Services;
using StudentES.Services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentES.Controllers
{
    public class StudentController : Controller
    {
        StudentService mod = new StudentService(new StudentRepo());
        // GET: Student
        public ActionResult Index()
        {
            var list = mod.getAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Students obj)
        {
            if (ModelState.IsValid)
            {
                mod.create(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var item = mod.find(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Students obj)
        {
            if (ModelState.IsValid)
            {
                mod.update(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var item = mod.find(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteStudent(int Id)
        {
            if (ModelState.IsValid)
            {
                mod.delete(Id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Delete", new { Id = Id });
        }

        public ActionResult Details(int Id)
        {
            var item = mod.find(Id);
            return View(item);
        }

    }
}