using Application.Repositories;
using Application.Service;
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
            services.AddScoped<IUserRepository, UserRepository>();


            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();


        }
    }
}
