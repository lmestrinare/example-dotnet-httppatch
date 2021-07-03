using System.Collections.Generic;

namespace HttpPatch.Models
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }
    }
}