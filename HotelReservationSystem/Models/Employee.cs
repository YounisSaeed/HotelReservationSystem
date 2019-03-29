using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.Models
{
    public class Employee : User
    {
        public int phone { get; set; }
        public String address { get; set; }
    }
}