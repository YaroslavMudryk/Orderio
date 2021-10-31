using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFCompanyRepository : EFRepository<Company>, ICompanyRepository
    {
        public EFCompanyRepository(OrderioContext db) : base(db)
        {

        }
    }
}
