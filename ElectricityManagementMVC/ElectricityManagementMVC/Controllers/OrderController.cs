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
        //显示退货列表-同意换货
        public IActionResult ConsentExchangeGoods(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示退货列表-待收货
        public IActionResult TakeDeliveryGoods(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示退货列表-待退款
        public IActionResult Reimburse(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示退货列表-待到账
        public IActionResult Account(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示退货列表-拒绝退货
        public IActionResult RejectGoods(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示换货列表
        public IActionResult ExchangeGoods() 
        {
            return View();
        }
        //显示换货列表-待审核
        public IActionResult AuditGoods(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示换货列表-同意换货
        public IActionResult AgreeReplacement(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示换货列表-待收货
        public IActionResult HarvestGoods(int id) 
        {
            ViewBag.Is = id;
            return View(); 
        }
        //显示换货列表-待发新货
        public IActionResult NewGoods(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示换货列表-待用户收货
        public IActionResult UserDeliveryGoods(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示换货列表-拒绝换货
        public IActionResult RejectBarter(int id) 
        {
            ViewBag.Is = id;
            return View();
        }
        //显示退换货原因
        public IActionResult ChangingRefunding() 
        {
            return View();
        }
    }
}
