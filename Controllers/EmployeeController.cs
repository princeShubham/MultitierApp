using CommonLayer.Contract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultitierApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee employee;

        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }
        public IActionResult Index()
        {
            var emp = employee.GetEmployees();
            return View(emp);
        }
    }
}
