using System;
using System.Collections.Generic;
using System.Text;
using HotelManagement.BusinessLayer.Interfaces;
using HotelManagement.DataLayer.NhibernateConfiguration;
using HotelManagement.Entities;

namespace HotelManagement.BusinessLayer.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IMapperSession _session;

        public CustomerServices(IMapperSession session)
        {
            _session = session;
        }
        public bool CancelReservation(string BookingId)
        {
            return true;
        }

        public bool EditReservation(Booking booking)
        {
            return true;
        }

        public Booking GetReservationByid(string BookingId)
        {
            Booking booking=new Booking();
            return booking;
        }

        public bool Login(string CustomerName, string Password)
        {
            return true;
        }

        public bool Register(Customer customer)
        {
            return true;
        }

        public bool ReserveHotel(Booking booking)
        {
            return true;
        }

        public List<Hotel> SearchHotel(string Country, string City)
        {
            List<Hotel> hotellist=new List<Hotel>();
            return hotellist;
        }
    }
}
