using Microsoft.AspNetCore.Mvc;
using Mission4_Dallas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4_Dallas.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GradeCalculation()
        {
            return View();
        }

        //Overload Method
        [HttpPost]
        public IActionResult GradeCalculation (GradeCalculatorModel model)
        {
            return View();
        }
    }
}
