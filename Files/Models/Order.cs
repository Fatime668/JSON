using System;
using System.Collections.Generic;
using System.Text;

namespace Files.Models
{
    class Order
    {
        public int Id { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public double TotalPrice { get; set; }
    }
}
