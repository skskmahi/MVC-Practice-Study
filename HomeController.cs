using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers
{
    public class HomeController : Controller
    {
        private StudentEntities db = new StudentEntities();
        public Student Student { get; private set; }
       
        
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to Student Registration System!";
            return View();         

        }       
   
    }
}
