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
    public class CoursesController : Controller
    {
        CourseService course = new CourseService(new CoursesRepo());
        // GET: Courses
        public ActionResult Index()
        {
            var list = course.getAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Courses obj)
        {
            if (ModelState.IsValid)
            {
                course.create(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var item = course.find(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Courses obj)
        {
            if (ModelState.IsValid)
            {
                course.update(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var item = course.find(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteCourse(int Id)
        {
            if (ModelState.IsValid)
            {
                course.delete(Id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Delete", new { Id = Id});
        }

        public ActionResult Details(int Id)
        {
            var item = course.find(Id);
            return View(item);
        }


    }
}