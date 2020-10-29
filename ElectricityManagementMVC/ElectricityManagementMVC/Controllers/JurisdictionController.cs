using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityManagementMVC.Controllers
{
    public class JurisdictionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //显示角色信息
        public IActionResult ShowRoles()
        {
            return View();
        }
        //显示功能信息
        public IActionResult ShowFunction()
        {
            return View();
        }
        //显示组织信息
        public IActionResult ShowTissues()
        {
            return View();
        }
        //添加角色信息
        public IActionResult AddRoles()
        {
            return View();
        }
        //添加组织信息
        public IActionResult AddTissue()
        {
            return View();
        }
        //添加功能信息
        public IActionResult AddFunction()
        {
            return View();
        }
        //编辑组织信息
        public IActionResult UptTissue(int ids)
        {
            ViewBag.Is = ids;
            return View();
        }
        //编辑角色信息
        public IActionResult UptRoles(int ids)
        {
            ViewBag.Is = ids;
            return View();
        }
        //编辑功能信息
        public IActionResult UptFunction(int ids)
        {
            ViewBag.Is = ids;
            return View();
        }
    }
}
