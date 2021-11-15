using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public Guid CartId { get; set; }
        public Guid UserId { get; set; }
    }
}
