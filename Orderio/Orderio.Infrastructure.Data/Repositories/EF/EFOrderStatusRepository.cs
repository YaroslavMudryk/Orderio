using Microsoft.EntityFrameworkCore;
using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFOrderStatusRepository : EFRepository<OrderStatus>, IOrderStatusRepository
    {
        public EFOrderStatusRepository(OrderioContext db) : base(db)
        {
            
        }

        public async Task<List<OrderStatus>> GetAllOrderStatusesAsync(long orderId)
        {
            return await _db.OrderStatuses
                .Where(x => x.OrderId == orderId)
                .AsNoTracking()
                .Include(x => x.Status)
                .ToListAsync();
        }
    }
}