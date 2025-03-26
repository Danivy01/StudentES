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
    public class HomeController : Controller
    {
        EnrollmentService enrollment = new EnrollmentService(new EnrollmentRepo());
        public ActionResult Index()
        {
            var list = enrollment.getAll();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Enrollment obj)
        {
            if (ModelState.IsValid)
            {
                enrollment.create(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int Id)
        {
            var item = enrollment.find(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(Enrollment obj)
        {
            if (ModelState.IsValid)
            {
                enrollment.update(obj);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int Id)
        {
            var item = enrollment.find(Id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteEnrollment(int Id)
        {
            if (ModelState.IsValid)
            {
                enrollment.delete(Id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Delete", new { Id = Id });
        }

        public ActionResult Details(int Id)
        {
            var item = enrollment.find(Id);
            return View(item);
        }




    }
}