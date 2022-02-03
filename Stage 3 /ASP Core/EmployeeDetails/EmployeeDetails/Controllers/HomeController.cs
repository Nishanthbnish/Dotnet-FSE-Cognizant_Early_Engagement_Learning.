using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetEmployeeList()
        {
            var EmployeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "John",
                    Salary = 1000,
                    Permanent = true
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Smith",
                    Salary = 5000,
                    Permanent = false
                },
                new Employee()
                {
                    Id = 3,
                    Name = "Mark",
                    Salary = 5000,
                    Permanent = false
                },
                new Employee()
                {
                    Id = 4,
                    Name = "Mary",
                    Salary = 5000,
                    Permanent = false
                }
            };

            return View(EmployeeList);
        }
    }
}
