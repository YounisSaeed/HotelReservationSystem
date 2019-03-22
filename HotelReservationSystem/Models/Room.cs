using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.Models
{
    public class Room
    {
        public int id { get; set; }
        public int checkInDate { get; set; }
        public int checkOutDate { get; set; }
        public String Kind { get; set; }
        public String view { get; set; }
        public int bedNo { get; set; }
        public double price { get; set; }
    }
}