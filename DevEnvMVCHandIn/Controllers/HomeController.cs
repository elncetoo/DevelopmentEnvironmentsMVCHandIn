using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using DevEnvMVCHandIn.Models;
using System.Web.Helpers;

namespace DevEnvMVCHandIn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string searchCriteria)
        {
            var factory = new ShopFactory();
            IQueryable<Product> prods = factory.Products.OrderBy(p => p.Name);

            if (searchCriteria != null)
            {
                prods = prods.Where(p => p.Name.Contains(searchCriteria));
            }
            var products = prods.Take(10).ToList();
            return View(products);
        }
        
        /*
        public ActionResult Product()
        {
            ViewBag.Message = "List & details:";

            return View();
        }
        */

        public ActionResult Details(int id)
        {
            var factory = new ShopFactory();
            var found = factory.Products.Where(p => p.ID == id).FirstOrDefault();
            return View(found);
        }

        public ActionResult Picture(int id)
        {
            var factory = new ShopFactory();
            var product = factory.Products.Where(p => p.ID == id).FirstOrDefault();

            if (product == null)
            {
                return HttpNotFound();
            }

            var img = new WebImage(string.Format("~/Images/{0}.jpg", product.ImageName)); 
            img.Resize(150, 150);
            return File(img.GetBytes(), "image/jpeg");
        }
    }

 
}