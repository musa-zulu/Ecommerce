using System;
using Ecommerce.Domain.Common;
using Ecommerce.Domain.Dtos.Cart;
using Ecommerce.Domain.Dtos.Product;

namespace Ecommerce.Domain.Dtos.CartItems
{
    public class AddOrEditCartItemsDto : BaseEntity
    {
        public Guid CartItemId { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public bool IsActive { get; set; }
        public AddOrEditProductDto Product { get; set; }
        public AddOrEditCartDto Cart { get; set; }
    }
}
