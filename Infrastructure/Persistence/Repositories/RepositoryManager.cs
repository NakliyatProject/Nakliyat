using Application.Repositories;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly NakliyatDbContext _context;

        private readonly ICustomerRepository _customerRepository;
        private readonly ITasimaTalebiRepository _tasimaTalebiRepository;
        private readonly IEkipRepository _ekipRepository;


        public RepositoryManager(ICustomerRepository customerRepository, ITasimaTalebiRepository tasimaTalebiRepository, IEkipRepository ekipRepository)
        {
            _customerRepository = customerRepository;
            _tasimaTalebiRepository = tasimaTalebiRepository;
            _ekipRepository = ekipRepository;
        }

        public ICustomerRepository CustomerRepository => _customerRepository;

        public ITasimaTalebiRepository TasimaTalebiRepository => _tasimaTalebiRepository;
        public IEkipRepository EkipRepository => _ekipRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
