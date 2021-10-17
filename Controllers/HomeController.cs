using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFormMVC.Models;

namespace WebFormMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View(new TestModel());
        }

        [HttpPost]
        public ActionResult Index(TestModel model)
        {
            if(ModelState.IsValid)
            {
                
            }

            return View(new TestModel());

        }
    }
}