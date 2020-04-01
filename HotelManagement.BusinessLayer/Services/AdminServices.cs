using System; 
using System.Collections.Generic;
using System.Text;
using HotelManagement.BusinessLayer.Interfaces;
using HotelManagement.DataLayer.NhibernateConfiguration;
using HotelManagement.Entities;

namespace HotelManagement.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }
        public bool AddHotel(Hotel hotel)
        {
            return true; 
        }

        public bool DeleteHotel(string HotelId)
        {
            return true;
        }

        public bool EditHotel(Hotel hotel)
        {
            return true;
        }

        public Availability GetHotelAvailabilityById(string HotelId)
        {
            Availability availability=new Availability();
            return availability;
        }

        public Hotel GetHotelById(string HotelId)
        {
            Hotel hotel =new Hotel();
            return hotel;
        }

        public Availability SearchHotel(string HotelId)
        {
            Availability availability=new Availability();
            return availability;
        }
    }
}
