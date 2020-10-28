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
        //显示退货列表
        public IActionResult ShowSales()
        {
            return View();
        }
        //显示退货列表-待审核
        public IActionResult DetailsSales(int id)
        {
            ViewBag.Is = id;
            return View();
        }
       
    }
}
