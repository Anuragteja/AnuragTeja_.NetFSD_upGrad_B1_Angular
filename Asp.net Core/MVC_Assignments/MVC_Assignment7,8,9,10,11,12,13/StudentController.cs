using Microsoft.AspNetCore.Mvc;

namespace Assignment7.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(string name,int age)
        {
            ViewData["Name"] = name;
            ViewData["age"]= age;
            return View();
        }

        public IActionResult Info(string name, int age)
        {
            ViewData["Name"] = "john";
            ViewData["age"] = 102;
            return View();
        }

        public IActionResult Titles(string name)
        {
            ViewData["Title"] = name;
            return View();
        }

        public IActionResult students(string name)
        {
            ViewData["names"] = new List<string>
                {
                    "Anu",
                    "Ravi",
                    "Sneha"
                };

            return View();
        }
    }
}
