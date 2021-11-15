using Ecommerce.Domain.Common;
using System;
using System.Collections.Generic;

namespace Ecommerce.Domain.Entities
{
    public class Category : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
