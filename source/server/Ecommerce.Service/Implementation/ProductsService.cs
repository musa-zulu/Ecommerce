using Ecommerce.Domain.Entities;
using Ecommerce.Persistence;
using Ecommerce.Service.Contracts;

namespace Ecommerce.Service.Implementation
{
    public class ProductsService : GenericService<Product>, IProductsService
    {
        public ProductsService(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
