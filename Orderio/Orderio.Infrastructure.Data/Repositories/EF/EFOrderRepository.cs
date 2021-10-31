using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFOrderRepository : EFRepository<Order>, IOrderRepository
    {
        public EFOrderRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
