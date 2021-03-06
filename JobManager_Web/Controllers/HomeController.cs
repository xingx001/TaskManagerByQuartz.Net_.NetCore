﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobManager_Web.Models;
using System.ComponentModel;

namespace JobManager_Web.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public JsonResult Test(Temp temp)
        {
  
            var c = temp.A / temp.B;
            return Json(c);
        }
        public IActionResult About()
        {

            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
    public class Temp {
        public int A { get; set; }
        public int B { get; set; }
    }
}
