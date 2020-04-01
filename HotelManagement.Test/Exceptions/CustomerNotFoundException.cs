using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Test.Exceptions
{
    public class CustomerNotFoundException : Exception
    {
        public string Messages = "Customer Not Found";

        public CustomerNotFoundException(string message)
        {
            Messages = message;
        }
    }


}
