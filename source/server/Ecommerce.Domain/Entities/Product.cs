﻿using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductFileName { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
