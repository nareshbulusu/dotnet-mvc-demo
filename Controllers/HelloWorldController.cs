using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_mvc_demo.Models;

namespace dotnet_mvc_demo.Controllers
{
    [Authorize]
    public class HelloWorldController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HelloWorldController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action with authentication...";
        }
        
        // 
        // GET: /HelloWorld/Welcome/ 

        [AllowAnonymous]
        public string Welcome()
        {
            return "This is the Welcome action method without authentication...";
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
