using Application.Repositories;

namespace Application.Service
{
    public interface IServiceManager
    {
        public IUserService UserService { get; }

    }
}
