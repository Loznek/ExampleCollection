using System;
using System.Collections.Generic;

namespace ExampleCollection.Data.Entities
{
    public partial class CategoryWithParent
    {
        public string? CategoryName { get; set; }
        public string? ParentCategoryName { get; set; }
    }
}
