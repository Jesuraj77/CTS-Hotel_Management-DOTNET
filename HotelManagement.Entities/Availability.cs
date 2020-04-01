using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Entities
{
   public class Availability
    {
        public string HotelId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int TotalRooms { get; set; }

    }
}
