using Application.Repositories;
using Application.Service;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories;
using Persistence.Service;

namespace Persistence
{
    public static class ServiceRegisteration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<NakliyatDbContext>(options => options.UseNpgsql(Configuration.ConnectionString), ServiceLifetime.Singleton);
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ITasimaTalebiRepository, TasimaTalebiRepository>();



            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ITasimaTalebiService, TasimaTalebiService>();


        }
    }
}
