using BikeStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BikeStore.Controllers
{
    public class StoreController : Controller
    {
        BikeStoreEntities storeDB = new BikeStoreEntities();
        // GET: Store
        public ActionResult Index(string storeName)
        {
            return View();
        }
        public ActionResult Details(string storeName)
        {
            var storeModel = storeDB.Stores.Include("StoreInventory").Single(s => s.Name == storeName);
            return View(storeModel);
        }

        public ActionResult ContactDetails()
        {
            var stores = storeDB.Stores.ToList();
            return View(stores);
        }
    }
}