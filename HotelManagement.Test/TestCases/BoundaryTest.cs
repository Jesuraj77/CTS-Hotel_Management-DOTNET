using System;
using System.Collections.Generic;
using System.Text;
using HotelManagement.Entities;
using Xunit;

namespace HotelManagement.Test.TestCases
{
   public class BoundaryTest
    {
        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            Customer customer = new Customer()
            {
                Password = "111"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForContactNumber_Length()
        {

            Customer customer = new Customer()
            {
                ContactNumber = 9066567887
            };
            //Arrange
            var MinLength = 10;
            var MaxLength = 10;

            //Action
            var actualLength = customer.ContactNumber.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


        [Fact]
        public void BoundaryTest_ForCustomerName_Length()
        {

            Customer customer = new Customer()
            {
                CustomerName = "aa"
            };
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = customer.CustomerName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForAdultRate_in_AC()
        {

            Hotel hotel = new Hotel()
            {
                RateForAdultinAC =2545
            };
            //Arrange
            var MinLength = 2500;
            var MaxLength = 4000;

            //Action
            var actualLength = hotel.RateForAdultinAC.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForChildrenRate_in_AC()
        {

            Hotel hotel = new Hotel()
            {
                RateForChilderninAC = 2545
            };
            //Arrange
            var MinLength = 2000;
            var MaxLength = 3000;

            //Action
            var actualLength = hotel.RateForChilderninAC.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForAdultRate_in_NonAC()
        {

            Hotel hotel = new Hotel()
            {
                RateForAdultinAC = 2545
            };
            //Arrange
            var MinLength = 2000;
            var MaxLength = 2500;

            //Action
            var actualLength = hotel.RateForAdultinAC.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
        [Fact]
        public void BoundaryTest_ForChildrenRate_in_NonAC()
        {

            Hotel hotel = new Hotel()
            {
                RateForChilderninAC = 1545
            };
            //Arrange
            var MinLength = 1000;
            var MaxLength = 2000;

            //Action
            var actualLength = hotel.RateForChilderninAC.ToString().Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }


    }
}
