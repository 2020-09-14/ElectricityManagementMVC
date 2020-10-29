using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityManagementMVC.Controllers
{
    public class ActivityController : Controller
    {
        
        public IActionResult ShowActivities()
        {
            return View();
        }

        public IActionResult ShowProduct()
        {
            return View();
        }


        public IActionResult EditActivities(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }

        public IActionResult Showcoupon()
        {
            return View();
        }

        public IActionResult AddActivities()
        {
            return View();
        }

        public IActionResult Addcoupon()
        {
            return View();
        }

        //public IActionResult Editcoupon()
        //{
        //    return View();
        //}


        public IActionResult Showlanding()
        {
            return View();
        }

        public IActionResult Addlanding()
        {
            return View();
        }




    }
}
