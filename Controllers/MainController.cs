using strona_internetowa_mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace strona_internetowa_mvc.Controllers
{
    public class MainController : Controller
    {
        private static IList<Product> products = new List<Product>();
        private ShopDbContext db = new ShopDbContext();

        // GET: Main
        public ActionResult Index()
        {
            var p = db.Products;
            return View(p); //returns View with products list
        }

        // GET: Main/Details/5
        public ActionResult Details(int id)
        {
            Product p = db.Products.Find(id);
            //return View(products.FirstOrDefault(x => x.ProductId == id)); // Send information about id and search for maching element from the list
            return View(p);
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            return View(new Product());
        }

        // POST: Main/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {

            product.ProductId = products.Count + 1;
            products.Add(product);

            if(ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
            }

            return RedirectToAction("Index");


        }

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            Product p = db.Products.Find(id);

            return View(p);
            //return View(products.FirstOrDefault(x => x.ProductId ==id));
        }

        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
                Product single_product = products.FirstOrDefault(x => x.ProductId == id);
            single_product.ProductName = product.ProductName;
            single_product.Description = product.Description;
            single_product.Amount = product.Amount;


            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(product);

            //return RedirectToAction("Index");

        }

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            Product p = db.Products.Find(id);
            return View(p);
            //return View(products.FirstOrDefault(x=>x.ProductId==id));
        }

        // POST: Main/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            try
            {
                Product trash = products.FirstOrDefault(x => x.ProductId == id);
                products.Remove(trash);

                Product p = db.Products.Find(id);
                db.Products.Remove(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
