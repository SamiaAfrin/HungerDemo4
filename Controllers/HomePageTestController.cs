using HungerDemo4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungerDemo4.Controllers
{
    public class HomePageTestController : Controller
    {
        
        HungerDb db = new HungerDb();
        // GET: HomePageTest
        public ActionResult Index()
        {
            List<Product> products = db.Products.ToList<Product>();
            return View(products);
            

        }
    }
}