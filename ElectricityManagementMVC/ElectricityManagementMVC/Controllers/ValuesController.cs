using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityManagementMVC.Controllers
{
    public class ValuesController : Controller
    {
        public IActionResult ShowActivity()
        {
            return View();
        }
    }
}
