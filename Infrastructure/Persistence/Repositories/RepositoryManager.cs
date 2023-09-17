using Application.Repositories;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly NakliyatDbContext _context;

        private readonly ICustomerRepository _customerRepository;
        private readonly ITasimaTalebiRepository _tasimaTalebiRepository;


        public RepositoryManager(ICustomerRepository customerRepository, ITasimaTalebiRepository tasimaTalebiRepository)
        {
            _customerRepository = customerRepository;
            _tasimaTalebiRepository = tasimaTalebiRepository;
        }

        public ICustomerRepository CustomerRepository => _customerRepository;

        public ITasimaTalebiRepository TasimaTalebiRepository => _tasimaTalebiRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
