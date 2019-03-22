using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelReservationSystem.Models
{
    public class Admin : Users
    {
        List<Contact> contact = new List<Contact>
        {
            new Contact {}
        };
    }
}