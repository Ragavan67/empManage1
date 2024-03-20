using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CURD.Models;

namespace CURD.Controllers
{
    public class HomeController : Controller
    {
        studentEntities student=new studentEntities();
        public List<Student>employees=new List<Student>();
        public ActionResult Index()
        {
           employees = student.student.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}