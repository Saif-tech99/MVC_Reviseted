using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Reviseted.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult SayHello()
        {
            ViewBag.Hello = "Hello C-Sharper's";
            ViewBag.Year = "2020";

            ViewData["Name"] = "Saif";
            ViewData["LastName"] = "Saif2";

            return View();
        }
    }
}
