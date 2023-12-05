using System;
using System.Collections.Generic;

namespace ExampleCollection.Data.Entities
{
    public partial class Vat
    {
        public Vat()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int? Percentage { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
