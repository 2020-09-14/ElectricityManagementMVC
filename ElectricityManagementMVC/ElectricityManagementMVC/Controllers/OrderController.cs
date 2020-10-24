using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityManagementMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult deliver()
        {
            return View(); 
        }
        public IActionResult orderDetails(string ids)
        {
            ViewBag.Is = ids;
            return View();
        }

        public IActionResult ShowSales()
        {
            return View();
        }

        public IActionResult DetailsSales(int id)
        {
            ViewBag.Is = id;
            return View();
        }
    }
}
