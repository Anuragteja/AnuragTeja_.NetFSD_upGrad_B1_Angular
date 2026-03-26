using Microsoft.AspNetCore.Mvc;

namespace Assignment7.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Details(string name, int salary, string Department)
        {
            return $"name is {name} salary is :{salary} department is {Department}";
        }
    }
}
