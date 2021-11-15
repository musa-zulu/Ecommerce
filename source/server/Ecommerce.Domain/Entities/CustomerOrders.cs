using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Entities
{
    public class CustomerOrders : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public decimal CartTotal { get; set; }
    }
}
