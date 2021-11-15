using strona_internetowa_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace strona_internetowa_mvc.Controllers
{
    public class MainController : Controller
    {
        private static IList<Product> products = new List<Product>();

        // GET: Main
        public ActionResult Index()
        {
            return View(products); //returns View with products list
        }

        // GET: Main/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
            return RedirectToAction("Index");
        }

        // GET: Main/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Main/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Main/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Main/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
