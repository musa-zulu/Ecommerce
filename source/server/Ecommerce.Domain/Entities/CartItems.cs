using Ecommerce.Domain.Common;
using System;

namespace Ecommerce.Domain.Entities
{
    public class CartItems : BaseEntity
    {
        public Guid CartItemId { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
    }
}
