using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_commerceMVC.Models.Entity;

namespace e_commerceMVC.Controllers
{
    public class HomeController : Controller
    {
        db_ecommerceEntities1 db = new db_ecommerceEntities1();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Men()
        {
            return View();
        }

        public ActionResult Women()
        {
            return View();
        }

        public ActionResult Kids()
        {
            return View();
        }
        
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Bestseller()
        {
            return View();
        }

        public PartialViewResult mantopthree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID==1).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult manSecondThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 1).Skip(3).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult manThirdThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 1).Skip(6).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult manFourthThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 1).Skip(9).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult manFivethThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 1).Skip(12).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult manSixthThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 1).Skip(15).Take(3).ToList();
            return PartialView(products);
        }

        public ActionResult Product(int id)
        {

            var products = db.tbl_Product.Find(id);
            return View("Product", products);

        }
        public ActionResult RProduct(tbl_Product p1)
        {
            var products = db.tbl_Product.Find(p1.Product_ID);
            products.Product_ID = p1.Product_ID;
            db.SaveChanges();
            return RedirectToAction("Product");
        }

        public PartialViewResult bestsellerTopThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Total_Sold).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult bestsellerSecondThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Total_Sold).Skip(3).Take(3).ToList();
            return PartialView(products);
        }

        public PartialViewResult bestsellerThirdThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Total_Sold).Skip(6).Take(3).ToList();
            return PartialView(products);
        }

        public PartialViewResult bestsellerFourthThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Total_Sold).Skip(9).Take(3).ToList();
            return PartialView(products);
        }

        public PartialViewResult womenTopThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 2).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult womenSecondThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 2).Skip(3).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult womenThirdThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 2).Skip(6).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult womenFourthThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 2).Skip(9).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult womenFivethThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 2).Skip(12).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult womenSixthThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Sex_ID == 2).Skip(15).Take(3).ToList();
            return PartialView(products);
        }

        public PartialViewResult kidTopThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Kid == "1").Take(3).ToList();
            return PartialView(products);
        }

        public PartialViewResult kidSecondThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Kid == "1").Skip(3).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult kidThirdThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Kid == "1").Skip(6).Take(3).ToList();
            return PartialView(products);
        }
        public PartialViewResult kidFourthThree()
        {
            List<tbl_Product> products = db.tbl_Product.ToList().OrderByDescending(m => m.Product_ID).Where(m => m.Product_Kid == "1").Skip(9).Take(3).ToList();
            return PartialView(products);
        }


    }
}