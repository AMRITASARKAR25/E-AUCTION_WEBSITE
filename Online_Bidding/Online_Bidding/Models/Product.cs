using System;
using System.Collections.Generic;

#nullable disable

namespace Online_Bidding.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDescription { get; set; }
        public string DetailedDescription { get; set; }
        public string Category { get; set; }
        public decimal? StartingPrice { get; set; }
        public DateTime? BidEndDate { get; set; }
    }
}
