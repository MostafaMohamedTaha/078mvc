using lab1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class FirstController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student(){Name="mostafa",Id=1},
            new Student(){Name="mohamed",Id=2},
            new Student(){Name="taha",Id=3},
        };

        public string Greeting()
        {
            return "Welcome to mvc";
        }
        public JsonResult Students()
        {
            return Json(students, JsonRequestBehavior.AllowGet);
        }
        public ViewResult Index()
        {
            return View();
        }

        public void AddStudent(int id, string name)
        {
            students.Add(new Student() { Name = name, Id = id });
        }
    }
}