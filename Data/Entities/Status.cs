using System;
using System.Collections.Generic;

namespace ExampleCollection.Data.Entities
{
    public partial class Status
    {
        public Status()
        {
            OrderItems = new HashSet<OrderItem>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
