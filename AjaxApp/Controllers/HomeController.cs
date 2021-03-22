using AjaxApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxApp.Models;
using System.Data.Entity;

namespace AjaxApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult All()
        {
            var students = db.Students.ToList();
            return PartialView("_Student", students);
        }
        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int Id)
        {
            AppDbContext db = new AppDbContext();
            db.Entry(Id).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("Index");
        }
    }
}
