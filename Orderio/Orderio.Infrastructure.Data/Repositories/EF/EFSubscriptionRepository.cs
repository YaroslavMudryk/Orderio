using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFSubscriptionRepository : EFRepository<Subscription>, ISubscriptionRepository
    {
        public EFSubscriptionRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
