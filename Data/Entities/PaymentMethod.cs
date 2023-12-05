using System;
using System.Collections.Generic;

namespace ExampleCollection.Data.Entities
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Method { get; set; }
        public int? Deadline { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
