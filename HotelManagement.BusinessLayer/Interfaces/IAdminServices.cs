using System;
using System.Collections.Generic;
using System.Text;
using HotelManagement.Entities;

namespace HotelManagement.BusinessLayer.Interfaces
{
    public interface IAdminServices
    {
        bool AddHotel(Hotel hotel);
        Hotel GetHotelById(string HotelId);
        bool EditHotel(Hotel hotel);
        Availability SearchHotel(string HotelId);
        Availability GetHotelAvailabilityById(string HotelId);
        bool DeleteHotel(string HotelId);
    }
}
