using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebEmp.Common.Model;
using WebEmp.Service;

namespace WebEmp.UI.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
