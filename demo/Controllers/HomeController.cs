﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["userName"] != null)
            {
                return View();
            }
            else
            {
                return View();
            }
        }

       
    }
}