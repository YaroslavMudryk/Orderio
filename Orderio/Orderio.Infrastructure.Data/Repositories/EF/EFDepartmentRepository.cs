using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFDepartmentRepository : EFRepository<Department>, IDepartmentRepository
    {
        public EFDepartmentRepository(OrderioContext db) : base(db)
        {

        }
    }
}
