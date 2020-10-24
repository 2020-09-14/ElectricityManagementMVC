using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;

namespace ElectricityManagementMVC.Controllers
{
    public class Logistics : Controller
    {

        //显示地址
        public IActionResult Index()
        {
            return View();
        }
        //显示快递公司
        public IActionResult ShwoExperssages()
        {
            return View();
        }
        //显示包裹中心
        public IActionResult ShwoPackages()
        {
            return View();
        }
        //详情页（快递公司）
        public IActionResult Details(int id) 
        {
            ViewBag.id = id;
            return View();
        }
        //添加地址
        public IActionResult AddAddress() 
        {
            return View();
        }
        //更新地址
        public IActionResult UptAddress(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
