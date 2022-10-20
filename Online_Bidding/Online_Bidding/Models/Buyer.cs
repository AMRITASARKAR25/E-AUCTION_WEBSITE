using System;
using System.Collections.Generic;

#nullable disable

namespace Online_Bidding.Models
{
    public partial class Buyer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Pin { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int? ProductId { get; set; }
        public decimal? BidAmount { get; set; }

        public virtual Product Product { get; set; }
    }
}
