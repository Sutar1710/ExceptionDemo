using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExceptionHandler.Filter;

namespace ExceptionHandler.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Filter.Exception]
        [OutputCache(Duration = 60)]
 
        public ActionResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now.ToString();
           
            return View();

        }
        
    }
    
}

