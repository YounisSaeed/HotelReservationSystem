using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class ManageAccountController : Controller
    {
        // GET: ManageAccount
        public ActionResult ForgetPass()
        {
            return View();
        }
    }
}