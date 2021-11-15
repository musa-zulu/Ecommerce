using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Dtos.Category
{
    public class AddOrEditCategoryDto : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
