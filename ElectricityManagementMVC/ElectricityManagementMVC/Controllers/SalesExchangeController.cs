using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityManagementMVC.Controllers
{
    public class SalesExchangeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TuiShow()
        {
            return View();
        }
    }
}
