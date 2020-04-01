using System;
using System.Collections.Generic;
using System.Text;
using FluentNHibernate.Mapping;
using HotelManagement.Entities;

namespace HotelManagement.DataLayer.Mapping
{
   public class HotelMap:ClassMap<Hotel>
    {
        public HotelMap()
        {
            Id(x => x.Id);
            Map(x => x.HotelId);
            Map(x => x.HotelName);
            Map(x => x.Country);
            Map(x => x.City);
            Map(x => x.HotelDescription);
            Map(x => x.NumberofACRooms);
            Map(x => x.RateForAdultinAC);
            Map(x => x.RateForChilderninAC);
            Map(x => x.RateForAdultinNonAC);
            Map(x => x.RateForChildreninNonAC);
            Table("hotel");
        }
    }
}
