﻿using Orderio.Domain.Interfaces;
using Orderio.Domain.Models;
using Orderio.Infrastructure.Data.EntityFramework.Context;

namespace Orderio.Infrastructure.Data.Repositories.EF
{
    public class EFUserRoleRepository : EFRepository<UserRole>, IUserRoleRepository
    {
        public EFUserRoleRepository(OrderioContext db) : base(db)
        {
            
        }
    }
}
