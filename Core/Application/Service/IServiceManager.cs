using Application.Repositories;

namespace Application.Service
{
    public interface IServiceManager
    {
        ICustomerService CustomerService { get; }
        ITasimaTalebiService TasimaTalebiService { get; }
        IAuthService AuthService { get; }

    }
}
