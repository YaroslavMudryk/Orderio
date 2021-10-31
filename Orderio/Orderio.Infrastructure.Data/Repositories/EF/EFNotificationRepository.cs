using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFNotificationRepository : EFRepository<Notification>, INotificationRepository
    {
        public EFNotificationRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
