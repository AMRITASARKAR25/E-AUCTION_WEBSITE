using System;
using System.Collections.Generic;

#nullable disable

namespace Online_Bidding.Models
{
    public partial class Seller
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int? PinCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
