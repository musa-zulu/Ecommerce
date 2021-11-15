using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Dtos.CustomerOrders
{
    public class AddOrEditCustomerOrdersDto : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public bool IsActive { get; set; }
        public decimal CartTotal { get; set; }
    }
}
