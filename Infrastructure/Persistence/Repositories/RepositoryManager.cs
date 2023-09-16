using Application.Repositories;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly NakliyatDbContext _context;

        private readonly ICustomerRepository _customerRepository;

        public RepositoryManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public ICustomerRepository CustomerRepository => _customerRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
