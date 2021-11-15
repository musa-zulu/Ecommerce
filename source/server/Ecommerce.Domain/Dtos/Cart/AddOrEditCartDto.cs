using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Dtos.Cart
{
    public class AddOrEditCartDto : BaseEntity
    {
        public Guid CartId { get; set; }
        public Guid UserId { get; set; }
    }
}
