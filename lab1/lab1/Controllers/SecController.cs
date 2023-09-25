using lab1.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class SecController : Controller
    {
        // GET: Sec
        static List<Employee> _employees = new List<Employee>()
        {
            new Employee(){ Id=1,Name="mostafa"},
            new Employee(){ Id=2,Name="mohamed"}
        };
        public JsonResult Employees()
        {
            return Json(_employees, JsonRequestBehavior.AllowGet);
        }
        public void AddEmployees(int id, string name)
        {
            _employees.Add(new Employee { Id = id, Name = name });
        }
        public void UpdateEmployees(int id, string name)
        {
            var data = _employees.Find(x => x.Id == id);
            if (data != null)
            {
                data.Id = id;
                data.Name = name;
            }
        }
        public void RemoveEmployees(int id)
        {
            var data = _employees.Find(x => x.Id == id);
            if (data != null)
            {
                _employees.Remove(data);
            }
        }
    }
}