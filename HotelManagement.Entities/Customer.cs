using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Entities
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long ContactNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
    }
}
