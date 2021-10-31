using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFStatusRepository : EFRepository<Status>, IStatusRepository
    {
        public EFStatusRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
