using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Entities
{
   public class Booking
    {
        public string HotelId { get; set; }
        public DateTime BookingDate {get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime Departure { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberofChildern { get; set; }
        public int NumberofNights { get; set; }
        public int TotalRooms { get; set; }
        public string RoomType { get; set; }
        public string BookingId { get; set; }
    }
}
