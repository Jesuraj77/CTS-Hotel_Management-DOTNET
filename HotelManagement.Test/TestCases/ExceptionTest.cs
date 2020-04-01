using System;
using System.Collections.Generic;
using System.Text;
using HotelManagement.BusinessLayer.Services;
using HotelManagement.DataLayer.NhibernateConfiguration;
using HotelManagement.Entities;
using HotelManagement.Test.Exceptions;
using NSubstitute;
using Xunit;

namespace HotelManagement.Test.TestCases
{
   public class ExceptionTest
    {
        private readonly AdminServices _Adminservices;
        private readonly CustomerServices _Customerservices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _Adminservices = new AdminServices(_session);
            _Customerservices = new CustomerServices(_session);
        }

        [Fact]
        public void ExceptionTestFor_CustomerNotFound()
        {
            Customer customer = new Customer()
            {
                CustomerName = "abc",
                 Password = "111"
            };

            //Assert
            var ex = Assert.Throws<CustomerNotFoundException>(() => _Customerservices.Login(customer.CustomerName, customer.Password));
            Assert.Equal("CutermorNotFound Not Found ", ex.Messages);
        }


        [Fact]
        public void ExceptionTestFor_HotelNotFound()
        {
            Customer customer = new Customer()
            {
                Country = "India",
                 City = "aa"
            };

            //Assert
            var ex = Assert.Throws<HotelNotFoundException>(() => _Customerservices.SearchHotel(customer.Country, customer.City));
            Assert.Equal("HotelNotFound Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_HotelNotFoundForAdmin()
        {
            Hotel hotel = new Hotel()
            {
                HotelId = "ayo4331"

            };

            //Assert
            var ex = Assert.Throws<HotelNotFoundException>(() => _Adminservices.SearchHotel(hotel.HotelId));
            Assert.Equal("HotelNotFound Not Found ", ex.Messages);
        }




    }
}
