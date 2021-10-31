using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Orderio.Application.Services.Implementations;
using Orderio.Application.Services.Intefaces;
using Orderio.Domain.Interfaces;
using Orderio.Infrastructure.Data.EntityFramework.Context;
using Orderio.Infrastructure.Data.Repositories.EF;

namespace Orderio.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddOrderioServices(this IServiceCollection services)
        {
            services.AddDbContext<OrderioContext>(x =>
            {
                x.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=OrderioDb;Trusted_Connection=True;");
            });

            //repositories
            services.AddScoped<ICompanyRepository, EFCompanyRepository>();
            services.AddScoped<IDepartmentRepository, EFDepartmentRepository>();
            services.AddScoped<INotificationRepository, EFNotificationRepository>();
            services.AddScoped<IOrderRepository, EFOrderRepository>();
            services.AddScoped<IOrderStatusRepository, EFOrderStatusRepository>();
            services.AddScoped<IProductRepository, EFProductRepository>();
            services.AddScoped<IRoleRepository, EFRoleRepository>();
            services.AddScoped<IStatusRepository, EFStatusRepository>();
            services.AddScoped<ISubscriptionRepository, EFSubscriptionRepository>();
            services.AddScoped<IUserLoginRepository, EFUserLoginRepository>();
            services.AddScoped<IUserRepository, EFUserRepository>();
            services.AddScoped<IUserRoleRepository, EFUserRoleRepository>();

            //services
            services.AddScoped<IUserService, UserService>();



            return services;
        }
    }
}
