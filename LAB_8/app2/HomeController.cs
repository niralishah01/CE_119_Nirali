using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return "Hello World";
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult test1()
        {
            int n1 = 23;
            int n2 = 34;
            int result = n1 + n2;
            ViewBag.num1 = n1;
            ViewBag.num2 = n2;
            ViewBag.ans = result;
            return View();
        }
        
        [HttpGet]
        public IActionResult test2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult test2(String num1,String num2)
        {
            int ans = Int32.Parse(num1) + Int32.Parse(num2);
            ViewBag.answer = ans.ToString();
            return View();
        }
        
        [HttpGet]
        public IActionResult user_registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult user_registration(string fname,string lname,string bdate,string mail,string mob,string passwd)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["bday"] = bdate;
            ViewData["email"] = mail;
            ViewData["mobile"] = mob;
            
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
