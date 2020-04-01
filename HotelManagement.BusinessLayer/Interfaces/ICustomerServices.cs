using System;
using System.Collections.Generic;
using System.Text;
using HotelManagement.Entities;

namespace HotelManagement.BusinessLayer.Interfaces
{
   public interface ICustomerServices
    {
        List<Hotel> SearchHotel(string Country,string City);
        bool ReserveHotel(Booking booking);
        bool EditReservation(Booking booking);
        Booking GetReservationByid(string BookingId);
        bool CancelReservation(string BookingId);
        bool Register(Customer customer);
        bool Login(string CustomerName, string Password);
    }
}
