using Microsoft.EntityFrameworkCore;
using Orderio.Domain.Models;
using System.Collections.Generic;

namespace Orderio.Infrastructure.Data.EntityFramework.Context
{
    public class OrderioContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public OrderioContext(DbContextOptions<OrderioContext> options) : base(options)
        {
            Database.EnsureCreated();

            if (!Users.AnyAsync().GetAwaiter().GetResult())
            {
                Users.AddRangeAsync(new List<User>
                {
                    new User
                    {
                        FullName = "Yaroslav Mudryk",
                        UserName = "Yarik08",
                        CreatedAt = System.DateTime.Now,
                        CreatedBy = "0",
                        CreatedFromIP = "::1"
                    },
                    new User
                    {
                        FullName = "Mykyta Medko",
                        UserName = "Barbosa1800",
                        CreatedAt = System.DateTime.Now,
                        CreatedBy = "0",
                        CreatedFromIP = "::1"
                    },
                    new User
                    {
                        FullName = "Zhdan Chernavskiy",
                        UserName = "ZhdanDev",
                        CreatedAt = System.DateTime.Now,
                        CreatedBy = "0",
                        CreatedFromIP = "::1"
                    }
                }).GetAwaiter().GetResult();
                SaveChanges();
            }
        }
    }
}