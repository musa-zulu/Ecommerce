using System;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.Dtos.Category;

namespace Ecommerce.Domain.Dtos.Product
{
    public class AddOrEditProductDto : BaseEntity
    {
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductFileName { get; set; }
        public bool IsActive { get; set; }
        public Guid CategoryId { get; set; }
        public AddOrEditCategoryDto Category { get; set; }
    }
}
