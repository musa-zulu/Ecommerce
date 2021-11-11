using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Persistence
{
    public interface IApplicationDbContext
    {
        //DbSet<Object> Objects { get; set; }
        Task<int> SaveChangesAsync();
    }
}
