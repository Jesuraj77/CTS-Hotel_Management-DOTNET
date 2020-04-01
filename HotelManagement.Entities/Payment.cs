using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagement.Entities
{
   public class Payment
    {
        public string BankName { get; set; }
        public int CreditCardNumber { get; set; }
        public string CardType { get; set; }
        public string NameOncard { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVVNumber { get; set; }
        public int AccountNumber { get; set; }
        public int PinNumber { get; set; }
    }
}
