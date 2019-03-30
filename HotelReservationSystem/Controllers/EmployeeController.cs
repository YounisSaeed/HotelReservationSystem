using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        lightsDBEntities db = new lightsDBEntities();
        public ActionResult Index()
        {
            return View(db.users.Where(y=>y.typID==2).ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(user E)
        {
            if (ModelState.IsValid)
            {
                db.users.Add(E);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(E);
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            var user = db.users.Single(c => c.typID == id);
            db.users.Remove(user);
            db.SaveChanges();
            return View();
        }

    }
}