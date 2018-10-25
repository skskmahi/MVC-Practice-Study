using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentRegistration.Models;
using System.Data.Entity.Infrastructure;
using System.Web.Routing;
using System.Web.Security;

namespace StudentRegistration.Controllers
{ 
    public class StudentController : Controller
    {
        
        private StudentEntities db = new StudentEntities();

        public Student Student { get; private set; }
        
        public ViewResult Index()
        {
            return View(db.Students.ToList());
        }

        public ViewResult Details(int id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }

       
        public ActionResult Create()
        {          
            
            return View();
        }
  
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {                
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");  
                
            }            
            ViewBag.AreasOfInterest = new SelectList(db.Students, "AreasOfInterest", "AreasOfInterest", student.AreasOfInterest);            
            return View(student);
        }        
        
        public ActionResult Edit(int id)
        {
            Student student = db.Students.Find(id);           
            return View(student);
        }       
             
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {                
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }

        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
          
        }
    }

}