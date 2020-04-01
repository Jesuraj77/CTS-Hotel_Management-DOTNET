using System;
using System.Collections.Generic;
using System.Text;
using HotelManagement.BusinessLayer.Services;
using HotelManagement.DataLayer.NhibernateConfiguration;
using HotelManagement.Entities;
using NSubstitute;
using Xunit;

namespace HotelManagement.Test
{
   public class FunctionalTest
    {
        private readonly AdminServices _adminServices;
        private readonly CustomerServices _customerServices;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
            _adminServices = new AdminServices(_session);
            _customerServices = new CustomerServices(_session);
        }

        //Admin services

        Hotel hotel = new Hotel
        {
            HotelId = "ayo1234",
            HotelName = "ayodya",
            Country = "India",
            City = "Gadag",
            HotelDescription = "abc",
            NumberofACRooms = 30,
            RateForAdultinAC = 4000,
            RateForChilderninAC = 3000,
            RateForAdultinNonAC = 3000,
            RateForChildreninNonAC = 2000

        };
        [Fact]
        public void TestForAddHotel()
        {
            //Action
            var IsAdded = _adminServices.AddHotel(hotel);
            //Assert
            Assert.True(IsAdded);
        }

        [Fact]
        public void TestForUpdateHotel()
        {
            //Action
            var gethotel = _adminServices.GetHotelById(hotel.HotelId);
            var updatedhotel = _adminServices.EditHotel(hotel);
            //Assert
            Assert.True(updatedhotel);
        }


        [Fact]
        public void TestForDeleteuser()
        {
            //Action
            var deletedhotel = _adminServices.DeleteHotel(hotel.HotelId);
            //Assert
            Assert.True(deletedhotel);
        }
        [Fact]
        public void TestforSearchHotel()
        {
           

            var result = _adminServices.SearchHotel(hotel.HotelId);
            var GetAvailability = _adminServices.GetHotelAvailabilityById(hotel.HotelId);

            Assert.Equal(GetAvailability, result);

        }

        //customer servives test cases

        Customer customer = new Customer
        {
            CustomerId=3,
            CustomerName="Customer",
            Password="123",
            ConfirmPassword="123",
            DateOfBirth=DateTime.Now,
            ContactNumber=9898765653,
            Email="example@gmail.com",
            Country="india",
            City="gadag",
            Pincode=123456
        };
        Booking booking = new Booking
        {
            HotelId="ayo1234",
            BookingDate=DateTime.Now,
            ArrivalDate= DateTime.Now,
            Departure= DateTime.Now,
            NumberOfAdults=2,
            NumberofChildern=1,
            NumberofNights=1,
            TotalRooms=1,
            RoomType="AC",
            BookingId="Ayd345"
        };

        [Fact]
        public void TestforRegister()
        {
           
            var SignUp = _customerServices.Register(customer);
            Assert.True(SignUp);
        }

        [Fact]
        public void TestforLogin()
        {
            Customer Customer = new Customer()
            {
                CustomerName = "aaa",
                Password = "1234"
            };
            var SignIn = _customerServices.Login(Customer.CustomerName, Customer.Password);
            Assert.True(SignIn);

        }
        [Fact]
        public void TestForReservation()
        {
            //Action
            var IsBooked = _customerServices.ReserveHotel(booking);
            //Assert
            Assert.True(IsBooked);
        }

        [Fact]
        public void TestForUpdatereservation()
        {
            //Action
            var getbooking = _customerServices.GetReservationByid(booking.BookingId);
            var updatebooking = _customerServices.EditReservation(booking);
            //Assert
            Assert.True(updatebooking);
        }


        [Fact]
        public void TestForCancelReservation()
        {
            //Action
            var deletedReservation = _customerServices.CancelReservation(booking.BookingId);
            //Assert
            Assert.True(deletedReservation);
        }

        }
}
