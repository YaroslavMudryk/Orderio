using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFOrderStatusRepository : EFRepository<OrderStatus>, IOrderStatusRepository
    {
        public EFOrderStatusRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
