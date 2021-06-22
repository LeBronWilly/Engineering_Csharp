using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CustomerWeb.Models;

namespace CustomerWeb.Controllers
{
    public class HomeController : Controller
    {
        CustomerDBEntities db = new CustomerDBEntities();

        // GET: Home
        public ActionResult Index()
        {
            var customers = db.客戶.ToList();
            return View(customers);
        }

        public ActionResult Delete(string custId)
        {
            var customer = db.客戶.Where(m => m.編號 == custId).FirstOrDefault();
            db.客戶.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(客戶 customer)
        {
            string custId = customer.編號;
            var temp = db.客戶.Where(m => m.編號 == custId).FirstOrDefault();
            if (temp == null)
            {
                db.客戶.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Msg = "編號重複!";
            return View();
        }

        public ActionResult Edit(string custId)
        {
            var customer = db.客戶.Where(m => m.編號 == custId).FirstOrDefault();
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(客戶 customer)
        {
            string custId = customer.編號;
            var temp = db.客戶.Where(m => m.編號 == custId).FirstOrDefault();
            temp.姓名 = customer.姓名;
            temp.電話 = customer.電話;
            temp.地址 = customer.地址;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}