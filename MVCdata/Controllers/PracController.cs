using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCdata.Controllers
{
    public class PracController : Controller
    {
        // GET: Prac
        public string Index()
        {
            return "<h1>this is prac by now<h1>";
        }
        
        public string About(string a)
        {

            return "<h1>welcom to about</h1>" + a;
        }
    }
}