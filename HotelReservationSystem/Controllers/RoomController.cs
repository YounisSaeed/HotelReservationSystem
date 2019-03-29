using HotelReservationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class RoomController : Controller
    {
        lightsDBEntities db = new lightsDBEntities();
        // GET: Room
        public ActionResult Index()
        {
            return View(db.rooms.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(room R)
        {
            if(ModelState.IsValid)
            {
                db.rooms.Add(R);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(R);
        }

    }
}