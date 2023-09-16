using Application.Repositories;

namespace Application.Service
{
    public interface IServiceManager
    {
        ICustomerService UserService { get; }

        IAuthService AuthService { get; }

    }
}
