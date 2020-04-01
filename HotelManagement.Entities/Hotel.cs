using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Entities
{
   public class Hotel
    {
        public int Id { get; set; }
        public string HotelId { get; set; }
        public string HotelName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string HotelDescription { get; set; }
        public int NumberofACRooms { get; set; }
        public int RateForAdultinAC { get; set; }
        public int RateForChilderninAC { get; set; }
        public int RateForAdultinNonAC { get; set; }
        public int RateForChildreninNonAC { get; set; }

    }
}
