using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Persistence
{
    public interface IApplicationDbContext
    {
        DbSet<Cart> Carts { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; } 
        DbSet<CartItems> CartItems { get; set; }
        DbSet<CustomerOrders> CustomerOrders { get; set; }
        Task<int> SaveChangesAsync();
    }
}
