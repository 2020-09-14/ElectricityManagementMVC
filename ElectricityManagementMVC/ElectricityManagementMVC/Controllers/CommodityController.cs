using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityManagementMVC.Controllers
{
    public class CommodityController : Controller
    {
        public IActionResult CommShow()
        {
            return View();
        }
        public IActionResult CommAdd()
        {
            return View();
        }
        public IActionResult CommAdd2()
        {
            return View();
        }
        public IActionResult CommDel()
        {
            return View();
        }
        public IActionResult Specification()
        {
            return View();
        }
        
        public IActionResult CommEvaluate()
        {
            return View();
        }
        public IActionResult Brand()
        {
            return View();
        }
        public IActionResult BrandAdd()
        {
            return View();
        }

    }
}
