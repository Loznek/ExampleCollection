using System;
using System.Collections.Generic;

namespace ExampleCollection.Data.Entities
{
    public partial class InvoiceItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Amount { get; set; }
        public double? Price { get; set; }
        public int? Vatpercentage { get; set; }
        public int? InvoiceId { get; set; }
        public int? OrderItemId { get; set; }

        public virtual Invoice? Invoice { get; set; }
        public virtual OrderItem? OrderItem { get; set; }
    }
}
