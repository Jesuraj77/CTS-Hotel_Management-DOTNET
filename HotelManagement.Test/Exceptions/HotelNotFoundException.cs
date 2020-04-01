using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Test.Exceptions
{
      public class HotelNotFoundException : Exception
        {
            public string Messages = "Hotel Not Found";

            public HotelNotFoundException(string message)
            {
                Messages = message;
            }
        }

    
}
