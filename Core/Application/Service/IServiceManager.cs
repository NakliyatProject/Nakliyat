using Application.Repositories;

namespace Application.Service
{
    public interface IServiceManager
    {
        ICustomerService CustomerService { get; }
        ITasimaTalebiService TasimaTalebiService { get; }
        IEkipService EkipService { get; }
        IAuthService AuthService { get; }

    }
}
