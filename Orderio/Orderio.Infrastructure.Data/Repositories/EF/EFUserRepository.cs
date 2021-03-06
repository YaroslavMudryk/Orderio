using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFUserRepository : EFRepository<User>, IUserRepository
    {
        public EFUserRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
