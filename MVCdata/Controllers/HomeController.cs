﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdata.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String Index()
        {
            return "welcome To your first Act";
        }

        
        public string foo(string a)
        {
            return "foo is here :" + a;
        }
    }
}