using Application.Repositories;

namespace Application.Service
{
    public interface IServiceManager
    {
        IUserService UserService { get; }

        IAuthService AuthService { get; }

    }
}
