using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFProductRepository : EFRepository<Product>, IProductRepository
    {
        public EFProductRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
