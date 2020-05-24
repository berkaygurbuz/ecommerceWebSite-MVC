using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_commerceMVC.Models.Entity;

namespace e_commerceMVC.Controllers
{
    public class AdminController : Controller
    {
        db_ecommerceEntities1 db = new db_ecommerceEntities1();

        // GET: Admin
        [HttpPost]
        public ActionResult AdminPanelLogin(FormCollection fc)
        {
            foreach (var item in db.tbl_Admin)
            {
                string entered_adminName = fc["adminName"];
                string db_adminName = item.AdminName;
                string entered_adminPassword = fc["pw"];
                string db_adminPassword = item.AdminPassword;
                
                if(entered_adminName==db_adminName && entered_adminPassword==db_adminPassword)
                {
                    return Redirect("AdminPanelIndex");
                }

                    
            }
            return View();
        }
      
        public ActionResult AdminPanelLogin()
        {
            return View();
        }

        public ActionResult AdminPanelIndex()
        {
            return View();
        }

        public ActionResult EditCategories()
        {
            var categories = db.tbl_Category.ToList();
            return View(categories);
        }

        public ActionResult DeleteCategories(int id)
        {
            var categories = db.tbl_Category.Find(id);
            db.tbl_Category.Remove(categories);
            db.SaveChanges();
            return RedirectToAction("EditCategories");
        }

        public ActionResult UpdateCategories(int id)
        {
            var categories = db.tbl_Category.Find(id);
            return View("UpdateCategories",categories);
        }

        public ActionResult AdminUpdateCategories(tbl_Category p1)
        {
            var categories = db.tbl_Category.Find(p1.Product_CategoryID);
            categories.Category_Name = p1.Category_Name;
            db.SaveChanges();
            return RedirectToAction("EditCategories");
        }
        
        public ActionResult CategoryAdd()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CategoryAdd(tbl_Category p1)
        {
            db.tbl_Category.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult ProductList()
        {
            var products = db.tbl_Product.ToList();
            return View(products);

        }
        [HttpGet]
        public ActionResult ProductAdd()
        {
            //List<SelectListItem> getGender = (from i in db.Product_Sex.ToList() select new SelectListItem { Text = i.Product_Sex_Text, Value = i.Product_Sex_ID.ToString() }).ToList();
            //ViewBag.gG = getGender;
            List<SelectListItem> getCategory = (from i in db.tbl_Category.ToList() select new SelectListItem { Text = i.Category_Name, Value = i.Product_CategoryID.ToString() }).ToList();
            ViewBag.gc = getCategory;
            return View();
        }
        [HttpPost]
        public ActionResult ProductAdd(tbl_Product p1)
        {

            
            var categories = db.tbl_Category.Where(m => m.Product_CategoryID == p1.tbl_Category.Product_CategoryID).FirstOrDefault();
            //var gender = db.Product_Sex.Where(m => m.Product_Sex_ID == p1.Product_Sex.Product_Sex_ID).FirstOrDefault();
            p1.tbl_Category = categories;
            db.tbl_Product.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult ProductUpdate(int id)
        {
            var products = db.tbl_Product.Find(id);
            return View("ProductUpdate", products);
        }
        public ActionResult AdminUpdateProduct(tbl_Product p1)
        {
            var products = db.tbl_Product.Find(p1.Product_ID);


            products.Product_Info = p1.Product_Info;
            products.Brand_ID = p1.Brand_ID;
            products.Product_Color = p1.Product_Color;
            products.Product_CategoryID = p1.Product_CategoryID;
            products.Product_Price = p1.Product_Price;
            products.Stock = p1.Stock;
            products.Product_Size = p1.Product_Size;
            products.Rating = p1.Rating;
            products.Product_Sex_ID = p1.Product_Sex_ID;
            products.Total_Sold = p1.Total_Sold;

            db.SaveChanges();
            return RedirectToAction("ProductList");
        }
        
        public ActionResult UpdateProductList()
        {
            var products = db.tbl_Product.ToList();
            return View(products);
        }

        public ActionResult DeleteProductList()
        {
            var products = db.tbl_Product.ToList();
            return View(products);
        }

        public ActionResult DeleteProduct(int id)
        {
            var products = db.tbl_Product.Find(id);
            db.tbl_Product.Remove(products);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}